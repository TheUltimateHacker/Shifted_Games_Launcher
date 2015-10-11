using System;
using System.Net;
using Gtk;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Launchpad.Launcher;
using System.IO.Compression;
using Shifted_Games_Launcher_GTK;
public partial class MainWindow: Gtk.Window
{
	public ListStore gamelibrary_2 = null;
	public string gametolaunch; 
	public string gamedownloadlink;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		setupui ();
		//Check for Launcher Updates
		if (MainClass.CheckForUpdates () == true) {
			MessageDialog md = new MessageDialog (this, 
				DialogFlags.DestroyWithParent, MessageType.Info, 
				ButtonsType.Close, "A new update has been released. We will install it for you. The launcher will close. When you run it again, you will be on the updated version." + Environment.NewLine + Environment.NewLine + "Version: " + MainClass.NewVersion + " '" + MainClass.NewCodename + "' ");
			md.Run ();
			md.Destroy ();
			MainClass.RunUpdate ();
		}
	}

	public void setupListStores() {
		//Add a ListStore to the Library's model
		ListStore games = new ListStore(typeof (string), typeof(GameInfo), typeof(string));
		ListStore storegames = new ListStore (typeof(string), typeof(StoreGame));
		library.Model = games;
		nd_store.Model = storegames;



		//Populate Store
		foreach (string file in files) {
			if (file.Contains(".json")) {
				Download (file, storegames);
			}
		}


		//Populate Library
		PopulateLibrary(games);
	}

	public void setupui() {

		//Update Store
		downloadAllFiles();
		//At this point, the front-end should be loaded.

		//Setup UI
		lbgamename.ModifyFont(Pango.FontDescription.FromString("Arial 16"));
		notebook1.CurrentPage = 0;
		gameactions.Hide ();
		lbgamename.Hide ();
		lbdescription.Hide ();

		//library tree bugfix
		storeinfo.WidthRequest = 400;
		libraryholder.WidthRequest = 300;

		//Setup Store default UI
		lbstorename.ModifyFont(Pango.FontDescription.FromString("Arial 16"));
		lbstorename.Text = "Shifted Store";
		lbstoreplatform.Text = "";
		lbstoreversion.Text = "";
		lbstoregenre.Text = "";
		lbstoredesc.Text = "Welcome to the Shifted Store. The Shifted Store hosts all sorts of games ranging from simple arcade games to ShiftOS-likes to full-on third-person action games. Everything here can be picked up and added to your launcher any time you want. As long as you have an Internet connection, that is. Contact Michael on the forums if you'd like to get your game on the Shifted Store.";
		storeactions.Hide ();



		//Set up the Library's columns
		TreeViewColumn gamename = new TreeViewColumn();
		TreeViewColumn storegamename = new TreeViewColumn();

		gamename.Title = "Name";
		storegamename.Title = "Game";
		library.AppendColumn (gamename);
		nd_store.AppendColumn (storegamename);

		setupListStores ();

		//Add a cell that will display the name of each game
		CellRendererText gamecell = new CellRendererText();
		CellRendererText storecell = new CellRendererText ();
		gamename.PackStart (gamecell, true);
		storegamename.PackStart (storecell, true);
		gamename.AddAttribute (gamecell, "text", 0);
		storegamename.AddAttribute (storecell, "text", 0);


		//Tell the status area what state it should be in
		SetStatusState(EStatusState.Idle);

	}

	internal void SetStatusState (EStatusState State) {
		switch (State) {
		case EStatusState.Idle:
			lbstatus.Text = "Nothing's happening.";
			tbtnshowprogress.Hide ();
			lbprog.Hide ();
			prgdownloading.Hide ();
			btncancel.Hide ();
			break;
		case EStatusState.Error:
			lbstatus.Text = "Fatal error has occurred.";
			tbtnshowprogress.Hide ();
			lbprog.Hide ();
			prgdownloading.Hide ();
			btncancel.Hide ();
			break;
		default:
			//Nothing.
			break;
		}
	}



	public void PopulateLibrary (ListStore list) {
		list.Clear ();
		if (Directory.Exists (AppDomain.CurrentDomain.BaseDirectory + "/Games")) {
			//If the Games directory exists, start iterating through each subdirectory
			string[] dirs = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + "/Games");
			//If the games directory actually HAS games, add 'em to the library.
			if (dirs.Length > 0) {
				foreach (string dir in dirs) {
					if (File.Exists (dir + "/metadata.json")) {
						DirectoryInfo dirinf = new DirectoryInfo (dir);
						string metadatajson = File.ReadAllText (dir + "/metadata.json");
						GameInfo game = Newtonsoft.Json.JsonConvert.DeserializeObject<GameInfo> (metadatajson);
						list.AppendValues (game.Name, game, dirinf.Name);

					}
				}
				//If not, tell the user they don't have any.
			} else {
				list.AppendValues ("No games installed yet.");
			}
		} else {
			//If not, create the directory.
			Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/Games");
			list.AppendValues ("No games installed yet.");
		}


	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OpenWebsite(object sender, EventArgs a) {
		System.Diagnostics.Process.Start ("http://www.shiftgames.ml");
	}

	protected void ToggleProgressVisibility (object sender, EventArgs e)
	{
		if (tbtnshowprogress.Active == true) {
			lbprog.Hide ();
			prgdownloading.Hide ();

		} else {
			lbprog.Show ();
			prgdownloading.Show ();
		}
	}

	protected void ShowAbout (object sender, EventArgs e)
	{
		Shifted_Games_Launcher_GTK.About abdiag = new Shifted_Games_Launcher_GTK.About ();
		abdiag.Show ();
	}

	protected void SetupGameInfoField (object o, RowActivatedArgs args)
	{

		//Setup text
		GameInfo metadata = new GameInfo();
		string treename; //In case the selected game isn't a game...
		TreeSelection selection = (o as TreeView).Selection;
		TreeModel model;
		TreeIter iter;
		// The iter will point to the selected row
		if (selection.GetSelected (out model, out iter)) {
			treename = (string)model.GetValue (iter, 0);
			switch (treename) {
			case "No games installed yet.":
				lbgamename.Text = "No games installed!";
				lbdescription.Text = "Well, it seems you don't have any games! But, don't worry. We'll get you covered. You can visit the online game download center and pick up some new games from us at Shifted Games, and from the community. You can also add non-Shifted games to the launcher, though that requires a bit more work.";

				break;
			default:
				metadata = (GameInfo)model.GetValue (iter, 1);
				string gamefolder = (string)model.GetValue (iter, 2);
				lbgamename.Text = metadata.Name;
				lbdescription.Text = "Version: " + metadata.GameVersion + Environment.NewLine + "Genre: " + metadata.Genre + Environment.NewLine + Environment.NewLine + metadata.GameDescription;


				gametolaunch = "/" + gamefolder + "/" + metadata.MainExecutable;
				break;
			}


		}
		//Hide the Game Actions bar if the "game" isn't a game
		if (metadata.Name == "no") {
			gameactions.Hide ();
		} else {
			gameactions.Show ();
		}
		//Show the Game Info screen

		lbgamename.Show ();
		lbdescription.Show ();


	}

	protected void LaunchGame (object sender, EventArgs e)
	{
		string gamefolder = AppDomain.CurrentDomain.BaseDirectory + "Games" + gametolaunch;
		gamefolder = gamefolder.Replace ("/", "\\");
		if (File.Exists (gamefolder)) { 
			System.Diagnostics.Process.Start (gamefolder);
		} else {
			MessageDialog md = new MessageDialog (this, 
				DialogFlags.DestroyWithParent, MessageType.Error, 
				ButtonsType.Close, "We couldn't launch the game. Please let the game developer know. Error Code: SFT1001    " + gamefolder);
			md.Run();
			md.Destroy();	
		}

	}

	public void ShowError(string errormsg) { 
		MessageDialog md = new MessageDialog (this, 
			DialogFlags.DestroyWithParent, MessageType.Error, 
			ButtonsType.Close, errormsg);
		md.Run ();
		md.Destroy ();
	}


	protected void Refresh_Store (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	//yes, I'm hosting the store on an x10host server. For now.
	public string ftpServerIP = "ftp.screwsubdomains.x10host.com";

	//I don't really care about hardcoding the username and password as this is closed-source. That, and the account only has read-only access.
	public string ftpUserID = "launcher@screwsubdomains.x10host.com";
	public string ftpPassword = "shg9d877435";

	//Directory to store local files.
	public string localDestnDir = AppDomain.CurrentDomain.BaseDirectory + "/Store/";

	//Remote directory
	public string remoteDir = "releases";

	public string[] files = null;
	public  void downloadAllFiles() {
		GetFileList ();

	}
	public string[] GetFileList()
	{
		string[] downloadFiles;
		StringBuilder result = new StringBuilder();
		WebResponse response = null;
		StreamReader reader = null;
		try
		{
			FtpWebRequest reqFTP;
			reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + remoteDir + "/"));
			reqFTP.UseBinary = true;
			reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
			reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
			reqFTP.Proxy = null;
			reqFTP.UsePassive = false;
			response = reqFTP.GetResponse();
			reader = new StreamReader(response.GetResponseStream());
			string line = reader.ReadLine();
			while (line != null)
			{
				result.Append(line);
				result.Append("\n");
				line = reader.ReadLine();
			}
			// to remove the trailing '\n'
			result.Remove(result.ToString().LastIndexOf('\n'), 1);
			files = result.ToString().Split('\n');
			return result.ToString().Split('\n');

		}
		catch (Exception ex)
		{
			if (reader != null)
			{
				reader.Close();
			}
			if (response != null)
			{
				response.Close();
			}                
			downloadFiles = null;
			return downloadFiles;
		}
	}

	private void Download(string file, ListStore list)
	{                       
		try
		{           
			
			WebClient wc = new WebClient();
			string rawjson = wc.DownloadString("http://" + ftpServerIP.Replace("ftp.", "") + "/" + remoteDir + "/" + file);
			StoreGame game = Newtonsoft.Json.JsonConvert.DeserializeObject<StoreGame>(rawjson);
			list.AppendValues(game.Name, game);
		}
		catch (WebException wEx)
		{
			ShowError ("An error occurred while downloading data for the Shifted Store." + wEx.Message);
		}
		catch (Exception ex)
		{

			ShowError ("A C# exception has occurred while downloading data for the Shifted Store. " + ex.Message);		
		}
	}

	protected void Store_Click (object o, RowActivatedArgs args)
	{
		//Setup text
		StoreGame metadata = new StoreGame();
		TreeSelection selection = (o as TreeView).Selection;
		TreeModel model;
		TreeIter iter;
		// The iter will point to the selected row
		if (selection.GetSelected (out model, out iter)) {
			metadata = (StoreGame)model.GetValue (iter, 1);

			lbstorename.Text = metadata.Name;
			lbstoredesc.Text = metadata.GameDescription;
			lbstoregenre.Text = "Genre: " + metadata.Genre;
			lbstoreplatform.Text = "Platform: " + metadata.Platform;
			lbstoreversion.Text = "Version: " + metadata.GameVersion;
			gamedownloadlink = metadata.ZIPDownload;
		}

		//Show the Store Actions bar.
		storeactions.Show();

	}

	protected void StartGameDownload (object sender, EventArgs e)
	{
		try {
		lbstatus.Text = "TEST";
		if (gamedownloadlink == "") {
			ShowError ("SFT1105: No download link provided in store metadata. Please try another game or contact Michael or the game developer with the issue.");

		} else {
			bool shouldinstall = true;
			lbstatus.Text = "Starting download.";
			WebClient wc = new WebClient ();
			string gamesfolder = AppDomain.CurrentDomain.BaseDirectory + "/Games/";
			string gamename = lbstorename.Text.Replace (" ", "_");
			if (!Directory.Exists (gamesfolder + gamename)) {
				Directory.CreateDirectory (gamesfolder + gamename);
			} else {
				ShowError ("You have already installed " + gamename.Replace ("_", " ") + " on this system!");
				shouldinstall = false;
			}

			string tempfolder = AppDomain.CurrentDomain.BaseDirectory + "/Temp/";
			if (!Directory.Exists (tempfolder + gamename)) {
				Directory.CreateDirectory(tempfolder + gamename);
			}

			if (shouldinstall == true) {
				lbstatus.Text = "Downloading '" + gamename + ".zip'...";
				wc.DownloadFile (new Uri (gamedownloadlink), tempfolder + gamename + ".zip");

				FileCompressionClass.DecompressToDirectory(tempfolder + gamename + ".zip", gamesfolder + gamename, (fileName) => { lbstatus.Text = "Extracting files..."; });
				//Done!
				setupListStores ();
				lbstatus.Text = "Download complete. Find your game under 'My Games'.";
			} else {
				lbstatus.Text = "Download failed; game already installed.";
			}

		}
		} catch (Exception ex) {
			ShowError ("A C# exception has occurred while installing the game. " + ex.Message);
		}
	}
}
