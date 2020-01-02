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
    public partial class frm_ActionPicker : Form
    {
        private PasteAction selectedPasteAction;

        public frm_ActionPicker()
        {
            InitializeComponent();

            dgv_Actions.DataSource = Global.Actions;
            UpdateLastApplications();
            timer_ClipboardStatus.Start();
            UpdateControls();
            Global.OnLastActiveWindowIconChanged += Global_OnLastActiveWindowIconChanged;
            Global.OnLastActiveWindowTitleChanged += Global_OnLastActiveWindowTitleChanged;

            Global.LastApplications.ListChanged += LastApplications_ListChanged;
        }

        private void LastApplications_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateLastApplications();
        }

        private void Global_OnLastActiveWindowTitleChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void Global_OnLastActiveWindowIconChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateLastApplications()
        {
            dgv_LastApplications.DataSource = null;
            dgv_LastApplications.DataSource = Global.LastApplications;
            if(dgv_LastApplications.Rows.Count >= 1)
            {
                dgv_LastApplications.Rows[0].Selected = true;
            }
        }

        private void UpdateControls()
        {
            if (Clipboard.ContainsText() && dgv_LastApplications.SelectedRows.Count >= 1)
            {
                lbl_ClipboardStatus.Text = "Contains text";
                lbl_ClipboardStatus.ForeColor = Color.Green;
                btn_Paste.Enabled = true;
            }
            else if (dgv_Actions.SelectedRows.Count == 0)
            {
                lbl_ClipboardStatus.Text = "No action is selected";
                lbl_ClipboardStatus.ForeColor = Color.Red;
                btn_Paste.Enabled = false;
            }
            else if (dgv_LastApplications.SelectedRows.Count == 0)
            {
                lbl_ClipboardStatus.Text = "No application is selected";
                lbl_ClipboardStatus.ForeColor = Color.Red;
                btn_Paste.Enabled = false;
            }
            else if (Clipboard.ContainsImage())
            {
                lbl_ClipboardStatus.Text = "Contains image";
                lbl_ClipboardStatus.ForeColor = Color.Red;
                btn_Paste.Enabled = false;
            }
            else if (Clipboard.ContainsAudio())
            {
                lbl_ClipboardStatus.Text = "Contains audio";
                lbl_ClipboardStatus.ForeColor = Color.Red;
                btn_Paste.Enabled = false;
            }
            else if (Clipboard.ContainsFileDropList())
            {
                lbl_ClipboardStatus.Text = "Contains files";
                lbl_ClipboardStatus.ForeColor = Color.Red;
                btn_Paste.Enabled = false;
            }
            else
            {
                lbl_ClipboardStatus.Text = "Clipboard is empty";
                lbl_ClipboardStatus.ForeColor = Color.Red;
                btn_Paste.Enabled = false;
            }

            foreach(DataGridViewRow row in dgv_Actions.Rows)
            {
                if (row.DataBoundItem == null) { continue; }
                try
                {
                    PasteAction pa = row.DataBoundItem as PasteAction;
                    if (PasteAction.ReservedIDs.Contains(pa.ID))
                    {
                        row.Visible = false;
                    }

                }
                catch { }
            }
        }

        private void timer_ClipboardStatus_Tick(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if(dgv_Actions.SelectedRows.Count <= 0) { MessageBox.Show("No action is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if(dgv_LastApplications.SelectedRows.Count <= 0) { MessageBox.Show("No application is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            selectedPasteAction = dgv_Actions.SelectedRows[0].DataBoundItem as PasteAction;
            Classes.Application selectedApplication = dgv_LastApplications.SelectedRows[0].DataBoundItem as Classes.Application;

            if(selectedApplication.WindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("There is something wrong with the selected application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            selectedPasteAction.Paste(selectedApplication.WindowHandle, selectedApplication.LastActiveWindowMode);
        }

        private void dgv_Actions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Actions.SelectedRows.Count >= 1)
            {
                selectedPasteAction = dgv_Actions.SelectedRows[0].DataBoundItem as PasteAction;
            }
            else
            {
                selectedPasteAction = null;
            }

            UpdateControls();
        }

        private void dgv_Actions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ActionPicker_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void dgv_LastApplications_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}