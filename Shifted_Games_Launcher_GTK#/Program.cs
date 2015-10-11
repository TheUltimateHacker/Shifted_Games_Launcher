using System;
using Gtk;


namespace Shifted_Games_Launcher_GTK
{
	class MainClass
	{

		public static string Version = "1.1";
		public static string Codename = "New Bluecoast";
		public static string NewVersion;
		public static string NewCodename;
		public static string NewDL;

		public static void Main (string[] args)
		{
			Gtk.Application.Init ();
			MainWindow win = new MainWindow();
			Gtk.Application.Run ();
		}

		public static void RunUpdate() {
			//WebClient to get the new .exe
			System.Net.WebClient wc = new System.Net.WebClient();
			string appfile = "";
			string appfolder = AppDomain.CurrentDomain.BaseDirectory;
			foreach (string fil in System.IO.Directory.GetFiles(appfolder)) {
				System.IO.FileInfo filinf = new System.IO.FileInfo (fil);
				if (filinf.Extension == ".exe") {
					appfile = filinf.FullName;
					break;
				}
			}
			if (appfile != "") {
				wc.DownloadFile (NewDL, appfile);
				System.Diagnostics.Process.Start (appfile);
				Gtk.Application.Quit ();
			}
		}

		public static bool CheckForUpdates() {
			//Result.
			bool result;
			//WebClient to download a JSON file.
			System.Net.WebClient wc = new System.Net.WebClient ();

			//Output JSON file
			Uri server = new Uri("http://198.8.95.3");

			string jsonupdate_raw = wc.DownloadString(server);

			if (jsonupdate_raw != "") {
			//Parsed JSON output of launcher release
				LauncherRelease metadata = Newtonsoft.Json.JsonConvert.DeserializeObject<LauncherRelease>(jsonupdate_raw);

			if (metadata.Version != Version) {
				result = true;
				NewVersion = metadata.Version;
				NewCodename = metadata.Codename;
				NewDL = metadata.DownloadURL;
			} else {
				result = false;
			}
			} else {
				result = false;
			}
			return result;
		}
	}
}
