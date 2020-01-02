namespace Paster
{
    partial class frm_ActionPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ActionPicker));
            this.dgv_Actions = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplaceNewline = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClearClipboard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pastingActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Split = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasteActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Paste = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ClipboardStatus = new System.Windows.Forms.Label();
            this.timer_ClipboardStatus = new System.Windows.Forms.Timer(this.components);
            this.dgv_LastApplications = new System.Windows.Forms.DataGridView();
            this.windowHandleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windowIconDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.windowTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastActiveWindowModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LastApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Actions
            // 
            this.dgv_Actions.AllowUserToAddRows = false;
            this.dgv_Actions.AllowUserToDeleteRows = false;
            this.dgv_Actions.AllowUserToResizeRows = false;
            this.dgv_Actions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Actions.AutoGenerateColumns = false;
            this.dgv_Actions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Actions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ReplaceNewline,
            this.ClearClipboard,
            this.pastingActionDataGridViewTextBoxColumn,
            this.Split,
            this.entryTextDataGridViewTextBoxColumn,
            this.endTextDataGridViewTextBoxColumn,
            this.hotkeyDataGridViewTextBoxColumn});
            this.dgv_Actions.DataSource = this.pasteActionBindingSource;
            this.dgv_Actions.Location = new System.Drawing.Point(12, 56);
            this.dgv_Actions.MultiSelect = false;
            this.dgv_Actions.Name = "dgv_Actions";
            this.dgv_Actions.ReadOnly = true;
            this.dgv_Actions.RowHeadersVisible = false;
            this.dgv_Actions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_Actions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Actions.ShowCellErrors = false;
            this.dgv_Actions.ShowCellToolTips = false;
            this.dgv_Actions.ShowEditingIcon = false;
            this.dgv_Actions.ShowRowErrors = false;
            this.dgv_Actions.Size = new System.Drawing.Size(743, 126);
            this.dgv_Actions.TabIndex = 0;
            this.dgv_Actions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Actions_CellContentClick);
            this.dgv_Actions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Actions_CellFormatting);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 1F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 75F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // ReplaceNewline
            // 
            this.ReplaceNewline.DataPropertyName = "ReplaceNewline";
            this.ReplaceNewline.FillWeight = 20F;
            this.ReplaceNewline.HeaderText = "Newline as entry";
            this.ReplaceNewline.Name = "ReplaceNewline";
            this.ReplaceNewline.ReadOnly = true;
            // 
            // ClearClipboard
            // 
            this.ClearClipboard.DataPropertyName = "ClearClipboard";
            this.ClearClipboard.FillWeight = 20F;
            this.ClearClipboard.HeaderText = "Clear clipboard";
            this.ClearClipboard.Name = "ClearClipboard";
            this.ClearClipboard.ReadOnly = true;
            // 
            // pastingActionDataGridViewTextBoxColumn
            // 
            this.pastingActionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pastingActionDataGridViewTextBoxColumn.DataPropertyName = "PastingAction";
            this.pastingActionDataGridViewTextBoxColumn.FillWeight = 20F;
            this.pastingActionDataGridViewTextBoxColumn.HeaderText = "PastingAction";
            this.pastingActionDataGridViewTextBoxColumn.Name = "pastingActionDataGridViewTextBoxColumn";
            this.pastingActionDataGridViewTextBoxColumn.ReadOnly = true;
            this.pastingActionDataGridViewTextBoxColumn.Width = 97;
            // 
            // Split
            // 
            this.Split.DataPropertyName = "Split";
            this.Split.FillWeight = 10F;
            this.Split.HeaderText = "Split on";
            this.Split.Name = "Split";
            this.Split.ReadOnly = true;
            // 
            // entryTextDataGridViewTextBoxColumn
            // 
            this.entryTextDataGridViewTextBoxColumn.DataPropertyName = "EntryText";
            this.entryTextDataGridViewTextBoxColumn.FillWeight = 20F;
            this.entryTextDataGridViewTextBoxColumn.HeaderText = "EntryText";
            this.entryTextDataGridViewTextBoxColumn.Name = "entryTextDataGridViewTextBoxColumn";
            this.entryTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTextDataGridViewTextBoxColumn
            // 
            this.endTextDataGridViewTextBoxColumn.DataPropertyName = "EndText";
            this.endTextDataGridViewTextBoxColumn.FillWeight = 20F;
            this.endTextDataGridViewTextBoxColumn.HeaderText = "EndText";
            this.endTextDataGridViewTextBoxColumn.Name = "endTextDataGridViewTextBoxColumn";
            this.endTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotkeyDataGridViewTextBoxColumn
            // 
            this.hotkeyDataGridViewTextBoxColumn.DataPropertyName = "Hotkey";
            this.hotkeyDataGridViewTextBoxColumn.FillWeight = 30F;
            this.hotkeyDataGridViewTextBoxColumn.HeaderText = "Hotkey";
            this.hotkeyDataGridViewTextBoxColumn.Name = "hotkeyDataGridViewTextBoxColumn";
            this.hotkeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pasteActionBindingSource
            // 
            this.pasteActionBindingSource.DataSource = typeof(Paster.Classes.PasteAction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick an action";
            // 
            // btn_Paste
            // 
            this.btn_Paste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Paste.Location = new System.Drawing.Point(8, 365);
            this.btn_Paste.Name = "btn_Paste";
            this.btn_Paste.Size = new System.Drawing.Size(75, 23);
            this.btn_Paste.TabIndex = 2;
            this.btn_Paste.Text = "Paste!";
            this.btn_Paste.UseVisualStyleBackColor = true;
            this.btn_Paste.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.Location = new System.Drawing.Point(89, 365);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Clipboard status:";
            // 
            // lbl_ClipboardStatus
            // 
            this.lbl_ClipboardStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ClipboardStatus.AutoSize = true;
            this.lbl_ClipboardStatus.Location = new System.Drawing.Point(100, 349);
            this.lbl_ClipboardStatus.Name = "lbl_ClipboardStatus";
            this.lbl_ClipboardStatus.Size = new System.Drawing.Size(93, 13);
            this.lbl_ClipboardStatus.TabIndex = 22;
            this.lbl_ClipboardStatus.Text = "<ClipboardStatus>";
            // 
            // timer_ClipboardStatus
            // 
            this.timer_ClipboardStatus.Tick += new System.EventHandler(this.timer_ClipboardStatus_Tick);
            // 
            // dgv_LastApplications
            // 
            this.dgv_LastApplications.AllowUserToAddRows = false;
            this.dgv_LastApplications.AllowUserToDeleteRows = false;
            this.dgv_LastApplications.AllowUserToResizeRows = false;
            this.dgv_LastApplications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LastApplications.AutoGenerateColumns = false;
            this.dgv_LastApplications.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_LastApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LastApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.windowHandleDataGridViewTextBoxColumn,
            this.windowIconDataGridViewImageColumn,
            this.windowTitleDataGridViewTextBoxColumn,
            this.lastActiveWindowModeDataGridViewTextBoxColumn});
            this.dgv_LastApplications.DataSource = this.applicationBindingSource;
            this.dgv_LastApplications.Location = new System.Drawing.Point(8, 213);
            this.dgv_LastApplications.MultiSelect = false;
            this.dgv_LastApplications.Name = "dgv_LastApplications";
            this.dgv_LastApplications.ReadOnly = true;
            this.dgv_LastApplications.RowHeadersVisible = false;
            this.dgv_LastApplications.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_LastApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LastApplications.ShowCellErrors = false;
            this.dgv_LastApplications.ShowCellToolTips = false;
            this.dgv_LastApplications.ShowEditingIcon = false;
            this.dgv_LastApplications.ShowRowErrors = false;
            this.dgv_LastApplications.Size = new System.Drawing.Size(743, 133);
            this.dgv_LastApplications.TabIndex = 25;
            this.dgv_LastApplications.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_LastApplications_DataError);
            // 
            // windowHandleDataGridViewTextBoxColumn
            // 
            this.windowHandleDataGridViewTextBoxColumn.DataPropertyName = "WindowHandle";
            this.windowHandleDataGridViewTextBoxColumn.HeaderText = "WindowHandle";
            this.windowHandleDataGridViewTextBoxColumn.Name = "windowHandleDataGridViewTextBoxColumn";
            this.windowHandleDataGridViewTextBoxColumn.ReadOnly = true;
            this.windowHandleDataGridViewTextBoxColumn.Visible = false;
            // 
            // windowIconDataGridViewImageColumn
            // 
            this.windowIconDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.windowIconDataGridViewImageColumn.DataPropertyName = "WindowIcon";
            this.windowIconDataGridViewImageColumn.FillWeight = 5F;
            this.windowIconDataGridViewImageColumn.HeaderText = "Icon";
            this.windowIconDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.windowIconDataGridViewImageColumn.MinimumWidth = 32;
            this.windowIconDataGridViewImageColumn.Name = "windowIconDataGridViewImageColumn";
            this.windowIconDataGridViewImageColumn.ReadOnly = true;
            // 
            // windowTitleDataGridViewTextBoxColumn
            // 
            this.windowTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.windowTitleDataGridViewTextBoxColumn.DataPropertyName = "WindowTitle";
            this.windowTitleDataGridViewTextBoxColumn.FillWeight = 70F;
            this.windowTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.windowTitleDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.windowTitleDataGridViewTextBoxColumn.Name = "windowTitleDataGridViewTextBoxColumn";
            this.windowTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastActiveWindowModeDataGridViewTextBoxColumn
            // 
            this.lastActiveWindowModeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastActiveWindowModeDataGridViewTextBoxColumn.DataPropertyName = "LastActiveWindowMode";
            this.lastActiveWindowModeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.lastActiveWindowModeDataGridViewTextBoxColumn.HeaderText = "State";
            this.lastActiveWindowModeDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.lastActiveWindowModeDataGridViewTextBoxColumn.Name = "lastActiveWindowModeDataGridViewTextBoxColumn";
            this.lastActiveWindowModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataSource = typeof(Paster.Classes.Application);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Paste into";
            // 
            // frm_ActionPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_LastApplications);
            this.Controls.Add(this.lbl_ClipboardStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Paste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Actions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ActionPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.Shown += new System.EventHandler(this.frm_ActionPicker_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LastApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Actions;
        private System.Windows.Forms.BindingSource pasteActionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Paste;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ClipboardStatus;
        private System.Windows.Forms.Timer timer_ClipboardStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReplaceNewline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClearClipboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastingActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Split;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_LastApplications;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowHandleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn windowIconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActiveWindowModeDataGridViewTextBoxColumn;
    }
}