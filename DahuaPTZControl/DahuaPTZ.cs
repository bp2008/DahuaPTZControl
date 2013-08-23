using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace DahuaPTZControl
{
	public class DahuaPTZSettings
	{
		public string ip;
		public string user;
		public string password;
		public int panAmount;
		public int tiltAmount;
		public int zoomAmount;
		public bool allowPresetSetting;
		public bool triggerAfterPreset = false;
		public int triggerDelayMS = 5000;
		public string cameraShortName = "";
		public int blueIrisHttpPort = 80;
		public string blueIrisUser = "admin";
		public string blueIrisPassword = "pass";

		public DahuaPTZSettings()
		{
			string[] lines = File.ReadAllLines("DahuaPTZControlConfig.cfg");
			ip = lines[0];
			user = lines[1];
			password = new Symmetric("DahuaPTZControlConfig").Decrypt(lines[2]);
			panAmount = int.Parse(lines[3]);
			tiltAmount = int.Parse(lines[4]);
			zoomAmount = int.Parse(lines[5]);
			allowPresetSetting = lines[6] == "1";
			if (lines.Length > 7)
			{
				triggerAfterPreset = lines[7] == "1";
				triggerDelayMS = int.Parse(lines[8]);
				cameraShortName = lines[9];
				blueIrisHttpPort = int.Parse(lines[10]);
				blueIrisUser = lines[11];
				blueIrisPassword = new Symmetric("DahuaPTZControlConfig").Decrypt(lines[12]);
			}
		}
	}
	public enum Direction
	{
		Up, Down, Left, Right, LeftUp, RightUp, LeftDown, RightDown
	}
	public class DahuaPTZ
	{
		string baseURL;
		WebClient wc;

		public DahuaPTZ(string host, string user, string password)
		{
			baseURL = "http://" + host + "/cgi-bin/ptz.cgi?";
			wc = new WebClient();
			wc.Proxy = null;
			wc.Credentials = new NetworkCredential(user, password);
		}

		public void Move(int xAmount, int yAmount, int zAmount)
		{
			DoAction("start", "Position", xAmount, yAmount, zAmount);
		}

		public void GotoPreset(int preset)
		{
			DoAction("start", "GotoPreset", preset, 0, 0);
		}

		public void PositionABS(int x, int y, int z)
		{
			DoAction("start", "PositionABS", x, y, z);
		}

		public void SetPreset(int preset)
		{
			DoAction("start", "SetPreset", preset, 0, 0);
		}

		protected void DoAction(string action, string code, int arg1, int arg2, int arg3)
		{
			string url = baseURL + "action=" + action + "&channel=0&code=" + code + "&arg1=" + arg1 + "&arg2=" + arg2 + "&arg3=" + arg3;
			wc.DownloadString(url);
		}
	}
}
