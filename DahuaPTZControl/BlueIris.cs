using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace DahuaPTZControl
{
	public class BlueIris
	{
		static BlueIris()
		{
		}
		WebClient wc;
		int port;
		string url, user, password, session;

		public BlueIris(int blueIrisHttpPort, string blueIrisUser, string blueIrisPassword)
		{
			this.port = blueIrisHttpPort;
			this.user = blueIrisUser;
			this.password = blueIrisPassword;

			wc = new WebClient();
			wc.Proxy = null;
			url = "http://localhost:" + port + "/json";
		}

		public bool Login()
		{
			string response = wc.UploadString(url, "{\"cmd\":\"login\"}");

			var r1 = JSON.ParseJson(response);
			session = r1.session;

			// Why Blue Iris uses MD5 for security is beyond me.
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] input = System.Text.Encoding.ASCII.GetBytes(user + ":" + session + ":" + password);
			byte[] hash = md5.ComputeHash(input);
			var sbAuth = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
				sbAuth.Append(hash[i].ToString("X2"));

			response = wc.UploadString(url, "{\"cmd\":\"login\",\"session\":\"" + session + "\",\"response\":\"" + sbAuth + "\"}");

			var r2 = JSON.ParseJson(response);
			return r2.result == "success";
		}

		public bool Logout()
		{
			string response = wc.UploadString(url, "{\"cmd\":\"logout\",\"session\":\"" + session + "\"}");
			var r1 = JSON.ParseJson(response);
			return r1.result == "success";
		}

		public bool Trigger(string cameraShortName)
		{
			string response = wc.UploadString(url, "{\"cmd\":\"trigger\",\"camera\":\"" + cameraShortName + "\",\"session\":\"" + session + "\"}");
			var r1 = JSON.ParseJson(response);
			return r1.result == "success";
		}

		public static bool Trigger(string cameraShortName, int blueIrisHttpPort, string blueIrisUser, string blueIrisPassword)
		{
			BlueIris bi = new BlueIris(blueIrisHttpPort, blueIrisUser, blueIrisPassword);
			if (bi.Login())
			{
				bool success = bi.Trigger(cameraShortName);
				bi.Logout();
				return success;
			}
			return false;
		}
	}
}
