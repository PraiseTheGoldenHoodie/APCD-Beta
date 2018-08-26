namespace Application_Blocker_V0._0._0
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnConnectPort = new System.Windows.Forms.Button();
            this.btnOpenBox = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.portReadLineStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.quickTimer = new System.Windows.Forms.Timer(this.components);
            this.ruleGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.select1 = new System.Windows.Forms.RadioButton();
            this.highlight1 = new System.Windows.Forms.PictureBox();
            this.select9 = new System.Windows.Forms.RadioButton();
            this.highlight9 = new System.Windows.Forms.PictureBox();
            this.select8 = new System.Windows.Forms.RadioButton();
            this.highlight8 = new System.Windows.Forms.PictureBox();
            this.select7 = new System.Windows.Forms.RadioButton();
            this.highlight7 = new System.Windows.Forms.PictureBox();
            this.select6 = new System.Windows.Forms.RadioButton();
            this.highlight6 = new System.Windows.Forms.PictureBox();
            this.select2 = new System.Windows.Forms.RadioButton();
            this.highlight2 = new System.Windows.Forms.PictureBox();
            this.select3 = new System.Windows.Forms.RadioButton();
            this.highlight3 = new System.Windows.Forms.PictureBox();
            this.select4 = new System.Windows.Forms.RadioButton();
            this.highlight4 = new System.Windows.Forms.PictureBox();
            this.select5 = new System.Windows.Forms.RadioButton();
            this.highlight5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemoveOldRules = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untilOtherAppBlockedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageTimeLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnDevToo = new System.Windows.Forms.Button();
            this.RuleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compartments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectPort
            // 
            this.btnConnectPort.Location = new System.Drawing.Point(12, 56);
            this.btnConnectPort.Name = "btnConnectPort";
            this.btnConnectPort.Size = new System.Drawing.Size(233, 23);
            this.btnConnectPort.TabIndex = 0;
            this.btnConnectPort.Text = "Connect Box";
            this.btnConnectPort.UseVisualStyleBackColor = true;
            this.btnConnectPort.Click += new System.EventHandler(this.BtnConnectPort_Click);
            // 
            // btnOpenBox
            // 
            this.btnOpenBox.Location = new System.Drawing.Point(12, 27);
            this.btnOpenBox.Name = "btnOpenBox";
            this.btnOpenBox.Size = new System.Drawing.Size(233, 23);
            this.btnOpenBox.TabIndex = 1;
            this.btnOpenBox.UseVisualStyleBackColor = true;
            this.btnOpenBox.Visible = false;
            this.btnOpenBox.Click += new System.EventHandler(this.btnOldOpenBox_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portReadLineStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // portReadLineStatusLabel
            // 
            this.portReadLineStatusLabel.Name = "portReadLineStatusLabel";
            this.portReadLineStatusLabel.Size = new System.Drawing.Size(138, 17);
            this.portReadLineStatusLabel.Text = "Waiting for connection...";
            // 
            // quickTimer
            // 
            this.quickTimer.Enabled = true;
            this.quickTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ruleGridView
            // 
            this.ruleGridView.AllowUserToAddRows = false;
            this.ruleGridView.AllowUserToDeleteRows = false;
            this.ruleGridView.AllowUserToOrderColumns = true;
            this.ruleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuleType,
            this.IsActive,
            this.Compartments,
            this.Apps,
            this.Description});
            this.ruleGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ruleGridView.Location = new System.Drawing.Point(315, 30);
            this.ruleGridView.Name = "ruleGridView";
            this.ruleGridView.ReadOnly = true;
            this.ruleGridView.RowTemplate.ReadOnly = true;
            this.ruleGridView.Size = new System.Drawing.Size(536, 318);
            this.ruleGridView.TabIndex = 6;
            this.ruleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(191, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpen.Location = new System.Drawing.Point(24, 137);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 46;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // select1
            // 
            this.select1.AutoSize = true;
            this.select1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select1.Location = new System.Drawing.Point(213, 262);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(31, 17);
            this.select1.TabIndex = 45;
            this.select1.TabStop = true;
            this.select1.Text = "1";
            this.select1.UseVisualStyleBackColor = true;
            this.select1.Click += new System.EventHandler(this.select1_Click);
            // 
            // highlight1
            // 
            this.highlight1.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight1.Location = new System.Drawing.Point(191, 180);
            this.highlight1.Name = "highlight1";
            this.highlight1.Size = new System.Drawing.Size(79, 150);
            this.highlight1.TabIndex = 44;
            this.highlight1.TabStop = false;
            this.highlight1.Click += new System.EventHandler(this.highlight1_Click);
            // 
            // select9
            // 
            this.select9.AutoSize = true;
            this.select9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select9.Location = new System.Drawing.Point(152, 303);
            this.select9.Name = "select9";
            this.select9.Size = new System.Drawing.Size(31, 17);
            this.select9.TabIndex = 43;
            this.select9.TabStop = true;
            this.select9.Text = "9";
            this.select9.UseVisualStyleBackColor = true;
            this.select9.Click += new System.EventHandler(this.select9_Click);
            // 
            // highlight9
            // 
            this.highlight9.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight9.Location = new System.Drawing.Point(149, 293);
            this.highlight9.Name = "highlight9";
            this.highlight9.Size = new System.Drawing.Size(36, 37);
            this.highlight9.TabIndex = 42;
            this.highlight9.TabStop = false;
            this.highlight9.Click += new System.EventHandler(this.highlight9_Click);
            // 
            // select8
            // 
            this.select8.AutoSize = true;
            this.select8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select8.Location = new System.Drawing.Point(108, 303);
            this.select8.Name = "select8";
            this.select8.Size = new System.Drawing.Size(31, 17);
            this.select8.TabIndex = 41;
            this.select8.TabStop = true;
            this.select8.Text = "8";
            this.select8.UseVisualStyleBackColor = true;
            this.select8.Click += new System.EventHandler(this.select8_Click);
            // 
            // highlight8
            // 
            this.highlight8.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight8.Location = new System.Drawing.Point(106, 293);
            this.highlight8.Name = "highlight8";
            this.highlight8.Size = new System.Drawing.Size(36, 37);
            this.highlight8.TabIndex = 40;
            this.highlight8.TabStop = false;
            this.highlight8.Click += new System.EventHandler(this.highlight8_Click);
            // 
            // select7
            // 
            this.select7.AutoSize = true;
            this.select7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select7.Location = new System.Drawing.Point(66, 303);
            this.select7.Name = "select7";
            this.select7.Size = new System.Drawing.Size(31, 17);
            this.select7.TabIndex = 39;
            this.select7.TabStop = true;
            this.select7.Text = "7";
            this.select7.UseVisualStyleBackColor = true;
            this.select7.Click += new System.EventHandler(this.select7_Click);
            // 
            // highlight7
            // 
            this.highlight7.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight7.Location = new System.Drawing.Point(63, 293);
            this.highlight7.Name = "highlight7";
            this.highlight7.Size = new System.Drawing.Size(36, 37);
            this.highlight7.TabIndex = 38;
            this.highlight7.TabStop = false;
            this.highlight7.Click += new System.EventHandler(this.highlight7_Click);
            // 
            // select6
            // 
            this.select6.AutoSize = true;
            this.select6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select6.Location = new System.Drawing.Point(24, 303);
            this.select6.Name = "select6";
            this.select6.Size = new System.Drawing.Size(31, 17);
            this.select6.TabIndex = 37;
            this.select6.TabStop = true;
            this.select6.Text = "6";
            this.select6.UseVisualStyleBackColor = true;
            this.select6.Click += new System.EventHandler(this.select6_Click);
            // 
            // highlight6
            // 
            this.highlight6.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight6.Location = new System.Drawing.Point(21, 293);
            this.highlight6.Name = "highlight6";
            this.highlight6.Size = new System.Drawing.Size(36, 37);
            this.highlight6.TabIndex = 36;
            this.highlight6.TabStop = false;
            this.highlight6.Click += new System.EventHandler(this.highlight6_Click);
            // 
            // select2
            // 
            this.select2.AutoSize = true;
            this.select2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select2.Location = new System.Drawing.Point(150, 208);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(31, 17);
            this.select2.TabIndex = 35;
            this.select2.TabStop = true;
            this.select2.Text = "2";
            this.select2.UseVisualStyleBackColor = true;
            this.select2.Click += new System.EventHandler(this.select2_Click);
            // 
            // highlight2
            // 
            this.highlight2.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight2.Location = new System.Drawing.Point(148, 180);
            this.highlight2.Name = "highlight2";
            this.highlight2.Size = new System.Drawing.Size(36, 70);
            this.highlight2.TabIndex = 34;
            this.highlight2.TabStop = false;
            this.highlight2.Click += new System.EventHandler(this.highlight2_Click);
            // 
            // select3
            // 
            this.select3.AutoSize = true;
            this.select3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select3.Location = new System.Drawing.Point(108, 208);
            this.select3.Name = "select3";
            this.select3.Size = new System.Drawing.Size(31, 17);
            this.select3.TabIndex = 33;
            this.select3.TabStop = true;
            this.select3.Text = "3";
            this.select3.UseVisualStyleBackColor = true;
            this.select3.Click += new System.EventHandler(this.select3_Click);
            // 
            // highlight3
            // 
            this.highlight3.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight3.Location = new System.Drawing.Point(106, 180);
            this.highlight3.Name = "highlight3";
            this.highlight3.Size = new System.Drawing.Size(36, 70);
            this.highlight3.TabIndex = 32;
            this.highlight3.TabStop = false;
            this.highlight3.Click += new System.EventHandler(this.highlight3_Click);
            // 
            // select4
            // 
            this.select4.AutoSize = true;
            this.select4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select4.Location = new System.Drawing.Point(66, 208);
            this.select4.Name = "select4";
            this.select4.Size = new System.Drawing.Size(31, 17);
            this.select4.TabIndex = 31;
            this.select4.TabStop = true;
            this.select4.Text = "4";
            this.select4.UseVisualStyleBackColor = true;
            this.select4.Click += new System.EventHandler(this.select4_Click);
            // 
            // highlight4
            // 
            this.highlight4.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight4.Location = new System.Drawing.Point(63, 180);
            this.highlight4.Name = "highlight4";
            this.highlight4.Size = new System.Drawing.Size(36, 70);
            this.highlight4.TabIndex = 30;
            this.highlight4.TabStop = false;
            this.highlight4.Click += new System.EventHandler(this.highlight4_Click);
            // 
            // select5
            // 
            this.select5.AutoSize = true;
            this.select5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select5.Location = new System.Drawing.Point(24, 208);
            this.select5.Name = "select5";
            this.select5.Size = new System.Drawing.Size(31, 17);
            this.select5.TabIndex = 29;
            this.select5.TabStop = true;
            this.select5.Text = "5";
            this.select5.UseVisualStyleBackColor = true;
            this.select5.Click += new System.EventHandler(this.select5_Click);
            // 
            // highlight5
            // 
            this.highlight5.BackColor = System.Drawing.SystemColors.Menu;
            this.highlight5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.highlight5.Location = new System.Drawing.Point(21, 180);
            this.highlight5.MaximumSize = new System.Drawing.Size(36, 70);
            this.highlight5.MinimumSize = new System.Drawing.Size(36, 70);
            this.highlight5.Name = "highlight5";
            this.highlight5.Size = new System.Drawing.Size(36, 70);
            this.highlight5.TabIndex = 28;
            this.highlight5.TabStop = false;
            this.highlight5.Click += new System.EventHandler(this.highlight5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Application_Blocker_V0._0._0.Properties.Resources.box_layout_BigBlurry;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(4, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 185);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(325, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(249, 23);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemoveOldRules
            // 
            this.btnRemoveOldRules.Location = new System.Drawing.Point(592, 3);
            this.btnRemoveOldRules.Name = "btnRemoveOldRules";
            this.btnRemoveOldRules.Size = new System.Drawing.Size(249, 23);
            this.btnRemoveOldRules.TabIndex = 49;
            this.btnRemoveOldRules.Text = "Remove Past Rules";
            this.btnRemoveOldRules.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem,
            this.untilOtherAppBlockedToolStripMenuItem,
            this.usageTimeLimitToolStripMenuItem});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newToolStripMenuItem.Text = "&New Rule";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.timeToolStripMenuItem.Text = "&1. Time Interval";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeIntervalToolStripMenuItem_Click);
            // 
            // untilOtherAppBlockedToolStripMenuItem
            // 
            this.untilOtherAppBlockedToolStripMenuItem.Name = "untilOtherAppBlockedToolStripMenuItem";
            this.untilOtherAppBlockedToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.untilOtherAppBlockedToolStripMenuItem.Text = "&2. Until Apps Blocked";
            this.untilOtherAppBlockedToolStripMenuItem.Click += new System.EventHandler(this.untilOtherAppBlockedToolStripMenuItem_Click);
            // 
            // usageTimeLimitToolStripMenuItem
            // 
            this.usageTimeLimitToolStripMenuItem.Name = "usageTimeLimitToolStripMenuItem";
            this.usageTimeLimitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.usageTimeLimitToolStripMenuItem.Text = "&3. Usage Time Limit";
            this.usageTimeLimitToolStripMenuItem.Click += new System.EventHandler(this.usageTimeLimitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDev
            // 
            this.btnDev.Location = new System.Drawing.Point(13, 86);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(75, 23);
            this.btnDev.TabIndex = 50;
            this.btnDev.Text = "Tester";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // btnDevToo
            // 
            this.btnDevToo.Location = new System.Drawing.Point(106, 86);
            this.btnDevToo.Name = "btnDevToo";
            this.btnDevToo.Size = new System.Drawing.Size(138, 23);
            this.btnDevToo.TabIndex = 51;
            this.btnDevToo.Text = "Another Test";
            this.btnDevToo.UseVisualStyleBackColor = true;
            this.btnDevToo.Click += new System.EventHandler(this.btnDevToo_Click);
            // 
            // RuleType
            // 
            this.RuleType.HeaderText = "Rule Type";
            this.RuleType.Name = "RuleType";
            this.RuleType.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // Compartments
            // 
            this.Compartments.HeaderText = "Compartments";
            this.Compartments.Name = "Compartments";
            this.Compartments.ReadOnly = true;
            // 
            // Apps
            // 
            this.Apps.HeaderText = "Apps Blocked";
            this.Apps.Name = "Apps";
            this.Apps.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Rule Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 380);
            this.Controls.Add(this.btnDevToo);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnRemoveOldRules);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.highlight1);
            this.Controls.Add(this.select9);
            this.Controls.Add(this.highlight9);
            this.Controls.Add(this.select8);
            this.Controls.Add(this.highlight8);
            this.Controls.Add(this.select7);
            this.Controls.Add(this.highlight7);
            this.Controls.Add(this.select6);
            this.Controls.Add(this.highlight6);
            this.Controls.Add(this.select2);
            this.Controls.Add(this.highlight2);
            this.Controls.Add(this.select3);
            this.Controls.Add(this.highlight3);
            this.Controls.Add(this.select4);
            this.Controls.Add(this.highlight4);
            this.Controls.Add(this.select5);
            this.Controls.Add(this.highlight5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ruleGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOpenBox);
            this.Controls.Add(this.btnConnectPort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Anti-Procrastination Commitment Device";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_Closed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlight5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectPort;
        private System.Windows.Forms.Button btnOpenBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel portReadLineStatusLabel;
        private System.Windows.Forms.Timer quickTimer;
        private System.Windows.Forms.DataGridView ruleGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RadioButton select1;
        private System.Windows.Forms.PictureBox highlight1;
        private System.Windows.Forms.RadioButton select9;
        private System.Windows.Forms.PictureBox highlight9;
        private System.Windows.Forms.RadioButton select8;
        private System.Windows.Forms.PictureBox highlight8;
        private System.Windows.Forms.RadioButton select7;
        private System.Windows.Forms.PictureBox highlight7;
        private System.Windows.Forms.RadioButton select6;
        private System.Windows.Forms.PictureBox highlight6;
        private System.Windows.Forms.RadioButton select2;
        private System.Windows.Forms.PictureBox highlight2;
        private System.Windows.Forms.RadioButton select3;
        private System.Windows.Forms.PictureBox highlight3;
        private System.Windows.Forms.RadioButton select4;
        private System.Windows.Forms.PictureBox highlight4;
        private System.Windows.Forms.RadioButton select5;
        private System.Windows.Forms.PictureBox highlight5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveOldRules;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untilOtherAppBlockedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageTimeLimitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnDevToo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}