namespace Paster
{
    partial class frm_Actions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Actions));
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dgv_Actions = new System.Windows.Forms.DataGridView();
            this.ReplaceNewline = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClearClipboard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PastingAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Split = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionBindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit.Location = new System.Drawing.Point(93, 290);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actions:";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.Location = new System.Drawing.Point(12, 290);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.Location = new System.Drawing.Point(174, 290);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Close.Location = new System.Drawing.Point(255, 290);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.dgv_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Actions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ReplaceNewline,
            this.ClearClipboard,
            this.PastingAction,
            this.Split,
            this.EntryText,
            this.endTextDataGridViewTextBoxColumn,
            this.DelayMS,
            this.hotkeyDataGridViewTextBoxColumn});
            this.dgv_Actions.DataSource = this.actionBindingBindingSource;
            this.dgv_Actions.Location = new System.Drawing.Point(12, 32);
            this.dgv_Actions.MultiSelect = false;
            this.dgv_Actions.Name = "dgv_Actions";
            this.dgv_Actions.ReadOnly = true;
            this.dgv_Actions.RowHeadersVisible = false;
            this.dgv_Actions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Actions.ShowCellErrors = false;
            this.dgv_Actions.ShowCellToolTips = false;
            this.dgv_Actions.ShowEditingIcon = false;
            this.dgv_Actions.ShowRowErrors = false;
            this.dgv_Actions.Size = new System.Drawing.Size(1084, 252);
            this.dgv_Actions.TabIndex = 1;
            this.dgv_Actions.SelectionChanged += new System.EventHandler(this.dgv_Actions_SelectionChanged);
            // 
            // ReplaceNewline
            // 
            this.ReplaceNewline.DataPropertyName = "ReplaceNewline";
            this.ReplaceNewline.FillWeight = 15F;
            this.ReplaceNewline.HeaderText = "Replace newline";
            this.ReplaceNewline.Name = "ReplaceNewline";
            this.ReplaceNewline.ReadOnly = true;
            // 
            // ClearClipboard
            // 
            this.ClearClipboard.DataPropertyName = "ClearClipboard";
            this.ClearClipboard.FillWeight = 15F;
            this.ClearClipboard.HeaderText = "Clear clipboard";
            this.ClearClipboard.Name = "ClearClipboard";
            this.ClearClipboard.ReadOnly = true;
            // 
            // PastingAction
            // 
            this.PastingAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PastingAction.DataPropertyName = "PastingAction";
            this.PastingAction.FillWeight = 20F;
            this.PastingAction.HeaderText = "PastingAction";
            this.PastingAction.Name = "PastingAction";
            this.PastingAction.ReadOnly = true;
            this.PastingAction.Width = 97;
            // 
            // Split
            // 
            this.Split.DataPropertyName = "Split";
            this.Split.FillWeight = 10F;
            this.Split.HeaderText = "Split on";
            this.Split.Name = "Split";
            this.Split.ReadOnly = true;
            // 
            // EntryText
            // 
            this.EntryText.DataPropertyName = "EntryText";
            this.EntryText.FillWeight = 20F;
            this.EntryText.HeaderText = "EntryText";
            this.EntryText.Name = "EntryText";
            this.EntryText.ReadOnly = true;
            // 
            // DelayMS
            // 
            this.DelayMS.DataPropertyName = "DelayMS";
            this.DelayMS.FillWeight = 13F;
            this.DelayMS.HeaderText = "Delay (ms)";
            this.DelayMS.Name = "DelayMS";
            this.DelayMS.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 75F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
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
            // actionBindingBindingSource
            // 
            this.actionBindingBindingSource.DataSource = typeof(Paster.Classes.PasteAction);
            // 
            // frm_Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 323);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Actions);
            this.Controls.Add(this.btn_Edit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Actions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.BindingSource actionBindingBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dgv_Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReplaceNewline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClearClipboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastingAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Split;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryText;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotkeyDataGridViewTextBoxColumn;
    }
}