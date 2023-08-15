
namespace ShutdownSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InitiateSystemShutdownEx_Button = new System.Windows.Forms.Button();
            this.ExitWindowsEx_Button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SetSystemPowerState_Button = new System.Windows.Forms.Button();
            this.NtSetSystemPowerState_Button = new System.Windows.Forms.Button();
            this.WarningIcon1 = new System.Windows.Forms.PictureBox();
            this.NtShutdownSystem_Button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WarningIcon2 = new System.Windows.Forms.PictureBox();
            this.NtSetInformationProcess = new System.Windows.Forms.CheckBox();
            this.NtStatus = new System.Windows.Forms.ComboBox();
            this.NtRaiseHardError = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitWindowsEx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitWindowsEx_Off = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitWindowsEx_Sh = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitWindowsEx_Re = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitWindowsEx_Lo = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitWindowsEx_Ra = new System.Windows.Forms.ToolStripMenuItem();
            this.NtShutdownSystem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NtShutdownSystem_H = new System.Windows.Forms.ToolStripMenuItem();
            this.NtShutdownSystem_R = new System.Windows.Forms.ToolStripMenuItem();
            this.NtShutdownSystem_P = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSystemPowerState = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetSystemPowerState_Y = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSystemPowerState_N = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSystemPowerState_S = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSystemPowerState_R = new System.Windows.Forms.ToolStripMenuItem();
            this.NtSetSystemPowerState = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NtSetSystemPowerState_H = new System.Windows.Forms.ToolStripMenuItem();
            this.NtSetSystemPowerState_R = new System.Windows.Forms.ToolStripMenuItem();
            this.NtSetSystemPowerState_P = new System.Windows.Forms.ToolStripMenuItem();
            this.WarningToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InitiateSystemShutdownEx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InitiateSystemShutdownEx_N = new System.Windows.Forms.ToolStripMenuItem();
            this.InitiateSystemShutdownEx_NF = new System.Windows.Forms.ToolStripMenuItem();
            this.InitiateSystemShutdownEx_R = new System.Windows.Forms.ToolStripMenuItem();
            this.InitiateSystemShutdownEx_RF = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon2)).BeginInit();
            this.ExitWindowsEx.SuspendLayout();
            this.NtShutdownSystem.SuspendLayout();
            this.SetSystemPowerState.SuspendLayout();
            this.NtSetSystemPowerState.SuspendLayout();
            this.InitiateSystemShutdownEx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InitiateSystemShutdownEx_Button);
            this.tabPage1.Controls.Add(this.ExitWindowsEx_Button);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Safe shutdown";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InitiateSystemShutdownEx_Button
            // 
            this.InitiateSystemShutdownEx_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InitiateSystemShutdownEx_Button.Location = new System.Drawing.Point(44, 162);
            this.InitiateSystemShutdownEx_Button.Name = "InitiateSystemShutdownEx_Button";
            this.InitiateSystemShutdownEx_Button.Size = new System.Drawing.Size(361, 31);
            this.InitiateSystemShutdownEx_Button.TabIndex = 1;
            this.InitiateSystemShutdownEx_Button.Text = "InitiateSystemShutdownEx()";
            this.InitiateSystemShutdownEx_Button.UseVisualStyleBackColor = true;
            this.InitiateSystemShutdownEx_Button.Click += new System.EventHandler(this.InitiateSystemShutdownEx_Button_Click);
            // 
            // ExitWindowsEx_Button
            // 
            this.ExitWindowsEx_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitWindowsEx_Button.Location = new System.Drawing.Point(44, 125);
            this.ExitWindowsEx_Button.Name = "ExitWindowsEx_Button";
            this.ExitWindowsEx_Button.Size = new System.Drawing.Size(361, 31);
            this.ExitWindowsEx_Button.TabIndex = 0;
            this.ExitWindowsEx_Button.Text = "ExitWindowsEx()";
            this.ExitWindowsEx_Button.UseVisualStyleBackColor = true;
            this.ExitWindowsEx_Button.Click += new System.EventHandler(this.ExitWindowsEx_Button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.NtSetSystemPowerState_Button);
            this.tabPage2.Controls.Add(this.WarningIcon1);
            this.tabPage2.Controls.Add(this.NtShutdownSystem_Button);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hard shutdown";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SetSystemPowerState_Button);
            this.groupBox1.Location = new System.Drawing.Point(44, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".NET Compact Framework";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7F);
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "For smart devices only, will not work on desktop Windows.";
            // 
            // SetSystemPowerState_Button
            // 
            this.SetSystemPowerState_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SetSystemPowerState_Button.Location = new System.Drawing.Point(6, 19);
            this.SetSystemPowerState_Button.Name = "SetSystemPowerState_Button";
            this.SetSystemPowerState_Button.Size = new System.Drawing.Size(349, 26);
            this.SetSystemPowerState_Button.TabIndex = 3;
            this.SetSystemPowerState_Button.Text = "SetSystemPowerState()";
            this.SetSystemPowerState_Button.UseVisualStyleBackColor = true;
            this.SetSystemPowerState_Button.Click += new System.EventHandler(this.SetSystemPowerState_Button_Click);
            // 
            // NtSetSystemPowerState_Button
            // 
            this.NtSetSystemPowerState_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NtSetSystemPowerState_Button.Location = new System.Drawing.Point(44, 130);
            this.NtSetSystemPowerState_Button.Name = "NtSetSystemPowerState_Button";
            this.NtSetSystemPowerState_Button.Size = new System.Drawing.Size(361, 31);
            this.NtSetSystemPowerState_Button.TabIndex = 4;
            this.NtSetSystemPowerState_Button.Text = "NtSetSystemPowerState()";
            this.NtSetSystemPowerState_Button.UseVisualStyleBackColor = true;
            this.NtSetSystemPowerState_Button.Click += new System.EventHandler(this.NtSetSystemPowerState_Button_Click);
            // 
            // WarningIcon1
            // 
            this.WarningIcon1.Image = ((System.Drawing.Image)(resources.GetObject("WarningIcon1.Image")));
            this.WarningIcon1.Location = new System.Drawing.Point(410, 280);
            this.WarningIcon1.Name = "WarningIcon1";
            this.WarningIcon1.Size = new System.Drawing.Size(32, 32);
            this.WarningIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIcon1.TabIndex = 2;
            this.WarningIcon1.TabStop = false;
            // 
            // NtShutdownSystem_Button
            // 
            this.NtShutdownSystem_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NtShutdownSystem_Button.Location = new System.Drawing.Point(44, 93);
            this.NtShutdownSystem_Button.Name = "NtShutdownSystem_Button";
            this.NtShutdownSystem_Button.Size = new System.Drawing.Size(361, 31);
            this.NtShutdownSystem_Button.TabIndex = 1;
            this.NtShutdownSystem_Button.Text = "NtShutdownSystem()";
            this.NtShutdownSystem_Button.UseVisualStyleBackColor = true;
            this.NtShutdownSystem_Button.Click += new System.EventHandler(this.NtShutdownSystem_Button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.WarningIcon2);
            this.tabPage3.Controls.Add(this.NtSetInformationProcess);
            this.tabPage3.Controls.Add(this.NtStatus);
            this.tabPage3.Controls.Add(this.NtRaiseHardError);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(448, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BSOD";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(310, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Normal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(224, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 247);
            this.panel2.TabIndex = 4;
            // 
            // WarningIcon2
            // 
            this.WarningIcon2.Image = ((System.Drawing.Image)(resources.GetObject("WarningIcon2.Image")));
            this.WarningIcon2.Location = new System.Drawing.Point(410, 280);
            this.WarningIcon2.Name = "WarningIcon2";
            this.WarningIcon2.Size = new System.Drawing.Size(32, 32);
            this.WarningIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIcon2.TabIndex = 3;
            this.WarningIcon2.TabStop = false;
            // 
            // NtSetInformationProcess
            // 
            this.NtSetInformationProcess.Appearance = System.Windows.Forms.Appearance.Button;
            this.NtSetInformationProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NtSetInformationProcess.Location = new System.Drawing.Point(240, 129);
            this.NtSetInformationProcess.Name = "NtSetInformationProcess";
            this.NtSetInformationProcess.Size = new System.Drawing.Size(192, 29);
            this.NtSetInformationProcess.TabIndex = 0;
            this.NtSetInformationProcess.Text = "NtSetInformationProcess()";
            this.NtSetInformationProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NtSetInformationProcess.UseVisualStyleBackColor = true;
            this.NtSetInformationProcess.CheckedChanged += new System.EventHandler(this.NtSetInformationProcess_CheckedChanged);
            // 
            // NtStatus
            // 
            this.NtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NtStatus.FormattingEnabled = true;
            this.NtStatus.Location = new System.Drawing.Point(16, 164);
            this.NtStatus.Name = "NtStatus";
            this.NtStatus.Size = new System.Drawing.Size(192, 23);
            this.NtStatus.TabIndex = 2;
            this.NtStatus.SelectedIndexChanged += new System.EventHandler(this.NtStatus_SelectedIndexChanged);
            // 
            // NtRaiseHardError
            // 
            this.NtRaiseHardError.Enabled = false;
            this.NtRaiseHardError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NtRaiseHardError.Location = new System.Drawing.Point(16, 129);
            this.NtRaiseHardError.Name = "NtRaiseHardError";
            this.NtRaiseHardError.Size = new System.Drawing.Size(192, 29);
            this.NtRaiseHardError.TabIndex = 1;
            this.NtRaiseHardError.Text = "NtRaiseHardError()";
            this.NtRaiseHardError.UseVisualStyleBackColor = true;
            this.NtRaiseHardError.Click += new System.EventHandler(this.NtRaiseHardError_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 7F);
            this.label1.Location = new System.Drawing.Point(240, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 10);
            this.panel1.TabIndex = 1;
            // 
            // ExitWindowsEx
            // 
            this.ExitWindowsEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitWindowsEx_Off,
            this.ExitWindowsEx_Sh,
            this.ExitWindowsEx_Re,
            this.ExitWindowsEx_Lo,
            this.ExitWindowsEx_Ra});
            this.ExitWindowsEx.Name = "ExitWindowsEx";
            this.ExitWindowsEx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ExitWindowsEx.Size = new System.Drawing.Size(141, 114);
            // 
            // ExitWindowsEx_Off
            // 
            this.ExitWindowsEx_Off.Name = "ExitWindowsEx_Off";
            this.ExitWindowsEx_Off.Size = new System.Drawing.Size(140, 22);
            this.ExitWindowsEx_Off.Text = "Power Off";
            this.ExitWindowsEx_Off.Click += new System.EventHandler(this.ExitWindowsEx_Off_Click);
            // 
            // ExitWindowsEx_Sh
            // 
            this.ExitWindowsEx_Sh.Name = "ExitWindowsEx_Sh";
            this.ExitWindowsEx_Sh.Size = new System.Drawing.Size(140, 22);
            this.ExitWindowsEx_Sh.Text = "Shutdown";
            this.ExitWindowsEx_Sh.Click += new System.EventHandler(this.ExitWindowsEx_Sh_Click);
            // 
            // ExitWindowsEx_Re
            // 
            this.ExitWindowsEx_Re.Name = "ExitWindowsEx_Re";
            this.ExitWindowsEx_Re.Size = new System.Drawing.Size(140, 22);
            this.ExitWindowsEx_Re.Text = "Restart";
            this.ExitWindowsEx_Re.Click += new System.EventHandler(this.ExitWindowsEx_Re_Click);
            // 
            // ExitWindowsEx_Lo
            // 
            this.ExitWindowsEx_Lo.Name = "ExitWindowsEx_Lo";
            this.ExitWindowsEx_Lo.Size = new System.Drawing.Size(140, 22);
            this.ExitWindowsEx_Lo.Text = "Log Off";
            this.ExitWindowsEx_Lo.Click += new System.EventHandler(this.ExitWindowsEx_Lo_Click);
            // 
            // ExitWindowsEx_Ra
            // 
            this.ExitWindowsEx_Ra.Name = "ExitWindowsEx_Ra";
            this.ExitWindowsEx_Ra.Size = new System.Drawing.Size(140, 22);
            this.ExitWindowsEx_Ra.Text = "Restart Apps";
            this.ExitWindowsEx_Ra.Click += new System.EventHandler(this.ExitWindowsEx_Ra_Click);
            // 
            // NtShutdownSystem
            // 
            this.NtShutdownSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NtShutdownSystem_H,
            this.NtShutdownSystem_R,
            this.NtShutdownSystem_P});
            this.NtShutdownSystem.Name = "ExitWindowsEx";
            this.NtShutdownSystem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.NtShutdownSystem.Size = new System.Drawing.Size(128, 70);
            // 
            // NtShutdownSystem_H
            // 
            this.NtShutdownSystem_H.Name = "NtShutdownSystem_H";
            this.NtShutdownSystem_H.Size = new System.Drawing.Size(127, 22);
            this.NtShutdownSystem_H.Text = "Halt";
            this.NtShutdownSystem_H.Click += new System.EventHandler(this.NtShutdownSystem_H_Click);
            // 
            // NtShutdownSystem_R
            // 
            this.NtShutdownSystem_R.Name = "NtShutdownSystem_R";
            this.NtShutdownSystem_R.Size = new System.Drawing.Size(127, 22);
            this.NtShutdownSystem_R.Text = "Reboot";
            this.NtShutdownSystem_R.Click += new System.EventHandler(this.NtShutdownSystem_R_Click);
            // 
            // NtShutdownSystem_P
            // 
            this.NtShutdownSystem_P.Name = "NtShutdownSystem_P";
            this.NtShutdownSystem_P.Size = new System.Drawing.Size(127, 22);
            this.NtShutdownSystem_P.Text = "Power Off";
            this.NtShutdownSystem_P.Click += new System.EventHandler(this.NtShutdownSystem_P_Click);
            // 
            // SetSystemPowerState
            // 
            this.SetSystemPowerState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetSystemPowerState_Y,
            this.SetSystemPowerState_N,
            this.SetSystemPowerState_S,
            this.SetSystemPowerState_R});
            this.SetSystemPowerState.Name = "ExitWindowsEx";
            this.SetSystemPowerState.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SetSystemPowerState.Size = new System.Drawing.Size(120, 92);
            // 
            // SetSystemPowerState_Y
            // 
            this.SetSystemPowerState_Y.Name = "SetSystemPowerState_Y";
            this.SetSystemPowerState_Y.Size = new System.Drawing.Size(119, 22);
            this.SetSystemPowerState_Y.Text = "On";
            this.SetSystemPowerState_Y.Click += new System.EventHandler(this.SetSystemPowerState_Y_Click);
            // 
            // SetSystemPowerState_N
            // 
            this.SetSystemPowerState_N.Name = "SetSystemPowerState_N";
            this.SetSystemPowerState_N.Size = new System.Drawing.Size(119, 22);
            this.SetSystemPowerState_N.Text = "Off";
            this.SetSystemPowerState_N.Click += new System.EventHandler(this.SetSystemPowerState_N_Click);
            // 
            // SetSystemPowerState_S
            // 
            this.SetSystemPowerState_S.Name = "SetSystemPowerState_S";
            this.SetSystemPowerState_S.Size = new System.Drawing.Size(119, 22);
            this.SetSystemPowerState_S.Text = "Suspend";
            this.SetSystemPowerState_S.Click += new System.EventHandler(this.SetSystemPowerState_S_Click);
            // 
            // SetSystemPowerState_R
            // 
            this.SetSystemPowerState_R.Name = "SetSystemPowerState_R";
            this.SetSystemPowerState_R.Size = new System.Drawing.Size(119, 22);
            this.SetSystemPowerState_R.Text = "Reset";
            this.SetSystemPowerState_R.Click += new System.EventHandler(this.SetSystemPowerState_R_Click);
            // 
            // NtSetSystemPowerState
            // 
            this.NtSetSystemPowerState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NtSetSystemPowerState_H,
            this.NtSetSystemPowerState_R,
            this.NtSetSystemPowerState_P});
            this.NtSetSystemPowerState.Name = "ExitWindowsEx";
            this.NtSetSystemPowerState.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.NtSetSystemPowerState.Size = new System.Drawing.Size(128, 70);
            // 
            // NtSetSystemPowerState_H
            // 
            this.NtSetSystemPowerState_H.Name = "NtSetSystemPowerState_H";
            this.NtSetSystemPowerState_H.Size = new System.Drawing.Size(127, 22);
            this.NtSetSystemPowerState_H.Text = "Halt";
            // 
            // NtSetSystemPowerState_R
            // 
            this.NtSetSystemPowerState_R.Name = "NtSetSystemPowerState_R";
            this.NtSetSystemPowerState_R.Size = new System.Drawing.Size(127, 22);
            this.NtSetSystemPowerState_R.Text = "Reboot";
            // 
            // NtSetSystemPowerState_P
            // 
            this.NtSetSystemPowerState_P.Name = "NtSetSystemPowerState_P";
            this.NtSetSystemPowerState_P.Size = new System.Drawing.Size(127, 22);
            this.NtSetSystemPowerState_P.Text = "Power Off";
            // 
            // WarningToolTip
            // 
            this.WarningToolTip.IsBalloon = true;
            this.WarningToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.WarningToolTip.ToolTipTitle = "Warning";
            // 
            // InitiateSystemShutdownEx
            // 
            this.InitiateSystemShutdownEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InitiateSystemShutdownEx_N,
            this.InitiateSystemShutdownEx_NF,
            this.InitiateSystemShutdownEx_R,
            this.InitiateSystemShutdownEx_RF});
            this.InitiateSystemShutdownEx.Name = "ExitWindowsEx";
            this.InitiateSystemShutdownEx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.InitiateSystemShutdownEx.Size = new System.Drawing.Size(203, 92);
            // 
            // InitiateSystemShutdownEx_N
            // 
            this.InitiateSystemShutdownEx_N.Name = "InitiateSystemShutdownEx_N";
            this.InitiateSystemShutdownEx_N.Size = new System.Drawing.Size(202, 22);
            this.InitiateSystemShutdownEx_N.Text = "Normal";
            this.InitiateSystemShutdownEx_N.Click += new System.EventHandler(this.InitiateSystemShutdownEx_N_Click);
            // 
            // InitiateSystemShutdownEx_NF
            // 
            this.InitiateSystemShutdownEx_NF.Name = "InitiateSystemShutdownEx_NF";
            this.InitiateSystemShutdownEx_NF.Size = new System.Drawing.Size(202, 22);
            this.InitiateSystemShutdownEx_NF.Text = "Normal (force exit apps)";
            this.InitiateSystemShutdownEx_NF.Click += new System.EventHandler(this.InitiateSystemShutdownEx_NF_Click);
            // 
            // InitiateSystemShutdownEx_R
            // 
            this.InitiateSystemShutdownEx_R.Name = "InitiateSystemShutdownEx_R";
            this.InitiateSystemShutdownEx_R.Size = new System.Drawing.Size(202, 22);
            this.InitiateSystemShutdownEx_R.Text = "Restart";
            this.InitiateSystemShutdownEx_R.Click += new System.EventHandler(this.InitiateSystemShutdownEx_R_Click);
            // 
            // InitiateSystemShutdownEx_RF
            // 
            this.InitiateSystemShutdownEx_RF.Name = "InitiateSystemShutdownEx_RF";
            this.InitiateSystemShutdownEx_RF.Size = new System.Drawing.Size(202, 22);
            this.InitiateSystemShutdownEx_RF.Text = "Restart (force exit apps)";
            this.InitiateSystemShutdownEx_RF.Click += new System.EventHandler(this.InitiateSystemShutdownEx_RF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(470, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ShutdownSystem";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon2)).EndInit();
            this.ExitWindowsEx.ResumeLayout(false);
            this.NtShutdownSystem.ResumeLayout(false);
            this.SetSystemPowerState.ResumeLayout(false);
            this.NtSetSystemPowerState.ResumeLayout(false);
            this.InitiateSystemShutdownEx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitWindowsEx_Button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip ExitWindowsEx;
        private System.Windows.Forms.ToolStripMenuItem ExitWindowsEx_Sh;
        private System.Windows.Forms.ToolStripMenuItem ExitWindowsEx_Off;
        private System.Windows.Forms.ToolStripMenuItem ExitWindowsEx_Re;
        private System.Windows.Forms.ToolStripMenuItem ExitWindowsEx_Lo;
        private System.Windows.Forms.ToolStripMenuItem ExitWindowsEx_Ra;
        private System.Windows.Forms.Button NtShutdownSystem_Button;
        private System.Windows.Forms.ContextMenuStrip NtShutdownSystem;
        private System.Windows.Forms.ToolStripMenuItem NtShutdownSystem_H;
        private System.Windows.Forms.ToolStripMenuItem NtShutdownSystem_R;
        private System.Windows.Forms.ToolStripMenuItem NtShutdownSystem_P;
        private System.Windows.Forms.Button NtRaiseHardError;
        private System.Windows.Forms.ComboBox NtStatus;
        private System.Windows.Forms.CheckBox NtSetInformationProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox WarningIcon1;
        private System.Windows.Forms.Button SetSystemPowerState_Button;
        private System.Windows.Forms.ContextMenuStrip SetSystemPowerState;
        private System.Windows.Forms.ToolStripMenuItem SetSystemPowerState_Y;
        private System.Windows.Forms.ToolStripMenuItem SetSystemPowerState_N;
        private System.Windows.Forms.ToolStripMenuItem SetSystemPowerState_S;
        private System.Windows.Forms.ToolStripMenuItem SetSystemPowerState_R;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox WarningIcon2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NtSetSystemPowerState_Button;
        private System.Windows.Forms.ContextMenuStrip NtSetSystemPowerState;
        private System.Windows.Forms.ToolStripMenuItem NtSetSystemPowerState_H;
        private System.Windows.Forms.ToolStripMenuItem NtSetSystemPowerState_R;
        private System.Windows.Forms.ToolStripMenuItem NtSetSystemPowerState_P;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip WarningToolTip;
        private System.Windows.Forms.Button InitiateSystemShutdownEx_Button;
        private System.Windows.Forms.ContextMenuStrip InitiateSystemShutdownEx;
        private System.Windows.Forms.ToolStripMenuItem InitiateSystemShutdownEx_N;
        private System.Windows.Forms.ToolStripMenuItem InitiateSystemShutdownEx_NF;
        private System.Windows.Forms.ToolStripMenuItem InitiateSystemShutdownEx_R;
        private System.Windows.Forms.ToolStripMenuItem InitiateSystemShutdownEx_RF;
    }
}

