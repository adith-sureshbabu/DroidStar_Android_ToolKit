namespace DroidAppStar
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
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gradientPanel1 = new DroidAppStar.GradientPanel();
            this.transparentTabControl1 = new DroidAppStar.TransparentTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnRebootBootloader = new System.Windows.Forms.Button();
            this.btnRebootRecovery = new System.Windows.Forms.Button();
            this.btnInstallApk = new System.Windows.Forms.Button();
            this.txtSideloadZip = new System.Windows.Forms.TextBox();
            this.txtInstallApk = new System.Windows.Forms.TextBox();
            this.btnSideloadZip = new System.Windows.Forms.Button();
            this.btnBrowseApk = new System.Windows.Forms.Button();
            this.btnBrowseZip = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRootCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblSystemAppsCount = new System.Windows.Forms.Label();
            this.lblUserAppsCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReadApps = new System.Windows.Forms.Button();
            this.btnUninstallApk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.llbRefresh = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxConsole = new System.Windows.Forms.RichTextBox();
            this.gradientPanel1.SuspendLayout();
            this.transparentTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Teal;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Maroon;
            this.gradientPanel1.Controls.Add(this.transparentTabControl1);
            this.gradientPanel1.Controls.Add(this.groupBox2);
            this.gradientPanel1.Controls.Add(this.groupBox3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(661, 475);
            this.gradientPanel1.TabIndex = 13;
            // 
            // transparentTabControl1
            // 
            this.transparentTabControl1.Controls.Add(this.tabPage4);
            this.transparentTabControl1.Controls.Add(this.tabPage5);
            this.transparentTabControl1.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F);
            this.transparentTabControl1.Location = new System.Drawing.Point(0, 81);
            this.transparentTabControl1.Name = "transparentTabControl1";
            this.transparentTabControl1.SelectedIndex = 0;
            this.transparentTabControl1.Size = new System.Drawing.Size(661, 214);
            this.transparentTabControl1.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(653, 187);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Home";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnReboot);
            this.groupBox4.Controls.Add(this.btnRebootBootloader);
            this.groupBox4.Controls.Add(this.btnRebootRecovery);
            this.groupBox4.Controls.Add(this.btnInstallApk);
            this.groupBox4.Controls.Add(this.txtSideloadZip);
            this.groupBox4.Controls.Add(this.txtInstallApk);
            this.groupBox4.Controls.Add(this.btnSideloadZip);
            this.groupBox4.Controls.Add(this.btnBrowseApk);
            this.groupBox4.Controls.Add(this.btnBrowseZip);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F);
            this.groupBox4.Location = new System.Drawing.Point(211, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 177);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btnReboot
            // 
            this.btnReboot.ForeColor = System.Drawing.Color.Black;
            this.btnReboot.Location = new System.Drawing.Point(6, 128);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(118, 25);
            this.btnReboot.TabIndex = 18;
            this.btnReboot.Text = "Reboot Device";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnRebootBootloader
            // 
            this.btnRebootBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnRebootBootloader.Location = new System.Drawing.Point(296, 128);
            this.btnRebootBootloader.Name = "btnRebootBootloader";
            this.btnRebootBootloader.Size = new System.Drawing.Size(133, 25);
            this.btnRebootBootloader.TabIndex = 17;
            this.btnRebootBootloader.Text = "Reboot to Bootloader";
            this.btnRebootBootloader.UseVisualStyleBackColor = true;
            this.btnRebootBootloader.Click += new System.EventHandler(this.btnRebootBootloader_Click);
            // 
            // btnRebootRecovery
            // 
            this.btnRebootRecovery.ForeColor = System.Drawing.Color.Black;
            this.btnRebootRecovery.Location = new System.Drawing.Point(146, 128);
            this.btnRebootRecovery.Name = "btnRebootRecovery";
            this.btnRebootRecovery.Size = new System.Drawing.Size(129, 25);
            this.btnRebootRecovery.TabIndex = 16;
            this.btnRebootRecovery.Text = "Reboot to Recovery";
            this.btnRebootRecovery.UseVisualStyleBackColor = true;
            this.btnRebootRecovery.Click += new System.EventHandler(this.btnRebootRecovery_Click);
            // 
            // btnInstallApk
            // 
            this.btnInstallApk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInstallApk.Location = new System.Drawing.Point(346, 74);
            this.btnInstallApk.Name = "btnInstallApk";
            this.btnInstallApk.Size = new System.Drawing.Size(83, 25);
            this.btnInstallApk.TabIndex = 8;
            this.btnInstallApk.Text = "Install APK";
            this.btnInstallApk.UseVisualStyleBackColor = true;
            this.btnInstallApk.Click += new System.EventHandler(this.btnInstallApk_Click);
            // 
            // txtSideloadZip
            // 
            this.txtSideloadZip.Location = new System.Drawing.Point(85, 26);
            this.txtSideloadZip.Name = "txtSideloadZip";
            this.txtSideloadZip.ReadOnly = true;
            this.txtSideloadZip.Size = new System.Drawing.Size(255, 20);
            this.txtSideloadZip.TabIndex = 13;
            // 
            // txtInstallApk
            // 
            this.txtInstallApk.Location = new System.Drawing.Point(85, 76);
            this.txtInstallApk.Name = "txtInstallApk";
            this.txtInstallApk.ReadOnly = true;
            this.txtInstallApk.Size = new System.Drawing.Size(255, 20);
            this.txtInstallApk.TabIndex = 7;
            // 
            // btnSideloadZip
            // 
            this.btnSideloadZip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSideloadZip.Location = new System.Drawing.Point(346, 24);
            this.btnSideloadZip.Name = "btnSideloadZip";
            this.btnSideloadZip.Size = new System.Drawing.Size(83, 25);
            this.btnSideloadZip.TabIndex = 14;
            this.btnSideloadZip.Text = "Sideload ZIP";
            this.btnSideloadZip.UseVisualStyleBackColor = true;
            this.btnSideloadZip.Click += new System.EventHandler(this.btnSideloadZip_Click);
            // 
            // btnBrowseApk
            // 
            this.btnBrowseApk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowseApk.Location = new System.Drawing.Point(6, 74);
            this.btnBrowseApk.Name = "btnBrowseApk";
            this.btnBrowseApk.Size = new System.Drawing.Size(73, 25);
            this.btnBrowseApk.TabIndex = 6;
            this.btnBrowseApk.Text = "Browse";
            this.btnBrowseApk.UseVisualStyleBackColor = true;
            this.btnBrowseApk.Click += new System.EventHandler(this.btnBrowseApk_Click);
            // 
            // btnBrowseZip
            // 
            this.btnBrowseZip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowseZip.Location = new System.Drawing.Point(6, 24);
            this.btnBrowseZip.Name = "btnBrowseZip";
            this.btnBrowseZip.Size = new System.Drawing.Size(73, 25);
            this.btnBrowseZip.TabIndex = 12;
            this.btnBrowseZip.Text = "Browse";
            this.btnBrowseZip.UseVisualStyleBackColor = true;
            this.btnBrowseZip.Click += new System.EventHandler(this.btnBrowseZip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRootCheck);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 177);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Root/BusyBox";
            // 
            // btnRootCheck
            // 
            this.btnRootCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRootCheck.Location = new System.Drawing.Point(6, 23);
            this.btnRootCheck.Name = "btnRootCheck";
            this.btnRootCheck.Size = new System.Drawing.Size(75, 25);
            this.btnRootCheck.TabIndex = 0;
            this.btnRootCheck.Text = "Root Check";
            this.btnRootCheck.UseVisualStyleBackColor = true;
            this.btnRootCheck.Click += new System.EventHandler(this.btnRootCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "BusyBox:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Root Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "---";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.ForeColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(653, 187);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Uninstall";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lblSystemAppsCount);
            this.groupBox5.Controls.Add(this.lblUserAppsCount);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtSearch);
            this.groupBox5.Controls.Add(this.listView1);
            this.groupBox5.Controls.Add(this.btnReadApps);
            this.groupBox5.Controls.Add(this.btnUninstallApk);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(654, 180);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select Apps to Uninstall";
            // 
            // lblSystemAppsCount
            // 
            this.lblSystemAppsCount.AutoSize = true;
            this.lblSystemAppsCount.ForeColor = System.Drawing.Color.White;
            this.lblSystemAppsCount.Location = new System.Drawing.Point(592, 17);
            this.lblSystemAppsCount.Name = "lblSystemAppsCount";
            this.lblSystemAppsCount.Size = new System.Drawing.Size(19, 14);
            this.lblSystemAppsCount.TabIndex = 23;
            this.lblSystemAppsCount.Text = "---";
            // 
            // lblUserAppsCount
            // 
            this.lblUserAppsCount.AutoSize = true;
            this.lblUserAppsCount.ForeColor = System.Drawing.Color.White;
            this.lblUserAppsCount.Location = new System.Drawing.Point(473, 17);
            this.lblUserAppsCount.Name = "lblUserAppsCount";
            this.lblUserAppsCount.Size = new System.Drawing.Size(19, 14);
            this.lblUserAppsCount.TabIndex = 22;
            this.lblUserAppsCount.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(515, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "System Apps:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "User Apps:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(458, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(11, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 149);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Package";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Label";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            this.columnHeader3.Width = 64;
            // 
            // btnReadApps
            // 
            this.btnReadApps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReadApps.Location = new System.Drawing.Point(411, 96);
            this.btnReadApps.Name = "btnReadApps";
            this.btnReadApps.Size = new System.Drawing.Size(225, 25);
            this.btnReadApps.TabIndex = 15;
            this.btnReadApps.Text = "Read Phone Packages";
            this.btnReadApps.UseVisualStyleBackColor = true;
            this.btnReadApps.Click += new System.EventHandler(this.btnReadApps_Click);
            // 
            // btnUninstallApk
            // 
            this.btnUninstallApk.Enabled = false;
            this.btnUninstallApk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUninstallApk.Location = new System.Drawing.Point(411, 138);
            this.btnUninstallApk.Name = "btnUninstallApk";
            this.btnUninstallApk.Size = new System.Drawing.Size(225, 25);
            this.btnUninstallApk.TabIndex = 16;
            this.btnUninstallApk.Text = "Uninstall APK";
            this.btnUninstallApk.UseVisualStyleBackColor = true;
            this.btnUninstallApk.Click += new System.EventHandler(this.btnUninstallApk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbModel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbDevices);
            this.groupBox2.Controls.Add(this.llbRefresh);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 67);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device - Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Android Version:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Model:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Serial Number:";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(53, 26);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(159, 22);
            this.cmbModel.TabIndex = 2;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "---";
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(308, 26);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(159, 22);
            this.cmbDevices.TabIndex = 2;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // llbRefresh
            // 
            this.llbRefresh.AutoSize = true;
            this.llbRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.llbRefresh.Location = new System.Drawing.Point(598, 29);
            this.llbRefresh.Name = "llbRefresh";
            this.llbRefresh.Size = new System.Drawing.Size(43, 14);
            this.llbRefresh.TabIndex = 3;
            this.llbRefresh.TabStop = true;
            this.llbRefresh.Text = "Refresh";
            this.llbRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRefresh_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rtxConsole);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 170);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console";
            // 
            // rtxConsole
            // 
            this.rtxConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtxConsole.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxConsole.ForeColor = System.Drawing.Color.Lime;
            this.rtxConsole.Location = new System.Drawing.Point(6, 20);
            this.rtxConsole.Name = "rtxConsole";
            this.rtxConsole.ReadOnly = true;
            this.rtxConsole.Size = new System.Drawing.Size(642, 143);
            this.rtxConsole.TabIndex = 1;
            this.rtxConsole.Text = ">>";
            this.rtxConsole.TextChanged += new System.EventHandler(this.rtxConsole_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(661, 475);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroidStar - Android ToolKit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.transparentTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.LinkLabel llbRefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxConsole;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TransparentTabControl transparentTabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnRebootBootloader;
        private System.Windows.Forms.Button btnRebootRecovery;
        private System.Windows.Forms.Button btnInstallApk;
        private System.Windows.Forms.TextBox txtSideloadZip;
        private System.Windows.Forms.TextBox txtInstallApk;
        private System.Windows.Forms.Button btnSideloadZip;
        private System.Windows.Forms.Button btnBrowseApk;
        private System.Windows.Forms.Button btnBrowseZip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRootCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSystemAppsCount;
        private System.Windows.Forms.Label lblUserAppsCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnReadApps;
        private System.Windows.Forms.Button btnUninstallApk;
    }
}

