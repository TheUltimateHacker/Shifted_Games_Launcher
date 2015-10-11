using System;

namespace Shifted_Games_Launcher_GTK
{
	public partial class About : Gtk.Dialog
	{
		public About ()
		{
			this.Build ();
			txtabout.Buffer.Text = txtabout.Buffer.Text.Replace ("{VER}", MainClass.Version).Replace ("{CODENAME}", MainClass.Codename);
		}

		protected void CloseAbout (object sender, EventArgs e)
		{
			this.Hide ();
		}
	}
}

