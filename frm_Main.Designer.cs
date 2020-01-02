namespace Paster
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.timer_ActiveWindow = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMeny_NotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.pb_Settings = new System.Windows.Forms.PictureBox();
            this.pb_Information = new System.Windows.Forms.PictureBox();
            this.btn_Paste = new System.Windows.Forms.Button();
            this.btn_SetupHotkeys = new System.Windows.Forms.Button();
            this.contextMeny_NotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Information)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_ActiveWindow
            // 
            this.timer_ActiveWindow.Interval = 250;
            this.timer_ActiveWindow.Tick += new System.EventHandler(this.timer_ActiveWindow_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(98, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Setup Actions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(346, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Paste!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 56);
            this.label2.TabIndex = 26;
            this.label2.Text = "Paster";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMeny_NotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Paster";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMeny_NotifyIcon
            // 
            this.contextMeny_NotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Open,
            this.tsmi_Exit});
            this.contextMeny_NotifyIcon.Name = "contextMeny_NotifyIcon";
            this.contextMeny_NotifyIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // tsmi_Open
            // 
            this.tsmi_Open.Name = "tsmi_Open";
            this.tsmi_Open.Size = new System.Drawing.Size(103, 22);
            this.tsmi_Open.Text = "Open";
            this.tsmi_Open.Click += new System.EventHandler(this.tsmi_Open_Click);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(103, 22);
            this.tsmi_Exit.Text = "Exit";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Version.Location = new System.Drawing.Point(473, 319);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(31, 13);
            this.lbl_Version.TabIndex = 29;
            this.lbl_Version.Text = "0.0.0";
            // 
            // pb_Settings
            // 
            this.pb_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Settings.Image = global::Paster.Properties.Resources.Settings;
            this.pb_Settings.Location = new System.Drawing.Point(429, 23);
            this.pb_Settings.Name = "pb_Settings";
            this.pb_Settings.Size = new System.Drawing.Size(32, 32);
            this.pb_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Settings.TabIndex = 28;
            this.pb_Settings.TabStop = false;
            this.pb_Settings.Click += new System.EventHandler(this.pb_Settings_Click);
            this.pb_Settings.MouseLeave += new System.EventHandler(this.pb_Settings_MouseLeave);
            this.pb_Settings.MouseHover += new System.EventHandler(this.pb_Settings_MouseHover);
            // 
            // pb_Information
            // 
            this.pb_Information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Information.Image = global::Paster.Properties.Resources.Question;
            this.pb_Information.Location = new System.Drawing.Point(476, 23);
            this.pb_Information.Name = "pb_Information";
            this.pb_Information.Size = new System.Drawing.Size(32, 32);
            this.pb_Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Information.TabIndex = 27;
            this.pb_Information.TabStop = false;
            this.pb_Information.Click += new System.EventHandler(this.pb_Information_Click);
            this.pb_Information.MouseLeave += new System.EventHandler(this.pb_Information_MouseLeave);
            this.pb_Information.MouseHover += new System.EventHandler(this.pb_Information_MouseHover);
            // 
            // btn_Paste
            // 
            this.btn_Paste.BackgroundImage = global::Paster.Properties.Resources.Paste;
            this.btn_Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Paste.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Paste.Location = new System.Drawing.Point(273, 85);
            this.btn_Paste.Name = "btn_Paste";
            this.btn_Paste.Size = new System.Drawing.Size(200, 200);
            this.btn_Paste.TabIndex = 24;
            this.btn_Paste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Paste.UseVisualStyleBackColor = true;
            this.btn_Paste.Click += new System.EventHandler(this.btn_Paste_Click);
            // 
            // btn_SetupHotkeys
            // 
            this.btn_SetupHotkeys.BackgroundImage = global::Paster.Properties.Resources.EditActions;
            this.btn_SetupHotkeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SetupHotkeys.Location = new System.Drawing.Point(51, 85);
            this.btn_SetupHotkeys.Name = "btn_SetupHotkeys";
            this.btn_SetupHotkeys.Size = new System.Drawing.Size(200, 200);
            this.btn_SetupHotkeys.TabIndex = 20;
            this.btn_SetupHotkeys.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SetupHotkeys.UseVisualStyleBackColor = true;
            this.btn_SetupHotkeys.Click += new System.EventHandler(this.btn_SetupHotkeys_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(520, 341);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.pb_Settings);
            this.Controls.Add(this.pb_Information);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Paste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_SetupHotkeys);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.contextMeny_NotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_ActiveWindow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SetupHotkeys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Paste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMeny_NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Open;
        private System.Windows.Forms.PictureBox pb_Information;
        private System.Windows.Forms.PictureBox pb_Settings;
        private System.Windows.Forms.Label lbl_Version;
    }
}

