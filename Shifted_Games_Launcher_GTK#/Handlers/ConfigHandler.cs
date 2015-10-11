using System;

namespace Launchpad.Launcher
{
	public class ConfigHandler
	{
		public ConfigHandler ()
		{
		}

		public string GetFTPUrl() {
			string addr = "198.8.95.3";
			return addr;
		}


		public string GetFTPUsername() {
			string addr = "minecraft";
			return addr;
		}


		public string GetFTPPassword() {
			string addr = "DecolourizingKlatschAutonoae";
			return addr;
		}

		public static string GetUpdateCookiePath() {
			string addr = String.Format ("{0}/updates.dat", AppDomain.CurrentDomain.BaseDirectory);
			return addr;
		}
	}
}

