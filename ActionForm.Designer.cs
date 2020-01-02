namespace RDMClipboard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forEachEntryTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceNewlineWithEntryTextDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.endTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionBindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.forEachEntryTextDataGridViewTextBoxColumn,
            this.replaceNewlineWithEntryTextDataGridViewCheckBoxColumn,
            this.endTextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actionBindingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // forEachEntryTextDataGridViewTextBoxColumn
            // 
            this.forEachEntryTextDataGridViewTextBoxColumn.DataPropertyName = "ForEachEntryText";
            this.forEachEntryTextDataGridViewTextBoxColumn.HeaderText = "ForEachEntryText";
            this.forEachEntryTextDataGridViewTextBoxColumn.Name = "forEachEntryTextDataGridViewTextBoxColumn";
            // 
            // replaceNewlineWithEntryTextDataGridViewCheckBoxColumn
            // 
            this.replaceNewlineWithEntryTextDataGridViewCheckBoxColumn.DataPropertyName = "ReplaceNewlineWithEntryText";
            this.replaceNewlineWithEntryTextDataGridViewCheckBoxColumn.HeaderText = "ReplaceNewlineWithEntryText";
            this.replaceNewlineWithEntryTextDataGridViewCheckBoxColumn.Name = "replaceNewlineWithEntryTextDataGridViewCheckBoxColumn";
            // 
            // endTextDataGridViewTextBoxColumn
            // 
            this.endTextDataGridViewTextBoxColumn.DataPropertyName = "EndText";
            this.endTextDataGridViewTextBoxColumn.HeaderText = "EndText";
            this.endTextDataGridViewTextBoxColumn.Name = "endTextDataGridViewTextBoxColumn";
            this.endTextDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // actionBindingBindingSource
            // 
            this.actionBindingBindingSource.DataSource = typeof(RDMClipboard.Classes.ActionBinding);
            // 
            // frm_HotkeyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 405);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_HotkeyEditor";
            this.Text = "Actions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource actionBindingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forEachEntryTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn replaceNewlineWithEntryTextDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTextDataGridViewTextBoxColumn;
    }
}