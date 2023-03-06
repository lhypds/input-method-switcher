namespace InputMethodQuickSwitcher
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnOnOff = new System.Windows.Forms.Button();
            this.LstInputMethod = new System.Windows.Forms.ListBox();
            this.LblCurrentBoundTo = new System.Windows.Forms.Label();
            this.LblCurrentKeyBindValue = new System.Windows.Forms.Label();
            this.BtnRebind = new System.Windows.Forms.Button();
            this.LblEnlgishNameValue = new System.Windows.Forms.Label();
            this.LblEnglishName = new System.Windows.Forms.Label();
            this.GrpDetails = new System.Windows.Forms.GroupBox();
            this.LblLayoutNameValue = new System.Windows.Forms.Label();
            this.LblLayoutName = new System.Windows.Forms.Label();
            this.LblNameValue = new System.Windows.Forms.Label();
            this.LblCultureName = new System.Windows.Forms.Label();
            this.LblKeyboardLayoutIdValue = new System.Windows.Forms.Label();
            this.LblKeyboardLayoutId = new System.Windows.Forms.Label();
            this.LblDisplayNameValue = new System.Windows.Forms.Label();
            this.LblDisplayName = new System.Windows.Forms.Label();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.NoiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmsTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ChkOnAtStart = new System.Windows.Forms.CheckBox();
            this.TimRefresh = new System.Windows.Forms.Timer(this.components);
            this.BtnUnbind = new System.Windows.Forms.Button();
            this.ChkStartMinimize = new System.Windows.Forms.CheckBox();
            this.GrpDetails.SuspendLayout();
            this.StsMain.SuspendLayout();
            this.CmsTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOnOff
            // 
            this.BtnOnOff.Location = new System.Drawing.Point(8, 8);
            this.BtnOnOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOnOff.Name = "BtnOnOff";
            this.BtnOnOff.Size = new System.Drawing.Size(94, 31);
            this.BtnOnOff.TabIndex = 0;
            this.BtnOnOff.Text = "ON / OFF";
            this.BtnOnOff.UseVisualStyleBackColor = true;
            this.BtnOnOff.Click += new System.EventHandler(this.BtnOnOff_Click);
            // 
            // LstInputMethod
            // 
            this.LstInputMethod.FormattingEnabled = true;
            this.LstInputMethod.Location = new System.Drawing.Point(8, 47);
            this.LstInputMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstInputMethod.Name = "LstInputMethod";
            this.LstInputMethod.Size = new System.Drawing.Size(241, 134);
            this.LstInputMethod.TabIndex = 1;
            this.LstInputMethod.SelectedIndexChanged += new System.EventHandler(this.LstInputMethod_SelectedIndexChanged);
            // 
            // LblCurrentBoundTo
            // 
            this.LblCurrentBoundTo.AutoSize = true;
            this.LblCurrentBoundTo.Location = new System.Drawing.Point(8, 185);
            this.LblCurrentBoundTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCurrentBoundTo.Name = "LblCurrentBoundTo";
            this.LblCurrentBoundTo.Size = new System.Drawing.Size(89, 13);
            this.LblCurrentBoundTo.TabIndex = 2;
            this.LblCurrentBoundTo.Text = "Current bound to:";
            // 
            // LblCurrentKeyBindValue
            // 
            this.LblCurrentKeyBindValue.AutoSize = true;
            this.LblCurrentKeyBindValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentKeyBindValue.Location = new System.Drawing.Point(97, 185);
            this.LblCurrentKeyBindValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCurrentKeyBindValue.Name = "LblCurrentKeyBindValue";
            this.LblCurrentKeyBindValue.Size = new System.Drawing.Size(30, 13);
            this.LblCurrentKeyBindValue.TabIndex = 3;
            this.LblCurrentKeyBindValue.Text = "[key]";
            this.LblCurrentKeyBindValue.Click += new System.EventHandler(this.LblCurrentBandingValue_Click);
            // 
            // BtnRebind
            // 
            this.BtnRebind.Location = new System.Drawing.Point(412, 185);
            this.BtnRebind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRebind.Name = "BtnRebind";
            this.BtnRebind.Size = new System.Drawing.Size(91, 29);
            this.BtnRebind.TabIndex = 4;
            this.BtnRebind.Text = "Rebind";
            this.BtnRebind.UseVisualStyleBackColor = true;
            this.BtnRebind.Click += new System.EventHandler(this.BtnRebind_Click);
            // 
            // LblEnlgishNameValue
            // 
            this.LblEnlgishNameValue.AutoSize = true;
            this.LblEnlgishNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnlgishNameValue.Location = new System.Drawing.Point(89, 60);
            this.LblEnlgishNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEnlgishNameValue.Name = "LblEnlgishNameValue";
            this.LblEnlgishNameValue.Size = new System.Drawing.Size(75, 13);
            this.LblEnlgishNameValue.TabIndex = 6;
            this.LblEnlgishNameValue.Text = "[english-name]";
            // 
            // LblEnglishName
            // 
            this.LblEnglishName.AutoSize = true;
            this.LblEnglishName.Location = new System.Drawing.Point(11, 60);
            this.LblEnglishName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEnglishName.Name = "LblEnglishName";
            this.LblEnglishName.Size = new System.Drawing.Size(75, 13);
            this.LblEnglishName.TabIndex = 5;
            this.LblEnglishName.Text = "English Name:";
            // 
            // GrpDetails
            // 
            this.GrpDetails.Controls.Add(this.LblLayoutNameValue);
            this.GrpDetails.Controls.Add(this.LblLayoutName);
            this.GrpDetails.Controls.Add(this.LblNameValue);
            this.GrpDetails.Controls.Add(this.LblCultureName);
            this.GrpDetails.Controls.Add(this.LblKeyboardLayoutIdValue);
            this.GrpDetails.Controls.Add(this.LblKeyboardLayoutId);
            this.GrpDetails.Controls.Add(this.LblDisplayNameValue);
            this.GrpDetails.Controls.Add(this.LblDisplayName);
            this.GrpDetails.Controls.Add(this.LblEnlgishNameValue);
            this.GrpDetails.Controls.Add(this.LblEnglishName);
            this.GrpDetails.Location = new System.Drawing.Point(257, 42);
            this.GrpDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpDetails.Name = "GrpDetails";
            this.GrpDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpDetails.Size = new System.Drawing.Size(246, 138);
            this.GrpDetails.TabIndex = 7;
            this.GrpDetails.TabStop = false;
            this.GrpDetails.Text = "Details";
            // 
            // LblLayoutNameValue
            // 
            this.LblLayoutNameValue.AutoSize = true;
            this.LblLayoutNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLayoutNameValue.Location = new System.Drawing.Point(89, 23);
            this.LblLayoutNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLayoutNameValue.Name = "LblLayoutNameValue";
            this.LblLayoutNameValue.Size = new System.Drawing.Size(70, 13);
            this.LblLayoutNameValue.TabIndex = 14;
            this.LblLayoutNameValue.Text = "[layout-name]";
            // 
            // LblLayoutName
            // 
            this.LblLayoutName.AutoSize = true;
            this.LblLayoutName.Location = new System.Drawing.Point(11, 23);
            this.LblLayoutName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLayoutName.Name = "LblLayoutName";
            this.LblLayoutName.Size = new System.Drawing.Size(73, 13);
            this.LblLayoutName.TabIndex = 13;
            this.LblLayoutName.Text = "Layout Name:";
            // 
            // LblNameValue
            // 
            this.LblNameValue.AutoSize = true;
            this.LblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameValue.Location = new System.Drawing.Point(89, 42);
            this.LblNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNameValue.Name = "LblNameValue";
            this.LblNameValue.Size = new System.Drawing.Size(74, 13);
            this.LblNameValue.TabIndex = 12;
            this.LblNameValue.Text = "[culture-name]";
            // 
            // LblCultureName
            // 
            this.LblCultureName.AutoSize = true;
            this.LblCultureName.Location = new System.Drawing.Point(11, 42);
            this.LblCultureName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCultureName.Name = "LblCultureName";
            this.LblCultureName.Size = new System.Drawing.Size(74, 13);
            this.LblCultureName.TabIndex = 11;
            this.LblCultureName.Text = "Culture Name:";
            // 
            // LblKeyboardLayoutIdValue
            // 
            this.LblKeyboardLayoutIdValue.AutoSize = true;
            this.LblKeyboardLayoutIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKeyboardLayoutIdValue.Location = new System.Drawing.Point(117, 98);
            this.LblKeyboardLayoutIdValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKeyboardLayoutIdValue.Name = "LblKeyboardLayoutIdValue";
            this.LblKeyboardLayoutIdValue.Size = new System.Drawing.Size(52, 13);
            this.LblKeyboardLayoutIdValue.TabIndex = 10;
            this.LblKeyboardLayoutIdValue.Text = "[layout-id]";
            // 
            // LblKeyboardLayoutId
            // 
            this.LblKeyboardLayoutId.AutoSize = true;
            this.LblKeyboardLayoutId.Location = new System.Drawing.Point(11, 98);
            this.LblKeyboardLayoutId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKeyboardLayoutId.Name = "LblKeyboardLayoutId";
            this.LblKeyboardLayoutId.Size = new System.Drawing.Size(104, 13);
            this.LblKeyboardLayoutId.TabIndex = 9;
            this.LblKeyboardLayoutId.Text = "Keyboard Layout ID:";
            // 
            // LblDisplayNameValue
            // 
            this.LblDisplayNameValue.AutoSize = true;
            this.LblDisplayNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplayNameValue.Location = new System.Drawing.Point(89, 79);
            this.LblDisplayNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDisplayNameValue.Name = "LblDisplayNameValue";
            this.LblDisplayNameValue.Size = new System.Drawing.Size(74, 13);
            this.LblDisplayNameValue.TabIndex = 8;
            this.LblDisplayNameValue.Text = "[display-name]";
            // 
            // LblDisplayName
            // 
            this.LblDisplayName.AutoSize = true;
            this.LblDisplayName.Location = new System.Drawing.Point(11, 79);
            this.LblDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDisplayName.Name = "LblDisplayName";
            this.LblDisplayName.Size = new System.Drawing.Size(75, 13);
            this.LblDisplayName.TabIndex = 7;
            this.LblDisplayName.Text = "Display Name:";
            // 
            // StsMain
            // 
            this.StsMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.LblStatus});
            this.StsMain.Location = new System.Drawing.Point(0, 220);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(513, 22);
            this.StsMain.TabIndex = 8;
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelStatus.Text = "Status:";
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(28, 17);
            this.LblStatus.Text = "OFF";
            // 
            // NoiMain
            // 
            this.NoiMain.ContextMenuStrip = this.CmsTrayIcon;
            this.NoiMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NoiMain.Icon")));
            this.NoiMain.Text = "Input Method Quick Switcher";
            this.NoiMain.Visible = true;
            this.NoiMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NoiMain_MouseDoubleClick);
            // 
            // CmsTrayIcon
            // 
            this.CmsTrayIcon.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CmsTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemExit});
            this.CmsTrayIcon.Name = "CmsTrayIcon";
            this.CmsTrayIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemShow.Text = "Show";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // ChkOnAtStart
            // 
            this.ChkOnAtStart.AutoSize = true;
            this.ChkOnAtStart.Location = new System.Drawing.Point(371, 13);
            this.ChkOnAtStart.Name = "ChkOnAtStart";
            this.ChkOnAtStart.Size = new System.Drawing.Size(119, 17);
            this.ChkOnAtStart.TabIndex = 9;
            this.ChkOnAtStart.Text = "Auto turn on at start";
            this.ChkOnAtStart.UseVisualStyleBackColor = true;
            this.ChkOnAtStart.CheckedChanged += new System.EventHandler(this.ChkOnAtStart_CheckedChanged);
            // 
            // TimRefresh
            // 
            this.TimRefresh.Enabled = true;
            this.TimRefresh.Tick += new System.EventHandler(this.TimRefresh_Tick);
            // 
            // BtnUnbind
            // 
            this.BtnUnbind.Location = new System.Drawing.Point(317, 185);
            this.BtnUnbind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUnbind.Name = "BtnUnbind";
            this.BtnUnbind.Size = new System.Drawing.Size(91, 29);
            this.BtnUnbind.TabIndex = 10;
            this.BtnUnbind.Text = "Unbind";
            this.BtnUnbind.UseVisualStyleBackColor = true;
            this.BtnUnbind.Click += new System.EventHandler(this.BtnUnbind_Click);
            // 
            // ChkStartMinimize
            // 
            this.ChkStartMinimize.AutoSize = true;
            this.ChkStartMinimize.Location = new System.Drawing.Point(254, 13);
            this.ChkStartMinimize.Name = "ChkStartMinimize";
            this.ChkStartMinimize.Size = new System.Drawing.Size(101, 17);
            this.ChkStartMinimize.TabIndex = 11;
            this.ChkStartMinimize.Text = "Minimize at start";
            this.ChkStartMinimize.UseVisualStyleBackColor = true;
            this.ChkStartMinimize.CheckedChanged += new System.EventHandler(this.ChkStartMinimize_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 242);
            this.Controls.Add(this.ChkStartMinimize);
            this.Controls.Add(this.BtnUnbind);
            this.Controls.Add(this.ChkOnAtStart);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.GrpDetails);
            this.Controls.Add(this.BtnRebind);
            this.Controls.Add(this.LstInputMethod);
            this.Controls.Add(this.BtnOnOff);
            this.Controls.Add(this.LblCurrentBoundTo);
            this.Controls.Add(this.LblCurrentKeyBindValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Input Method Quick Switcher 1.5.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.GrpDetails.ResumeLayout(false);
            this.GrpDetails.PerformLayout();
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.CmsTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOnOff;
        private System.Windows.Forms.ListBox LstInputMethod;
        private System.Windows.Forms.Label LblCurrentBoundTo;
        private System.Windows.Forms.Label LblCurrentKeyBindValue;
        private System.Windows.Forms.Button BtnRebind;
        private System.Windows.Forms.Label LblEnlgishNameValue;
        private System.Windows.Forms.Label LblEnglishName;
        private System.Windows.Forms.GroupBox GrpDetails;
        private System.Windows.Forms.Label LblDisplayName;
        private System.Windows.Forms.Label LblDisplayNameValue;
        private System.Windows.Forms.Label LblKeyboardLayoutIdValue;
        private System.Windows.Forms.Label LblKeyboardLayoutId;
        private System.Windows.Forms.Label LblNameValue;
        private System.Windows.Forms.Label LblCultureName;
        private System.Windows.Forms.Label LblLayoutNameValue;
        private System.Windows.Forms.Label LblLayoutName;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.NotifyIcon NoiMain;
        private System.Windows.Forms.CheckBox ChkOnAtStart;
        private System.Windows.Forms.Timer TimRefresh;
        private System.Windows.Forms.Button BtnUnbind;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.CheckBox ChkStartMinimize;
        private System.Windows.Forms.ContextMenuStrip CmsTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

