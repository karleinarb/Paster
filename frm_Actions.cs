using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paster.Classes;

namespace Paster
{
    public partial class frm_Actions : Form
    {
        private PasteAction selectedPasteAction;

        public frm_Actions()
        {
            InitializeComponent();
            dgv_Actions.DataSource = Global.Actions;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(this.selectedPasteAction != null)
            {
                using(frm_ActionEditor dialog = new frm_ActionEditor(selectedPasteAction))
                {
                    dialog.ShowDialog();
                    if(dialog.DialogResult == DialogResult.OK)
                    {
                        Global.RegisterActionHotkeys();
                    }
                }
            }

            UpdateControls();
            UpdateDataGridView();
            
        }

        private void UpdateControls()
        {
            if (dgv_Actions.SelectedRows.Count >= 1) { 
                this.btn_Edit.Enabled = true;
                if (PasteAction.ReservedIDs.Contains(this.selectedPasteAction.ID))
                {
                    this.btn_Delete.Enabled = false;
                }
                else
                {
                    this.btn_Delete.Enabled = true;
                }
            }
            else { this.btn_Edit.Enabled = false; }

        }

        private void UpdateDataGridView()
        {
            dgv_Actions.DataSource = null;
            dgv_Actions.DataSource = Global.Actions;
        }

        private void dgv_Actions_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_Actions.SelectedRows.Count >= 1)
            {
                selectedPasteAction = dgv_Actions.SelectedRows[0].DataBoundItem as PasteAction;
            }
            else
            {
                selectedPasteAction = null;
            }
            
            UpdateControls();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (frm_ActionEditor dialog = new frm_ActionEditor())
            {
                dialog.ShowDialog();
                UpdateControls();
                UpdateDataGridView();
                Global.RegisterActionHotkeys();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(selectedPasteAction != null)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedPasteAction.Name, "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    Global.Actions.Remove(selectedPasteAction);
                    Global.SaveActions();
                    UpdateDataGridView();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
