using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;

namespace DahuaPTZControl
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			else
			{
				//for (int i = 0; i < args.Length; i++)
				//    File.AppendAllText("LastCommand.txt", DateTime.Now.ToString() + " " + args[i] + Environment.NewLine);
				try
				{
					DahuaPTZSettings settings = new DahuaPTZSettings();
					DahuaPTZ ptz = new DahuaPTZ(settings.ip, settings.user, settings.password);
					string arg = args[0];
					if (arg == "UP")
					{
						ptz.Move(0, settings.tiltAmount * -1000, 0);
					}
					else if (arg == "DOWN")
					{
						ptz.Move(0, settings.tiltAmount * 1000, 0);
					}
					else if (arg == "LEFT")
					{
						ptz.Move(settings.panAmount * -1000, 0, 0);
					}
					else if (arg == "RIGHT")
					{
						ptz.Move(settings.panAmount * 1000, 0, 0);
					}
					else if (arg == "ZOOMIN")
					{
						ptz.Move(0, 0, settings.zoomAmount);
					}
					else if (arg == "ZOOMOUT")
					{
						ptz.Move(0, 0, -settings.zoomAmount);
					}
					else if (arg == "HOME")
					{
						ptz.PositionABS(0, 0, 0);
					}
					else if (arg.StartsWith("PRESET,"))
					{
						string[] parts = arg.Split(',');
						if (parts.Length == 2)
						{
							int preset = int.Parse(parts[1]);
							ptz.GotoPreset(preset);
						}
						else if (parts.Length == 3)
						{
							int preset = int.Parse(parts[1]);
							if (parts[2] == "SET")
							{
								if(settings.allowPresetSetting)
									ptz.SetPreset(preset);
							}
							else if (parts[2] == "CALL")
							{
								ptz.GotoPreset(preset);
								if (settings.triggerAfterPreset)
								{
									SetAllowUnsafeHeaderParsing20();
									EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);
									ewh.WaitOne(settings.triggerDelayMS);
									BlueIris.Trigger(settings.cameraShortName, settings.blueIrisHttpPort, settings.blueIrisUser, settings.blueIrisPassword);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					File.AppendAllText("DahuaPTZControl_Errors.txt", ex.ToString());
				}
			}
		}

		private static bool SetAllowUnsafeHeaderParsing20()
		{
			//Get the assembly that contains the internal class
			Assembly aNetAssembly = Assembly.GetAssembly(typeof(System.Net.Configuration.SettingsSection));
			if (aNetAssembly != null)
			{
				//Use the assembly in order to get the internal type for the internal class
				Type aSettingsType = aNetAssembly.GetType("System.Net.Configuration.SettingsSectionInternal");
				if (aSettingsType != null)
				{
					//Use the internal static property to get an instance of the internal settings class.
					//If the static instance isn't created allready the property will create it for us.
					object anInstance = aSettingsType.InvokeMember("Section",
					  BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.NonPublic, null, null, new object[] { });

					if (anInstance != null)
					{
						//Locate the private bool field that tells the framework is unsafe header parsing should be allowed or not
						FieldInfo aUseUnsafeHeaderParsing = aSettingsType.GetField("useUnsafeHeaderParsing", BindingFlags.NonPublic | BindingFlags.Instance);
						if (aUseUnsafeHeaderParsing != null)
						{
							aUseUnsafeHeaderParsing.SetValue(anInstance, true);
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
