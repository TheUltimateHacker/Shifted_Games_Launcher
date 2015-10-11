
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action LauncherOptionsAction;
	
	private global::Gtk.Action Action1;
	
	private global::Gtk.Action SettingsAction;
	
	private global::Gtk.Action GameManagementAction;
	
	private global::Gtk.Action PlacesAction;
	
	private global::Gtk.Action VisitOurWebsiteAction;
	
	private global::Gtk.Action ViewGameFolderInFileBrowserAction;
	
	private global::Gtk.Action CheckAllGamesForUpdatesAction;
	
	private global::Gtk.Action GlobalSettingsAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action AboutTheLauncherAction;
	
	private global::Gtk.Action btnrefresh;
	
	private global::Gtk.Action RefreshAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar SettingsBar;
	
	private global::Gtk.Notebook notebook1;
	
	private global::Gtk.HPaned hpaned5;
	
	private global::Gtk.ScrolledWindow libraryholder;
	
	private global::Gtk.TreeView library;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Label lbgamename;
	
	private global::Gtk.Fixed fixed2;
	
	private global::Gtk.Label lbdescription;
	
	private global::Gtk.HButtonBox gameactions;
	
	private global::Gtk.Button btnviewfolder;
	
	private global::Gtk.Button btnlaunch;
	
	private global::Gtk.Button btnuninstall;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.HPaned hpaned1;
	
	private global::Gtk.VBox storeinfo;
	
	private global::Gtk.Label lbstorename;
	
	private global::Gtk.Table tbgameinfo;
	
	private global::Gtk.Label lbstoredesc;
	
	private global::Gtk.Table table2;
	
	private global::Gtk.Label lbstoregenre;
	
	private global::Gtk.Label lbstoreplatform;
	
	private global::Gtk.Label lbstoreversion;
	
	private global::Gtk.HButtonBox storeactions;
	
	private global::Gtk.Button btndownload;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TreeView nd_store;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Label lbstatus;
	
	private global::Gtk.ToggleButton tbtnshowprogress;
	
	private global::Gtk.Statusbar statusbar5;
	
	private global::Gtk.Label lbprog;
	
	private global::Gtk.ProgressBar prgdownloading;
	
	private global::Gtk.Button btncancel;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.LauncherOptionsAction = new global::Gtk.Action ("LauncherOptionsAction", global::Mono.Unix.Catalog.GetString ("Launcher Options"), null, null);
		this.LauncherOptionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Launcher Options");
		w1.Add (this.LauncherOptionsAction, null);
		this.Action1 = new global::Gtk.Action ("Action1", null, null, null);
		w1.Add (this.Action1, null);
		this.SettingsAction = new global::Gtk.Action ("SettingsAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, null);
		this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
		w1.Add (this.SettingsAction, null);
		this.GameManagementAction = new global::Gtk.Action ("GameManagementAction", global::Mono.Unix.Catalog.GetString ("Game Management"), null, null);
		this.GameManagementAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Game Management");
		w1.Add (this.GameManagementAction, null);
		this.PlacesAction = new global::Gtk.Action ("PlacesAction", global::Mono.Unix.Catalog.GetString ("Places"), null, null);
		this.PlacesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Places");
		w1.Add (this.PlacesAction, null);
		this.VisitOurWebsiteAction = new global::Gtk.Action ("VisitOurWebsiteAction", global::Mono.Unix.Catalog.GetString ("Visit Our Website"), null, null);
		this.VisitOurWebsiteAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Visit Our Website");
		w1.Add (this.VisitOurWebsiteAction, null);
		this.ViewGameFolderInFileBrowserAction = new global::Gtk.Action ("ViewGameFolderInFileBrowserAction", global::Mono.Unix.Catalog.GetString ("View Game Folder In File Browser..."), null, null);
		this.ViewGameFolderInFileBrowserAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("View Game Folder In File Browser...");
		w1.Add (this.ViewGameFolderInFileBrowserAction, null);
		this.CheckAllGamesForUpdatesAction = new global::Gtk.Action ("CheckAllGamesForUpdatesAction", global::Mono.Unix.Catalog.GetString ("Check All Games for Updates"), null, null);
		this.CheckAllGamesForUpdatesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Check All Games for Updates");
		w1.Add (this.CheckAllGamesForUpdatesAction, null);
		this.GlobalSettingsAction = new global::Gtk.Action ("GlobalSettingsAction", global::Mono.Unix.Catalog.GetString ("Global Settings"), null, null);
		this.GlobalSettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Global Settings");
		w1.Add (this.GlobalSettingsAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.AboutTheLauncherAction = new global::Gtk.Action ("AboutTheLauncherAction", global::Mono.Unix.Catalog.GetString ("About the Launcher"), null, null);
		this.AboutTheLauncherAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About the Launcher");
		w1.Add (this.AboutTheLauncherAction, null);
		this.btnrefresh = new global::Gtk.Action ("btnrefresh", null, null, "gtk-undo");
		w1.Add (this.btnrefresh, null);
		this.RefreshAction = new global::Gtk.Action ("RefreshAction", global::Mono.Unix.Catalog.GetString ("Refresh"), null, null);
		this.RefreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Refresh");
		w1.Add (this.RefreshAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Shifted Games Launcher");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='SettingsBar'><menu name='SettingsAction' action='SettingsAction'><menuitem name='GlobalSettingsAction' action='GlobalSettingsAction'/></menu><menu name='GameManagementAction' action='GameManagementAction'><menuitem name='ViewGameFolderInFileBrowserAction' action='ViewGameFolderInFileBrowserAction'/><menuitem name='CheckAllGamesForUpdatesAction' action='CheckAllGamesForUpdatesAction'/></menu><menu name='PlacesAction' action='PlacesAction'><menuitem name='VisitOurWebsiteAction' action='VisitOurWebsiteAction'/></menu><menu name='AboutAction' action='AboutAction'><menuitem name='AboutTheLauncherAction' action='AboutTheLauncherAction'/></menu></menubar></ui>");
		this.SettingsBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/SettingsBar")));
		this.SettingsBar.Name = "SettingsBar";
		this.vbox1.Add (this.SettingsBar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.SettingsBar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook ();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 1;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.hpaned5 = new global::Gtk.HPaned ();
		this.hpaned5.CanFocus = true;
		this.hpaned5.Name = "hpaned5";
		this.hpaned5.Position = 61;
		// Container child hpaned5.Gtk.Paned+PanedChild
		this.libraryholder = new global::Gtk.ScrolledWindow ();
		this.libraryholder.HeightRequest = 300;
		this.libraryholder.Name = "libraryholder";
		this.libraryholder.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child libraryholder.Gtk.Container+ContainerChild
		this.library = new global::Gtk.TreeView ();
		this.library.CanFocus = true;
		this.library.Name = "library";
		this.libraryholder.Add (this.library);
		this.hpaned5.Add (this.libraryholder);
		global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.hpaned5 [this.libraryholder]));
		w4.Resize = false;
		w4.Shrink = false;
		// Container child hpaned5.Gtk.Paned+PanedChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lbgamename = new global::Gtk.Label ();
		this.lbgamename.Name = "lbgamename";
		this.lbgamename.LabelProp = global::Mono.Unix.Catalog.GetString ("Game");
		this.vbox2.Add (this.lbgamename);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lbgamename]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.lbdescription = new global::Gtk.Label ();
		this.lbdescription.WidthRequest = 500;
		this.lbdescription.HeightRequest = 256;
		this.lbdescription.Name = "lbdescription";
		this.lbdescription.LabelProp = global::Mono.Unix.Catalog.GetString (@"This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. This is a description. ");
		this.lbdescription.Wrap = true;
		this.fixed2.Add (this.lbdescription);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.lbdescription]));
		w6.X = 17;
		w6.Y = 53;
		this.vbox2.Add (this.fixed2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fixed2]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.gameactions = new global::Gtk.HButtonBox ();
		this.gameactions.Name = "gameactions";
		// Container child gameactions.Gtk.ButtonBox+ButtonBoxChild
		this.btnviewfolder = new global::Gtk.Button ();
		global::Gtk.Tooltips w8 = new Gtk.Tooltips ();
		w8.SetTip (this.btnviewfolder, "Opens the game\'s install folder. Useful for modding.", "Opens the game\'s install folder. Useful for modding.");
		this.btnviewfolder.CanFocus = true;
		this.btnviewfolder.Name = "btnviewfolder";
		this.btnviewfolder.UseUnderline = true;
		this.btnviewfolder.Label = global::Mono.Unix.Catalog.GetString ("Open Game Folder");
		this.gameactions.Add (this.btnviewfolder);
		global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.gameactions [this.btnviewfolder]));
		w9.Expand = false;
		w9.Fill = false;
		// Container child gameactions.Gtk.ButtonBox+ButtonBoxChild
		this.btnlaunch = new global::Gtk.Button ();
		w8.SetTip (this.btnlaunch, "Launches the game.\n\nNote: If the game is not available on your platform, it will " +
		"not launch.", "Launches the game.\n\nNote: If the game is not available on your platform, it will " +
		"not launch.");
		this.btnlaunch.CanFocus = true;
		this.btnlaunch.Name = "btnlaunch";
		this.btnlaunch.UseUnderline = true;
		this.btnlaunch.Label = global::Mono.Unix.Catalog.GetString ("Launch");
		this.gameactions.Add (this.btnlaunch);
		global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.gameactions [this.btnlaunch]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child gameactions.Gtk.ButtonBox+ButtonBoxChild
		this.btnuninstall = new global::Gtk.Button ();
		w8.SetTip (this.btnuninstall, "Uninstalls the game and removes it from the launcher.", "Uninstalls the game and removes it from the launcher.");
		this.btnuninstall.CanFocus = true;
		this.btnuninstall.Name = "btnuninstall";
		this.btnuninstall.UseUnderline = true;
		this.btnuninstall.Label = global::Mono.Unix.Catalog.GetString ("Uninstall");
		this.gameactions.Add (this.btnuninstall);
		global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.gameactions [this.btnuninstall]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox2.Add (this.gameactions);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.gameactions]));
		w12.Position = 2;
		this.hpaned5.Add (this.vbox2);
		this.notebook1.Add (this.hpaned5);
		// Notebook tab
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("My Games");
		this.notebook1.SetTabLabel (this.hpaned5, this.label1);
		this.label1.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 85;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.storeinfo = new global::Gtk.VBox ();
		this.storeinfo.Name = "storeinfo";
		this.storeinfo.Spacing = 6;
		// Container child storeinfo.Gtk.Box+BoxChild
		this.lbstorename = new global::Gtk.Label ();
		this.lbstorename.Name = "lbstorename";
		this.lbstorename.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.storeinfo.Add (this.lbstorename);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.storeinfo [this.lbstorename]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child storeinfo.Gtk.Box+BoxChild
		this.tbgameinfo = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
		this.tbgameinfo.Name = "tbgameinfo";
		this.tbgameinfo.RowSpacing = ((uint)(6));
		this.tbgameinfo.ColumnSpacing = ((uint)(6));
		// Container child tbgameinfo.Gtk.Table+TableChild
		this.lbstoredesc = new global::Gtk.Label ();
		this.lbstoredesc.Name = "lbstoredesc";
		this.lbstoredesc.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.lbstoredesc.Wrap = true;
		this.tbgameinfo.Add (this.lbstoredesc);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tbgameinfo [this.lbstoredesc]));
		w16.TopAttach = ((uint)(1));
		w16.BottomAttach = ((uint)(2));
		// Container child tbgameinfo.Gtk.Table+TableChild
		this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.lbstoregenre = new global::Gtk.Label ();
		this.lbstoregenre.Name = "lbstoregenre";
		this.lbstoregenre.LabelProp = global::Mono.Unix.Catalog.GetString ("label6");
		this.table2.Add (this.lbstoregenre);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.lbstoregenre]));
		w17.TopAttach = ((uint)(2));
		w17.BottomAttach = ((uint)(3));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.lbstoreplatform = new global::Gtk.Label ();
		this.lbstoreplatform.Name = "lbstoreplatform";
		this.lbstoreplatform.LabelProp = global::Mono.Unix.Catalog.GetString ("label4");
		this.table2.Add (this.lbstoreplatform);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.lbstoreplatform]));
		w18.TopAttach = ((uint)(1));
		w18.BottomAttach = ((uint)(2));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.lbstoreversion = new global::Gtk.Label ();
		this.lbstoreversion.Name = "lbstoreversion";
		this.lbstoreversion.LabelProp = global::Mono.Unix.Catalog.GetString ("label3");
		this.lbstoreversion.Justify = ((global::Gtk.Justification)(2));
		this.table2.Add (this.lbstoreversion);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.lbstoreversion]));
		w19.XOptions = ((global::Gtk.AttachOptions)(4));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		this.tbgameinfo.Add (this.table2);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.tbgameinfo [this.table2]));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		this.storeinfo.Add (this.tbgameinfo);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.storeinfo [this.tbgameinfo]));
		w21.Position = 1;
		// Container child storeinfo.Gtk.Box+BoxChild
		this.storeactions = new global::Gtk.HButtonBox ();
		this.storeactions.HeightRequest = 35;
		this.storeactions.Name = "storeactions";
		// Container child storeactions.Gtk.ButtonBox+ButtonBoxChild
		this.btndownload = new global::Gtk.Button ();
		this.btndownload.CanFocus = true;
		this.btndownload.Name = "btndownload";
		this.btndownload.UseUnderline = true;
		this.btndownload.Label = global::Mono.Unix.Catalog.GetString ("Download");
		this.storeactions.Add (this.btndownload);
		global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.storeactions [this.btndownload]));
		w22.Expand = false;
		w22.Fill = false;
		this.storeinfo.Add (this.storeactions);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.storeinfo [this.storeactions]));
		w23.PackType = ((global::Gtk.PackType)(1));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		this.hpaned1.Add (this.storeinfo);
		global::Gtk.Paned.PanedChild w24 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.storeinfo]));
		w24.Resize = false;
		w24.Shrink = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name=\'menubar1\'><menu name=\'RefreshAction\' action=\'RefreshAction\'/><" +
		"/menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox3.Add (this.menubar1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.menubar1]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.nd_store = new global::Gtk.TreeView ();
		this.nd_store.CanFocus = true;
		this.nd_store.Name = "nd_store";
		this.GtkScrolledWindow1.Add (this.nd_store);
		this.vbox3.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow1]));
		w27.Position = 1;
		this.hpaned1.Add (this.vbox3);
		this.notebook1.Add (this.hpaned1);
		global::Gtk.Notebook.NotebookChild w29 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.hpaned1]));
		w29.Position = 1;
		// Notebook tab
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Shifted Store");
		this.notebook1.SetTabLabel (this.hpaned1, this.label2);
		this.label2.ShowAll ();
		this.vbox1.Add (this.notebook1);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
		w30.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		this.hbox3.BorderWidth = ((uint)(2));
		// Container child hbox3.Gtk.Box+BoxChild
		this.lbstatus = new global::Gtk.Label ();
		this.lbstatus.Events = ((global::Gdk.EventMask)(65536));
		this.lbstatus.Name = "lbstatus";
		this.lbstatus.LabelProp = global::Mono.Unix.Catalog.GetString ("Nothing\'s happening.");
		this.hbox3.Add (this.lbstatus);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.lbstatus]));
		w31.Position = 0;
		w31.Expand = false;
		w31.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.tbtnshowprogress = new global::Gtk.ToggleButton ();
		this.tbtnshowprogress.CanFocus = true;
		this.tbtnshowprogress.Events = ((global::Gdk.EventMask)(256));
		this.tbtnshowprogress.Name = "tbtnshowprogress";
		this.tbtnshowprogress.UseUnderline = true;
		this.tbtnshowprogress.Label = global::Mono.Unix.Catalog.GetString ("Show/Hide Progress");
		this.hbox3.Add (this.tbtnshowprogress);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.tbtnshowprogress]));
		w32.Position = 1;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.statusbar5 = new global::Gtk.Statusbar ();
		this.statusbar5.Name = "statusbar5";
		this.statusbar5.Spacing = 6;
		// Container child statusbar5.Gtk.Box+BoxChild
		this.lbprog = new global::Gtk.Label ();
		this.lbprog.Name = "lbprog";
		this.lbprog.LabelProp = global::Mono.Unix.Catalog.GetString ("{0} of {1} bytes");
		this.statusbar5.Add (this.lbprog);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.statusbar5 [this.lbprog]));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		// Container child statusbar5.Gtk.Box+BoxChild
		this.prgdownloading = new global::Gtk.ProgressBar ();
		this.prgdownloading.Name = "prgdownloading";
		this.statusbar5.Add (this.prgdownloading);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.statusbar5 [this.prgdownloading]));
		w34.Position = 2;
		// Container child statusbar5.Gtk.Box+BoxChild
		this.btncancel = new global::Gtk.Button ();
		this.btncancel.CanFocus = true;
		this.btncancel.Name = "btncancel";
		this.btncancel.UseUnderline = true;
		this.btncancel.Label = global::Mono.Unix.Catalog.GetString ("Cancel Download");
		this.statusbar5.Add (this.btncancel);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.statusbar5 [this.btncancel]));
		w35.PackType = ((global::Gtk.PackType)(1));
		w35.Position = 3;
		w35.Expand = false;
		w35.Fill = false;
		this.hbox3.Add (this.statusbar5);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.statusbar5]));
		w36.Position = 2;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w37.PackType = ((global::Gtk.PackType)(1));
		w37.Position = 2;
		w37.Expand = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1009;
		this.DefaultHeight = 504;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.VisitOurWebsiteAction.Activated += new global::System.EventHandler (this.OpenWebsite);
		this.AboutTheLauncherAction.Activated += new global::System.EventHandler (this.ShowAbout);
		this.btnrefresh.Activated += new global::System.EventHandler (this.Refresh_Store);
		this.library.RowActivated += new global::Gtk.RowActivatedHandler (this.SetupGameInfoField);
		this.btnlaunch.Clicked += new global::System.EventHandler (this.LaunchGame);
		this.btndownload.Entered += new global::System.EventHandler (this.StartGameDownload);
		this.nd_store.RowActivated += new global::Gtk.RowActivatedHandler (this.Store_Click);
		this.tbtnshowprogress.Clicked += new global::System.EventHandler (this.ToggleProgressVisibility);
	}
}