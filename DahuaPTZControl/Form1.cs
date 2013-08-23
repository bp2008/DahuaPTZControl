using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DahuaPTZControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadData();
		}
		private void cbHide_CheckedChanged(object sender, EventArgs e)
		{
			if (cbHide.Checked)
				txtPassword.PasswordChar = '*';
			else
				txtPassword.PasswordChar = (char)0;
		}
		private void cbBIPWHide_CheckedChanged(object sender, EventArgs e)
		{
			if (cbBIPWHide.Checked)
				txtBIPassword.PasswordChar = '*';
			else
				txtBIPassword.PasswordChar = (char)0;
		}
		private void cbTriggerCameraAfterPresetCalled_CheckedChanged(object sender, EventArgs e)
		{
			nudSecondsBeforeTrigger.Enabled = txtCameraShortName.Enabled = nudBIPort.Enabled = txtBIUser.Enabled = txtBIPassword.Enabled = cbBIPWHide.Enabled = cbTriggerCameraAfterPresetCalled.Checked;
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}
		private void LoadData()
		{
			try
			{
				DahuaPTZSettings settings = new DahuaPTZSettings();
				txtIP.Text = settings.ip;
				txtUser.Text = settings.user;
				txtPassword.Text = settings.password;
				nudPanAmount.Value = settings.panAmount;
				nudTiltAmount.Value = settings.tiltAmount;
				nudZoomAmount.Value = settings.zoomAmount;
				cbPresetSet.Checked = settings.allowPresetSetting;
				cbTriggerCameraAfterPresetCalled.Checked = settings.triggerAfterPreset;
				nudSecondsBeforeTrigger.Value = (decimal)(settings.triggerDelayMS / 1000.0);
				txtCameraShortName.Text = settings.cameraShortName;
				nudBIPort.Value = settings.blueIrisHttpPort;
				txtBIUser.Text = settings.blueIrisUser;
				txtBIPassword.Text = settings.blueIrisPassword;
			}
			catch (Exception)
			{
			}
		}
		private void SaveData()
		{
			List<string> values = new List<string>();
			values.Add(txtIP.Text);
			values.Add(txtUser.Text);
			values.Add(new Symmetric("DahuaPTZControlConfig").Encrypt(txtPassword.Text));
			values.Add(nudPanAmount.Value.ToString());
			values.Add(nudTiltAmount.Value.ToString());
			values.Add(nudZoomAmount.Value.ToString());
			values.Add(cbPresetSet.Checked ? "1" : "0");
			values.Add(cbTriggerCameraAfterPresetCalled.Checked ? "1" : "0");
			values.Add(((int)(nudSecondsBeforeTrigger.Value * 1000)).ToString());
			values.Add(txtCameraShortName.Text);
			values.Add(nudBIPort.Value.ToString());
			values.Add(txtBIUser.Text);
			values.Add(new Symmetric("DahuaPTZControlConfig").Encrypt(txtBIPassword.Text));
			File.WriteAllText("DahuaPTZControlConfig.cfg", string.Join(Environment.NewLine, values));
		}
	}
}
