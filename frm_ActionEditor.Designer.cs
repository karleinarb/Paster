namespace Paster
{
    partial class frm_ActionEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ActionEditor));
            this.txt_EndText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EntryText = new System.Windows.Forms.TextBox();
            this.chk_ConvertNLToEntry = new System.Windows.Forms.CheckBox();
            this.grp_General = new System.Windows.Forms.GroupBox();
            this.radio_None = new System.Windows.Forms.RadioButton();
            this.radio_Autotype = new System.Windows.Forms.RadioButton();
            this.radio_Paste = new System.Windows.Forms.RadioButton();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_ClearClipboard = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Split = new System.Windows.Forms.TextBox();
            this.grp_Paste = new System.Windows.Forms.GroupBox();
            this.pb_EndInfo = new System.Windows.Forms.PictureBox();
            this.pb_EntryInfo = new System.Windows.Forms.PictureBox();
            this.grp_Hotkey = new System.Windows.Forms.GroupBox();
            this.btn_ClearHotkey = new System.Windows.Forms.Button();
            this.btn_ChangeHotkey = new System.Windows.Forms.Button();
            this.txt_Hotkey = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.num_DelayMS = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_General.SuspendLayout();
            this.grp_Paste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EndInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EntryInfo)).BeginInit();
            this.grp_Hotkey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_DelayMS)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_EndText
            // 
            this.txt_EndText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EndText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EndText.Location = new System.Drawing.Point(132, 44);
            this.txt_EndText.Multiline = true;
            this.txt_EndText.Name = "txt_EndText";
            this.txt_EndText.Size = new System.Drawing.Size(190, 22);
            this.txt_EndText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Add after last entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add between entries";
            // 
            // txt_EntryText
            // 
            this.txt_EntryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EntryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EntryText.Location = new System.Drawing.Point(132, 16);
            this.txt_EntryText.Multiline = true;
            this.txt_EntryText.Name = "txt_EntryText";
            this.txt_EntryText.Size = new System.Drawing.Size(190, 22);
            this.txt_EntryText.TabIndex = 11;
            // 
            // chk_ConvertNLToEntry
            // 
            this.chk_ConvertNLToEntry.AutoSize = true;
            this.chk_ConvertNLToEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ConvertNLToEntry.Location = new System.Drawing.Point(50, 71);
            this.chk_ConvertNLToEntry.Name = "chk_ConvertNLToEntry";
            this.chk_ConvertNLToEntry.Size = new System.Drawing.Size(161, 17);
            this.chk_ConvertNLToEntry.TabIndex = 17;
            this.chk_ConvertNLToEntry.Text = "Replace new lines as entries";
            this.chk_ConvertNLToEntry.UseVisualStyleBackColor = true;
            // 
            // grp_General
            // 
            this.grp_General.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_General.Controls.Add(this.radio_None);
            this.grp_General.Controls.Add(this.radio_Autotype);
            this.grp_General.Controls.Add(this.radio_Paste);
            this.grp_General.Controls.Add(this.txt_Name);
            this.grp_General.Controls.Add(this.label4);
            this.grp_General.Controls.Add(this.chk_ClearClipboard);
            this.grp_General.Controls.Add(this.label1);
            this.grp_General.Controls.Add(this.txt_Split);
            this.grp_General.Controls.Add(this.chk_ConvertNLToEntry);
            this.grp_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_General.Location = new System.Drawing.Point(12, 12);
            this.grp_General.Name = "grp_General";
            this.grp_General.Size = new System.Drawing.Size(398, 147);
            this.grp_General.TabIndex = 18;
            this.grp_General.TabStop = false;
            this.grp_General.Text = "General settings";
            // 
            // radio_None
            // 
            this.radio_None.AutoSize = true;
            this.radio_None.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_None.Location = new System.Drawing.Point(181, 48);
            this.radio_None.Name = "radio_None";
            this.radio_None.Size = new System.Drawing.Size(51, 17);
            this.radio_None.TabIndex = 25;
            this.radio_None.Text = "None";
            this.radio_None.UseVisualStyleBackColor = true;
            // 
            // radio_Autotype
            // 
            this.radio_Autotype.AutoSize = true;
            this.radio_Autotype.Checked = true;
            this.radio_Autotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Autotype.Location = new System.Drawing.Point(50, 48);
            this.radio_Autotype.Name = "radio_Autotype";
            this.radio_Autotype.Size = new System.Drawing.Size(67, 17);
            this.radio_Autotype.TabIndex = 24;
            this.radio_Autotype.TabStop = true;
            this.radio_Autotype.Text = "Autotype";
            this.radio_Autotype.UseVisualStyleBackColor = true;
            // 
            // radio_Paste
            // 
            this.radio_Paste.AutoSize = true;
            this.radio_Paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Paste.Location = new System.Drawing.Point(123, 48);
            this.radio_Paste.Name = "radio_Paste";
            this.radio_Paste.Size = new System.Drawing.Size(52, 17);
            this.radio_Paste.TabIndex = 23;
            this.radio_Paste.Text = "Paste";
            this.radio_Paste.UseVisualStyleBackColor = true;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(64, 22);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(256, 20);
            this.txt_Name.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name:";
            // 
            // chk_ClearClipboard
            // 
            this.chk_ClearClipboard.AutoSize = true;
            this.chk_ClearClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ClearClipboard.Location = new System.Drawing.Point(50, 94);
            this.chk_ClearClipboard.Name = "chk_ClearClipboard";
            this.chk_ClearClipboard.Size = new System.Drawing.Size(149, 17);
            this.chk_ClearClipboard.TabIndex = 20;
            this.chk_ClearClipboard.Text = "Clear clipboard after paste";
            this.chk_ClearClipboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Split on text:";
            // 
            // txt_Split
            // 
            this.txt_Split.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Split.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Split.Location = new System.Drawing.Point(132, 115);
            this.txt_Split.MaxLength = 100;
            this.txt_Split.Name = "txt_Split";
            this.txt_Split.Size = new System.Drawing.Size(188, 20);
            this.txt_Split.TabIndex = 18;
            // 
            // grp_Paste
            // 
            this.grp_Paste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Paste.Controls.Add(this.label6);
            this.grp_Paste.Controls.Add(this.num_DelayMS);
            this.grp_Paste.Controls.Add(this.label5);
            this.grp_Paste.Controls.Add(this.pb_EndInfo);
            this.grp_Paste.Controls.Add(this.pb_EntryInfo);
            this.grp_Paste.Controls.Add(this.txt_EntryText);
            this.grp_Paste.Controls.Add(this.label2);
            this.grp_Paste.Controls.Add(this.txt_EndText);
            this.grp_Paste.Controls.Add(this.label3);
            this.grp_Paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Paste.Location = new System.Drawing.Point(12, 165);
            this.grp_Paste.Name = "grp_Paste";
            this.grp_Paste.Size = new System.Drawing.Size(398, 109);
            this.grp_Paste.TabIndex = 18;
            this.grp_Paste.TabStop = false;
            this.grp_Paste.Text = "Paste settings";
            // 
            // pb_EndInfo
            // 
            this.pb_EndInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_EndInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_EndInfo.Image = global::Paster.Properties.Resources.Question;
            this.pb_EndInfo.Location = new System.Drawing.Point(331, 44);
            this.pb_EndInfo.Name = "pb_EndInfo";
            this.pb_EndInfo.Size = new System.Drawing.Size(22, 22);
            this.pb_EndInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_EndInfo.TabIndex = 16;
            this.pb_EndInfo.TabStop = false;
            this.pb_EndInfo.Click += new System.EventHandler(this.pb_EndInfo_Click);
            // 
            // pb_EntryInfo
            // 
            this.pb_EntryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_EntryInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_EntryInfo.Image = global::Paster.Properties.Resources.Question;
            this.pb_EntryInfo.Location = new System.Drawing.Point(331, 16);
            this.pb_EntryInfo.Name = "pb_EntryInfo";
            this.pb_EntryInfo.Size = new System.Drawing.Size(22, 22);
            this.pb_EntryInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_EntryInfo.TabIndex = 15;
            this.pb_EntryInfo.TabStop = false;
            this.pb_EntryInfo.Click += new System.EventHandler(this.pb_EntryInfo_Click);
            // 
            // grp_Hotkey
            // 
            this.grp_Hotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Hotkey.Controls.Add(this.btn_ClearHotkey);
            this.grp_Hotkey.Controls.Add(this.btn_ChangeHotkey);
            this.grp_Hotkey.Controls.Add(this.txt_Hotkey);
            this.grp_Hotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Hotkey.Location = new System.Drawing.Point(12, 280);
            this.grp_Hotkey.Name = "grp_Hotkey";
            this.grp_Hotkey.Size = new System.Drawing.Size(398, 57);
            this.grp_Hotkey.TabIndex = 19;
            this.grp_Hotkey.TabStop = false;
            this.grp_Hotkey.Text = "Hotkey";
            // 
            // btn_ClearHotkey
            // 
            this.btn_ClearHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearHotkey.Location = new System.Drawing.Point(317, 16);
            this.btn_ClearHotkey.Name = "btn_ClearHotkey";
            this.btn_ClearHotkey.Size = new System.Drawing.Size(70, 23);
            this.btn_ClearHotkey.TabIndex = 2;
            this.btn_ClearHotkey.Text = "Clear";
            this.btn_ClearHotkey.UseVisualStyleBackColor = true;
            this.btn_ClearHotkey.Click += new System.EventHandler(this.btn_ClearHotkey_Click);
            // 
            // btn_ChangeHotkey
            // 
            this.btn_ChangeHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeHotkey.Location = new System.Drawing.Point(241, 16);
            this.btn_ChangeHotkey.Name = "btn_ChangeHotkey";
            this.btn_ChangeHotkey.Size = new System.Drawing.Size(70, 23);
            this.btn_ChangeHotkey.TabIndex = 1;
            this.btn_ChangeHotkey.Text = "Change";
            this.btn_ChangeHotkey.UseVisualStyleBackColor = true;
            this.btn_ChangeHotkey.Click += new System.EventHandler(this.btn_ChangeHotkey_Click);
            // 
            // txt_Hotkey
            // 
            this.txt_Hotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Hotkey.Enabled = false;
            this.txt_Hotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hotkey.Location = new System.Drawing.Point(9, 19);
            this.txt_Hotkey.Name = "txt_Hotkey";
            this.txt_Hotkey.Size = new System.Drawing.Size(226, 20);
            this.txt_Hotkey.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(262, 342);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(70, 23);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(340, 342);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Delay between entries";
            // 
            // num_DelayMS
            // 
            this.num_DelayMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_DelayMS.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_DelayMS.Location = new System.Drawing.Point(132, 72);
            this.num_DelayMS.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.num_DelayMS.Name = "num_DelayMS";
            this.num_DelayMS.Size = new System.Drawing.Size(190, 20);
            this.num_DelayMS.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Milliseconds";
            // 
            // frm_ActionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 376);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.grp_Hotkey);
            this.Controls.Add(this.grp_Paste);
            this.Controls.Add(this.grp_General);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ActionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Action Editor";
            this.Load += new System.EventHandler(this.ActionEditor_Load);
            this.grp_General.ResumeLayout(false);
            this.grp_General.PerformLayout();
            this.grp_Paste.ResumeLayout(false);
            this.grp_Paste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EndInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_EntryInfo)).EndInit();
            this.grp_Hotkey.ResumeLayout(false);
            this.grp_Hotkey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_DelayMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EndText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EntryText;
        private System.Windows.Forms.CheckBox chk_ConvertNLToEntry;
        private System.Windows.Forms.GroupBox grp_General;
        private System.Windows.Forms.GroupBox grp_Paste;
        private System.Windows.Forms.CheckBox chk_ClearClipboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Split;
        private System.Windows.Forms.GroupBox grp_Hotkey;
        private System.Windows.Forms.Button btn_ChangeHotkey;
        private System.Windows.Forms.TextBox txt_Hotkey;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton radio_Autotype;
        private System.Windows.Forms.RadioButton radio_Paste;
        private System.Windows.Forms.RadioButton radio_None;
        private System.Windows.Forms.PictureBox pb_EndInfo;
        private System.Windows.Forms.PictureBox pb_EntryInfo;
        private System.Windows.Forms.Button btn_ClearHotkey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_DelayMS;
        private System.Windows.Forms.Label label5;
    }
}