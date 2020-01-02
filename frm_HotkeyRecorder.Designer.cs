namespace Paster
{
    partial class frm_HotkeyEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HotkeyEditor));
            this.chk_Alt = new System.Windows.Forms.CheckBox();
            this.chk_Control = new System.Windows.Forms.CheckBox();
            this.chk_Shift = new System.Windows.Forms.CheckBox();
            this.combo_Character = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_ShowAdvanced = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Alt
            // 
            this.chk_Alt.AutoSize = true;
            this.chk_Alt.Location = new System.Drawing.Point(171, 45);
            this.chk_Alt.Name = "chk_Alt";
            this.chk_Alt.Size = new System.Drawing.Size(38, 17);
            this.chk_Alt.TabIndex = 6;
            this.chk_Alt.Text = "Alt";
            this.chk_Alt.UseVisualStyleBackColor = true;
            // 
            // chk_Control
            // 
            this.chk_Control.AutoSize = true;
            this.chk_Control.Location = new System.Drawing.Point(17, 45);
            this.chk_Control.Name = "chk_Control";
            this.chk_Control.Size = new System.Drawing.Size(59, 17);
            this.chk_Control.TabIndex = 7;
            this.chk_Control.Text = "Control";
            this.chk_Control.UseVisualStyleBackColor = true;
            // 
            // chk_Shift
            // 
            this.chk_Shift.AutoSize = true;
            this.chk_Shift.Location = new System.Drawing.Point(94, 45);
            this.chk_Shift.Name = "chk_Shift";
            this.chk_Shift.Size = new System.Drawing.Size(47, 17);
            this.chk_Shift.TabIndex = 8;
            this.chk_Shift.Text = "Shift";
            this.chk_Shift.UseVisualStyleBackColor = true;
            // 
            // combo_Character
            // 
            this.combo_Character.FormattingEnabled = true;
            this.combo_Character.Location = new System.Drawing.Point(230, 43);
            this.combo_Character.Name = "combo_Character";
            this.combo_Character.Size = new System.Drawing.Size(121, 21);
            this.combo_Character.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(165, 127);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(260, 127);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_ShowAdvanced);
            this.groupBox1.Controls.Add(this.chk_Alt);
            this.groupBox1.Controls.Add(this.chk_Control);
            this.groupBox1.Controls.Add(this.chk_Shift);
            this.groupBox1.Controls.Add(this.combo_Character);
            this.groupBox1.Location = new System.Drawing.Point(89, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkey";
            // 
            // chk_ShowAdvanced
            // 
            this.chk_ShowAdvanced.AutoSize = true;
            this.chk_ShowAdvanced.Location = new System.Drawing.Point(230, 70);
            this.chk_ShowAdvanced.Name = "chk_ShowAdvanced";
            this.chk_ShowAdvanced.Size = new System.Drawing.Size(104, 17);
            this.chk_ShowAdvanced.TabIndex = 10;
            this.chk_ShowAdvanced.Text = "Show advanced";
            this.chk_ShowAdvanced.UseVisualStyleBackColor = true;
            this.chk_ShowAdvanced.CheckedChanged += new System.EventHandler(this.chk_ShowAdvanced_CheckedChanged);
            // 
            // frm_HotkeyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 170);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HotkeyEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotkey Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Alt;
        private System.Windows.Forms.CheckBox chk_Control;
        private System.Windows.Forms.CheckBox chk_Shift;
        private System.Windows.Forms.ComboBox combo_Character;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_ShowAdvanced;
    }
}