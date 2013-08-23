namespace DahuaPTZControl
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudPanAmount = new System.Windows.Forms.NumericUpDown();
			this.nudTiltAmount = new System.Windows.Forms.NumericUpDown();
			this.nudZoomAmount = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbHide = new System.Windows.Forms.CheckBox();
			this.cbPresetSet = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cbTriggerCameraAfterPresetCalled = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.nudSecondsBeforeTrigger = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCameraShortName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cbBIPWHide = new System.Windows.Forms.CheckBox();
			this.txtBIPassword = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtBIUser = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudBIPort = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudPanAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTiltAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudZoomAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSecondsBeforeTrigger)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBIPort)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pan Amount (0 to 32):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 207);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tilt Amount (0 to 32):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// nudPanAmount
			// 
			this.nudPanAmount.Location = new System.Drawing.Point(134, 179);
			this.nudPanAmount.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nudPanAmount.Name = "nudPanAmount";
			this.nudPanAmount.Size = new System.Drawing.Size(57, 20);
			this.nudPanAmount.TabIndex = 5;
			this.toolTip1.SetToolTip(this.nudPanAmount, "0 is no motion at all, and 32 is the maximum range of motion.");
			this.nudPanAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// nudTiltAmount
			// 
			this.nudTiltAmount.Location = new System.Drawing.Point(134, 205);
			this.nudTiltAmount.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nudTiltAmount.Name = "nudTiltAmount";
			this.nudTiltAmount.Size = new System.Drawing.Size(57, 20);
			this.nudTiltAmount.TabIndex = 6;
			this.toolTip1.SetToolTip(this.nudTiltAmount, "0 is no motion at all, and 32 is the maximum range of motion.");
			this.nudTiltAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// nudZoomAmount
			// 
			this.nudZoomAmount.Location = new System.Drawing.Point(134, 231);
			this.nudZoomAmount.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.nudZoomAmount.Name = "nudZoomAmount";
			this.nudZoomAmount.Size = new System.Drawing.Size(57, 20);
			this.nudZoomAmount.TabIndex = 7;
			this.toolTip1.SetToolTip(this.nudZoomAmount, "0 is no motion at all, and 16 is the maximum range of motion.");
			this.nudZoomAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Zoom Amount (0 to 16):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Camera IP:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(77, 49);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(114, 20);
			this.txtIP.TabIndex = 1;
			this.txtIP.Text = "192.168.1.108";
			this.toolTip1.SetToolTip(this.txtIP, "The IP address or host name of the camera.\r\n\r\nIf the camera\'s http port has been " +
        "changed \r\nfrom the default (80), then you should \r\ninclude it here (i.e. 192.168" +
        ".1.108:8888)");
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(77, 75);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(214, 20);
			this.txtUser.TabIndex = 2;
			this.txtUser.Text = "admin";
			this.toolTip1.SetToolTip(this.txtUser, "A user name used to access the camera\'s ptz.cgi page.\r\n\r\nBe sure to provide an ac" +
        "count with enough priviledges!");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "User Name:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(77, 101);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(160, 20);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "admin";
			this.toolTip1.SetToolTip(this.txtPassword, "The password used to access the camera\'s ptz.cgi page.\r\n\r\nBe sure to provide an a" +
        "ccount with enough priviledges!");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Password:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cbHide
			// 
			this.cbHide.AutoSize = true;
			this.cbHide.Checked = true;
			this.cbHide.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbHide.Location = new System.Drawing.Point(243, 103);
			this.cbHide.Name = "cbHide";
			this.cbHide.Size = new System.Drawing.Size(48, 17);
			this.cbHide.TabIndex = 4;
			this.cbHide.Text = "Hide";
			this.toolTip1.SetToolTip(this.cbHide, "Show or hide the password on this form.");
			this.cbHide.UseVisualStyleBackColor = true;
			this.cbHide.CheckedChanged += new System.EventHandler(this.cbHide_CheckedChanged);
			// 
			// cbPresetSet
			// 
			this.cbPresetSet.AutoSize = true;
			this.cbPresetSet.Checked = true;
			this.cbPresetSet.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPresetSet.Location = new System.Drawing.Point(360, 12);
			this.cbPresetSet.Name = "cbPresetSet";
			this.cbPresetSet.Size = new System.Drawing.Size(211, 17);
			this.cbPresetSet.TabIndex = 11;
			this.cbPresetSet.Text = "Allow presets to be modified by Blue Iris";
			this.toolTip1.SetToolTip(this.cbPresetSet, "If UNchecked, the Blue Iris interface will \r\nnot be able to change your presets.");
			this.cbPresetSet.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(279, 37);
			this.label7.TabIndex = 12;
			this.label7.Text = "Enter your camera\'s information below.  The specified user must have administrati" +
    "ve priviledges.";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 140);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(279, 37);
			this.label8.TabIndex = 13;
			this.label8.Text = "Specify how far the camera should pan, tilt, and zoom for each button press.";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 263);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(279, 31);
			this.label9.TabIndex = 14;
			this.label9.Text = "NOTE: As of this writing, Blue Iris does not support focus changes when using an " +
    "external script like this one.";
			// 
			// cbTriggerCameraAfterPresetCalled
			// 
			this.cbTriggerCameraAfterPresetCalled.AutoSize = true;
			this.cbTriggerCameraAfterPresetCalled.Location = new System.Drawing.Point(50, 20);
			this.cbTriggerCameraAfterPresetCalled.Name = "cbTriggerCameraAfterPresetCalled";
			this.cbTriggerCameraAfterPresetCalled.Size = new System.Drawing.Size(194, 17);
			this.cbTriggerCameraAfterPresetCalled.TabIndex = 15;
			this.cbTriggerCameraAfterPresetCalled.Text = "Trigger camera after preset is called";
			this.toolTip1.SetToolTip(this.cbTriggerCameraAfterPresetCalled, resources.GetString("cbTriggerCameraAfterPresetCalled.ToolTip"));
			this.cbTriggerCameraAfterPresetCalled.UseVisualStyleBackColor = true;
			this.cbTriggerCameraAfterPresetCalled.CheckedChanged += new System.EventHandler(this.cbTriggerCameraAfterPresetCalled_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(31, 45);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 13);
			this.label10.TabIndex = 16;
			this.label10.Text = "Wait ";
			// 
			// nudSecondsBeforeTrigger
			// 
			this.nudSecondsBeforeTrigger.DecimalPlaces = 2;
			this.nudSecondsBeforeTrigger.Enabled = false;
			this.nudSecondsBeforeTrigger.Location = new System.Drawing.Point(63, 43);
			this.nudSecondsBeforeTrigger.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.nudSecondsBeforeTrigger.Name = "nudSecondsBeforeTrigger";
			this.nudSecondsBeforeTrigger.Size = new System.Drawing.Size(57, 20);
			this.nudSecondsBeforeTrigger.TabIndex = 17;
			this.toolTip1.SetToolTip(this.nudSecondsBeforeTrigger, "The amount of time to wait after starting a GOTO PRESET \r\noperation before trigge" +
        "ring the camera\'s motion sensor in \r\nBlue Iris.");
			this.nudSecondsBeforeTrigger.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(122, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(126, 13);
			this.label11.TabIndex = 18;
			this.label11.Text = "seconds before triggering";
			// 
			// txtCameraShortName
			// 
			this.txtCameraShortName.Enabled = false;
			this.txtCameraShortName.Location = new System.Drawing.Point(113, 69);
			this.txtCameraShortName.Name = "txtCameraShortName";
			this.txtCameraShortName.Size = new System.Drawing.Size(170, 20);
			this.txtCameraShortName.TabIndex = 19;
			this.toolTip1.SetToolTip(this.txtCameraShortName, "The camera\'s short name, as configured \r\nin Blue Iris.");
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 72);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(101, 13);
			this.label12.TabIndex = 20;
			this.label12.Text = "Camera short name:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cbBIPWHide
			// 
			this.cbBIPWHide.AutoSize = true;
			this.cbBIPWHide.Checked = true;
			this.cbBIPWHide.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBIPWHide.Enabled = false;
			this.cbBIPWHide.Location = new System.Drawing.Point(233, 154);
			this.cbBIPWHide.Name = "cbBIPWHide";
			this.cbBIPWHide.Size = new System.Drawing.Size(48, 17);
			this.cbBIPWHide.TabIndex = 33;
			this.cbBIPWHide.Text = "Hide";
			this.toolTip1.SetToolTip(this.cbBIPWHide, "Show or hide the password on this form.");
			this.cbBIPWHide.UseVisualStyleBackColor = true;
			this.cbBIPWHide.CheckedChanged += new System.EventHandler(this.cbBIPWHide_CheckedChanged);
			// 
			// txtBIPassword
			// 
			this.txtBIPassword.Enabled = false;
			this.txtBIPassword.Location = new System.Drawing.Point(113, 152);
			this.txtBIPassword.Name = "txtBIPassword";
			this.txtBIPassword.PasswordChar = '*';
			this.txtBIPassword.Size = new System.Drawing.Size(114, 20);
			this.txtBIPassword.TabIndex = 32;
			this.txtBIPassword.Text = "admin";
			this.toolTip1.SetToolTip(this.txtBIPassword, "The password to access Blue Iris remotely.\r\n\r\nUser must be an administrator in or" +
        "der to trigger camera.");
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 155);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 13);
			this.label13.TabIndex = 25;
			this.label13.Text = "Blue Iris Password:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtBIUser
			// 
			this.txtBIUser.Enabled = false;
			this.txtBIUser.Location = new System.Drawing.Point(113, 126);
			this.txtBIUser.Name = "txtBIUser";
			this.txtBIUser.Size = new System.Drawing.Size(168, 20);
			this.txtBIUser.TabIndex = 31;
			this.txtBIUser.Text = "admin";
			this.toolTip1.SetToolTip(this.txtBIUser, "The user name to access Blue Iris remotely.\r\n\r\nUser must be an administrator in o" +
        "rder to trigger camera.");
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(4, 129);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(103, 13);
			this.label14.TabIndex = 24;
			this.label14.Text = "Blue Iris User Name:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudBIPort);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.cbTriggerCameraAfterPresetCalled);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.cbBIPWHide);
			this.groupBox1.Controls.Add(this.nudSecondsBeforeTrigger);
			this.groupBox1.Controls.Add(this.txtBIPassword);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtBIUser);
			this.groupBox1.Controls.Add(this.txtCameraShortName);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Location = new System.Drawing.Point(313, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 184);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Trigger camera after preset is called";
			// 
			// nudBIPort
			// 
			this.nudBIPort.Enabled = false;
			this.nudBIPort.Location = new System.Drawing.Point(113, 100);
			this.nudBIPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudBIPort.Name = "nudBIPort";
			this.nudBIPort.Size = new System.Drawing.Size(57, 20);
			this.nudBIPort.TabIndex = 36;
			this.toolTip1.SetToolTip(this.nudBIPort, "The http port that the Blue Iris web server listens on.\r\n\r\nDefault: 80");
			this.nudBIPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 102);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(101, 13);
			this.label15.TabIndex = 35;
			this.label15.Text = "Blue Iris HTTP Port:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(357, 263);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(200, 13);
			this.linkLabel1.TabIndex = 29;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://dahuaptzforblueiris.codeplex.com/";
			this.toolTip1.SetToolTip(this.linkLabel1, "Click here to load the project page on CodePlex.");
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 304);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbPresetSet);
			this.Controls.Add(this.cbHide);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudZoomAmount);
			this.Controls.Add(this.nudTiltAmount);
			this.Controls.Add(this.nudPanAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Dahua PTZ Control For Blue Iris";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.nudPanAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTiltAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudZoomAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSecondsBeforeTrigger)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBIPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudPanAmount;
		private System.Windows.Forms.NumericUpDown nudTiltAmount;
		private System.Windows.Forms.NumericUpDown nudZoomAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbHide;
		private System.Windows.Forms.CheckBox cbPresetSet;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cbTriggerCameraAfterPresetCalled;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown nudSecondsBeforeTrigger;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCameraShortName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox cbBIPWHide;
		private System.Windows.Forms.TextBox txtBIPassword;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtBIUser;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.NumericUpDown nudBIPort;
		private System.Windows.Forms.Label label15;
	}
}

