namespace Paster
{
    partial class frm_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Settings));
            this.chk_StartWithWindows = new System.Windows.Forms.CheckBox();
            this.chk_StartMinimized = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ResetDefaultConfiguration = new System.Windows.Forms.Button();
            this.btn_OpenConfigurationFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ResetActionsDefault = new System.Windows.Forms.Button();
            this.btn_OpenActionsFile = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_StartWithWindows
            // 
            this.chk_StartWithWindows.Location = new System.Drawing.Point(6, 21);
            this.chk_StartWithWindows.Name = "chk_StartWithWindows";
            this.chk_StartWithWindows.Size = new System.Drawing.Size(152, 17);
            this.chk_StartWithWindows.TabIndex = 0;
            this.chk_StartWithWindows.Text = "Start when Windows starts";
            this.chk_StartWithWindows.UseVisualStyleBackColor = true;
            this.chk_StartWithWindows.CheckedChanged += new System.EventHandler(this.chk_StartWithWindows_CheckedChanged);
            // 
            // chk_StartMinimized
            // 
            this.chk_StartMinimized.AutoSize = true;
            this.chk_StartMinimized.Location = new System.Drawing.Point(6, 48);
            this.chk_StartMinimized.Name = "chk_StartMinimized";
            this.chk_StartMinimized.Size = new System.Drawing.Size(96, 17);
            this.chk_StartMinimized.TabIndex = 3;
            this.chk_StartMinimized.Text = "Start minimized";
            this.chk_StartMinimized.UseVisualStyleBackColor = true;
            this.chk_StartMinimized.CheckedChanged += new System.EventHandler(this.chk_StartMinimized_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ResetDefaultConfiguration);
            this.groupBox1.Controls.Add(this.btn_OpenConfigurationFile);
            this.groupBox1.Controls.Add(this.chk_StartWithWindows);
            this.groupBox1.Controls.Add(this.chk_StartMinimized);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application";
            // 
            // btn_ResetDefaultConfiguration
            // 
            this.btn_ResetDefaultConfiguration.Location = new System.Drawing.Point(6, 100);
            this.btn_ResetDefaultConfiguration.Name = "btn_ResetDefaultConfiguration";
            this.btn_ResetDefaultConfiguration.Size = new System.Drawing.Size(110, 23);
            this.btn_ResetDefaultConfiguration.TabIndex = 6;
            this.btn_ResetDefaultConfiguration.Text = "Reset to default";
            this.btn_ResetDefaultConfiguration.UseVisualStyleBackColor = true;
            this.btn_ResetDefaultConfiguration.Click += new System.EventHandler(this.btn_ResetDefaultConfiguration_Click);
            // 
            // btn_OpenConfigurationFile
            // 
            this.btn_OpenConfigurationFile.Location = new System.Drawing.Point(6, 71);
            this.btn_OpenConfigurationFile.Name = "btn_OpenConfigurationFile";
            this.btn_OpenConfigurationFile.Size = new System.Drawing.Size(110, 23);
            this.btn_OpenConfigurationFile.TabIndex = 5;
            this.btn_OpenConfigurationFile.Text = "Open file";
            this.btn_OpenConfigurationFile.UseVisualStyleBackColor = true;
            this.btn_OpenConfigurationFile.Click += new System.EventHandler(this.btn_OpenConfigurationFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ResetActionsDefault);
            this.groupBox2.Controls.Add(this.btn_OpenActionsFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btn_ResetActionsDefault
            // 
            this.btn_ResetActionsDefault.Location = new System.Drawing.Point(6, 48);
            this.btn_ResetActionsDefault.Name = "btn_ResetActionsDefault";
            this.btn_ResetActionsDefault.Size = new System.Drawing.Size(110, 23);
            this.btn_ResetActionsDefault.TabIndex = 8;
            this.btn_ResetActionsDefault.Text = "Reset to default";
            this.btn_ResetActionsDefault.UseVisualStyleBackColor = true;
            this.btn_ResetActionsDefault.Click += new System.EventHandler(this.btn_ResetActionsDefault_Click);
            // 
            // btn_OpenActionsFile
            // 
            this.btn_OpenActionsFile.Location = new System.Drawing.Point(6, 19);
            this.btn_OpenActionsFile.Name = "btn_OpenActionsFile";
            this.btn_OpenActionsFile.Size = new System.Drawing.Size(110, 23);
            this.btn_OpenActionsFile.TabIndex = 7;
            this.btn_OpenActionsFile.Text = "Open file";
            this.btn_OpenActionsFile.UseVisualStyleBackColor = true;
            this.btn_OpenActionsFile.Click += new System.EventHandler(this.btn_OpenActionsFile_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(49, 249);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(130, 249);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 280);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_StartWithWindows;
        private System.Windows.Forms.CheckBox chk_StartMinimized;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ResetDefaultConfiguration;
        private System.Windows.Forms.Button btn_OpenConfigurationFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ResetActionsDefault;
        private System.Windows.Forms.Button btn_OpenActionsFile;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
    }
}