
namespace PCMonitor.UI
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cmbThemes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labScreenWH = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labDeviceStatus = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labComName = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labWidgetCount = new System.Windows.Forms.Label();
            this.labDevice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labRenderTime = new System.Windows.Forms.Label();
            this.labFrameCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbAutoStart = new System.Windows.Forms.CheckBox();
            this.ckbScreenProtect = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFrameTime = new System.Windows.Forms.ComboBox();
            this.numScreenprotectInterval = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCPUFans = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNetInterfaces = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkAuthor = new System.Windows.Forms.LinkLabel();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbarBrightness = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labBrightness = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnVerticalInvert = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnLandscapeInvert = new System.Windows.Forms.Button();
            this.btnLandscape = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
            this.ContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenprotectInterval)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBrightness)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "PCMonitor";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.Teal;
            this.btnStart.Location = new System.Drawing.Point(275, 441);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnStop.Location = new System.Drawing.Point(175, 441);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 41);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cmbThemes
            // 
            this.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbThemes.FormattingEnabled = true;
            this.cmbThemes.Location = new System.Drawing.Point(161, 22);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(126, 21);
            this.cmbThemes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected Theme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Device  -";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labScreenWH);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.labDeviceStatus);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.labComName);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.labWidgetCount);
            this.groupBox1.Controls.Add(this.labDevice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbThemes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(223, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info - Theme";
            // 
            // labScreenWH
            // 
            this.labScreenWH.AutoSize = true;
            this.labScreenWH.Location = new System.Drawing.Point(159, 162);
            this.labScreenWH.Name = "labScreenWH";
            this.labScreenWH.Size = new System.Drawing.Size(27, 13);
            this.labScreenWH.TabIndex = 19;
            this.labScreenWH.Text = "N/A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(79, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Width Height  -";
            // 
            // labDeviceStatus
            // 
            this.labDeviceStatus.AutoSize = true;
            this.labDeviceStatus.Location = new System.Drawing.Point(159, 113);
            this.labDeviceStatus.Name = "labDeviceStatus";
            this.labDeviceStatus.Size = new System.Drawing.Size(27, 13);
            this.labDeviceStatus.TabIndex = 17;
            this.labDeviceStatus.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(74, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Device Status  -";
            // 
            // labComName
            // 
            this.labComName.AutoSize = true;
            this.labComName.Location = new System.Drawing.Point(159, 88);
            this.labComName.Name = "labComName";
            this.labComName.Size = new System.Drawing.Size(27, 13);
            this.labComName.TabIndex = 15;
            this.labComName.Text = "N/A";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(86, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "COM Name  -";
            // 
            // labWidgetCount
            // 
            this.labWidgetCount.AutoSize = true;
            this.labWidgetCount.Location = new System.Drawing.Point(159, 138);
            this.labWidgetCount.Name = "labWidgetCount";
            this.labWidgetCount.Size = new System.Drawing.Size(27, 13);
            this.labWidgetCount.TabIndex = 13;
            this.labWidgetCount.Text = "N/A";
            // 
            // labDevice
            // 
            this.labDevice.AutoSize = true;
            this.labDevice.Location = new System.Drawing.Point(159, 63);
            this.labDevice.Name = "labDevice";
            this.labDevice.Size = new System.Drawing.Size(27, 13);
            this.labDevice.TabIndex = 12;
            this.labDevice.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Widgets quantity/Count  -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Frame Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labRenderTime);
            this.groupBox2.Controls.Add(this.labFrameCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 90);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Running Info";
            // 
            // labRenderTime
            // 
            this.labRenderTime.AutoSize = true;
            this.labRenderTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labRenderTime.Location = new System.Drawing.Point(315, 53);
            this.labRenderTime.Name = "labRenderTime";
            this.labRenderTime.Size = new System.Drawing.Size(73, 22);
            this.labRenderTime.TabIndex = 4;
            this.labRenderTime.Text = "N/A ms";
            // 
            // labFrameCount
            // 
            this.labFrameCount.AutoSize = true;
            this.labFrameCount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFrameCount.Location = new System.Drawing.Point(87, 53);
            this.labFrameCount.Name = "labFrameCount";
            this.labFrameCount.Size = new System.Drawing.Size(44, 22);
            this.labFrameCount.TabIndex = 3;
            this.labFrameCount.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time consuming to render/Frame Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rendering times/Frames";
            // 
            // ckbAutoStart
            // 
            this.ckbAutoStart.AutoSize = true;
            this.ckbAutoStart.Location = new System.Drawing.Point(18, 363);
            this.ckbAutoStart.Name = "ckbAutoStart";
            this.ckbAutoStart.Size = new System.Drawing.Size(70, 17);
            this.ckbAutoStart.TabIndex = 12;
            this.ckbAutoStart.Text = "AutoStart";
            this.ckbAutoStart.UseVisualStyleBackColor = true;
            // 
            // ckbScreenProtect
            // 
            this.ckbScreenProtect.AutoSize = true;
            this.ckbScreenProtect.Location = new System.Drawing.Point(19, 274);
            this.ckbScreenProtect.Name = "ckbScreenProtect";
            this.ckbScreenProtect.Size = new System.Drawing.Size(89, 17);
            this.ckbScreenProtect.TabIndex = 13;
            this.ckbScreenProtect.Text = "Screen saver";
            this.ckbScreenProtect.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmbFrameTime);
            this.groupBox3.Controls.Add(this.numScreenprotectInterval);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ckbAutoStart);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.cmbCPUFans);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbNetInterfaces);
            this.groupBox3.Controls.Add(this.ckbScreenProtect);
            this.groupBox3.Location = new System.Drawing.Point(21, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 408);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(170, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "ms";
            // 
            // cmbFrameTime
            // 
            this.cmbFrameTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameTime.FormattingEnabled = true;
            this.cmbFrameTime.Items.AddRange(new object[] {
            "500",
            "800",
            "1000",
            "1200"});
            this.cmbFrameTime.Location = new System.Drawing.Point(19, 44);
            this.cmbFrameTime.Name = "cmbFrameTime";
            this.cmbFrameTime.Size = new System.Drawing.Size(146, 21);
            this.cmbFrameTime.TabIndex = 12;
            // 
            // numScreenprotectInterval
            // 
            this.numScreenprotectInterval.Location = new System.Drawing.Point(19, 298);
            this.numScreenprotectInterval.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numScreenprotectInterval.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numScreenprotectInterval.Name = "numScreenprotectInterval";
            this.numScreenprotectInterval.Size = new System.Drawing.Size(48, 20);
            this.numScreenprotectInterval.TabIndex = 21;
            this.numScreenprotectInterval.Tag = "";
            this.numScreenprotectInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(16, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Screen Protector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(17, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Recommend（60~720）";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(19, 209);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(148, 20);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Value = new System.DateTime(2021, 8, 7, 0, 0, 0, 0);
            // 
            // cmbCPUFans
            // 
            this.cmbCPUFans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPUFans.FormattingEnabled = true;
            this.cmbCPUFans.Location = new System.Drawing.Point(19, 98);
            this.cmbCPUFans.Name = "cmbCPUFans";
            this.cmbCPUFans.Size = new System.Drawing.Size(148, 21);
            this.cmbCPUFans.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "CPU Fan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Net Interface";
            // 
            // cmbNetInterfaces
            // 
            this.cmbNetInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetInterfaces.FormattingEnabled = true;
            this.cmbNetInterfaces.Location = new System.Drawing.Point(19, 154);
            this.cmbNetInterfaces.Name = "cmbNetInterfaces";
            this.cmbNetInterfaces.Size = new System.Drawing.Size(148, 21);
            this.cmbNetInterfaces.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkAuthor);
            this.groupBox4.Controls.Add(this.lnkGitHub);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(531, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 578);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "App Developer Info";
            // 
            // linkAuthor
            // 
            this.linkAuthor.AutoSize = true;
            this.linkAuthor.Location = new System.Drawing.Point(285, 558);
            this.linkAuthor.Name = "linkAuthor";
            this.linkAuthor.Size = new System.Drawing.Size(87, 13);
            this.linkAuthor.TabIndex = 2;
            this.linkAuthor.TabStop = true;
            this.linkAuthor.Text = "Developer Home";
            this.linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthor_LinkClicked);
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.AutoSize = true;
            this.lnkGitHub.Location = new System.Drawing.Point(203, 558);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(76, 13);
            this.lnkGitHub.TabIndex = 1;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "Project GitHub";
            this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(7, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 524);
            this.label12.TabIndex = 0;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // tbarBrightness
            // 
            this.tbarBrightness.Location = new System.Drawing.Point(29, 152);
            this.tbarBrightness.Maximum = 100;
            this.tbarBrightness.Name = "tbarBrightness";
            this.tbarBrightness.Size = new System.Drawing.Size(246, 45);
            this.tbarBrightness.TabIndex = 14;
            this.tbarBrightness.Value = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Brightness";
            // 
            // labBrightness
            // 
            this.labBrightness.AutoSize = true;
            this.labBrightness.Location = new System.Drawing.Point(246, 144);
            this.labBrightness.Name = "labBrightness";
            this.labBrightness.Size = new System.Drawing.Size(19, 13);
            this.labBrightness.TabIndex = 17;
            this.labBrightness.Text = "50";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnVerticalInvert);
            this.groupBox5.Controls.Add(this.btnVertical);
            this.groupBox5.Controls.Add(this.labBrightness);
            this.groupBox5.Controls.Add(this.btnLandscapeInvert);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbarBrightness);
            this.groupBox5.Controls.Add(this.btnLandscape);
            this.groupBox5.Controls.Add(this.btnNormal);
            this.groupBox5.Controls.Add(this.btnMirror);
            this.groupBox5.Location = new System.Drawing.Point(224, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(301, 212);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "screen operation";
            // 
            // btnVerticalInvert
            // 
            this.btnVerticalInvert.Location = new System.Drawing.Point(160, 91);
            this.btnVerticalInvert.Name = "btnVerticalInvert";
            this.btnVerticalInvert.Size = new System.Drawing.Size(115, 25);
            this.btnVerticalInvert.TabIndex = 5;
            this.btnVerticalInvert.Text = "Portrait (reverse)";
            this.btnVerticalInvert.UseVisualStyleBackColor = true;
            this.btnVerticalInvert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVerticalInvert_MouseClick);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(30, 91);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(115, 25);
            this.btnVertical.TabIndex = 4;
            this.btnVertical.Text = "Vertical screen";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVertical_MouseClick);
            // 
            // btnLandscapeInvert
            // 
            this.btnLandscapeInvert.Location = new System.Drawing.Point(160, 55);
            this.btnLandscapeInvert.Name = "btnLandscapeInvert";
            this.btnLandscapeInvert.Size = new System.Drawing.Size(115, 25);
            this.btnLandscapeInvert.TabIndex = 3;
            this.btnLandscapeInvert.Text = "Landscape (reverse)";
            this.btnLandscapeInvert.UseVisualStyleBackColor = true;
            this.btnLandscapeInvert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLandscapeInvert_MouseClick);
            // 
            // btnLandscape
            // 
            this.btnLandscape.Location = new System.Drawing.Point(29, 55);
            this.btnLandscape.Name = "btnLandscape";
            this.btnLandscape.Size = new System.Drawing.Size(115, 25);
            this.btnLandscape.TabIndex = 2;
            this.btnLandscape.Text = "Horizontal screen";
            this.btnLandscape.UseVisualStyleBackColor = true;
            this.btnLandscape.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLandscape_MouseClick);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(29, 22);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(115, 25);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Normal Image";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNormal_MouseClick);
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(160, 22);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(115, 25);
            this.btnMirror.TabIndex = 0;
            this.btnMirror.Text = "Mirror image";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMirror_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 604);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.ContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenprotectInterval)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBrightness)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cmbThemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labRenderTime;
        private System.Windows.Forms.Label labFrameCount;
        private System.Windows.Forms.CheckBox ckbAutoStart;
        private System.Windows.Forms.CheckBox ckbScreenProtect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNetInterfaces;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbCPUFans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFrameTime;
        private System.Windows.Forms.Label labWidgetCount;
        private System.Windows.Forms.Label labDevice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.TrackBar tbarBrightness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labBrightness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numScreenprotectInterval;
        private System.Windows.Forms.Label labComName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labDeviceStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnVerticalInvert;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button btnLandscapeInvert;
        private System.Windows.Forms.Button btnLandscape;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.Label labScreenWH;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.LinkLabel linkAuthor;
    }
}

