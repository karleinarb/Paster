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
    public partial class frm_ActionEditor : Form
    {

        bool isNew;
        public PasteAction ExistingAction;
        public PasteAction PasteAction;

        public frm_ActionEditor()
        {
            InitializeComponent();
            this.isNew = true;
            this.PasteAction = new PasteAction();
            updateControls();
        }

        public frm_ActionEditor(PasteAction PasteAction)
        {
            InitializeComponent();
            this.isNew = false;
            this.ExistingAction = PasteAction;
            this.PasteAction = PasteAction.Clone(); // Make a clone to change and validate before overwriting the reference object

            SetControlsFromPasteAction();
            updateControls();
            
        }

        private void updateControls()
        {
            if (PasteAction.ReservedIDs.Contains(this.PasteAction.ID))
            {
                grp_General.Enabled = false;
                grp_Paste.Enabled = false;
            }
            else
            {
                radio_None.Visible = false;
                radio_None.Enabled = false;
            }
        }

        private void SetPasteActionFromControls(PasteAction action)
        {
            action.Name = txt_Name.Text;
            action.ReplaceNewline = chk_ConvertNLToEntry.Checked;
            action.ClearClipboard = chk_ClearClipboard.Checked;
            action.Split = txt_Split.Text;
            action.EntryText = txt_EntryText.Text;
            action.EndText = txt_EndText.Text;
            action.DelayMS = (int)num_DelayMS.Value;
            action.Hotkey = PasteAction.Hotkey;

            if(radio_None.Checked) { action.PastingAction = PasteAction.Action.None; }
            else if(radio_Autotype.Checked) { action.PastingAction = PasteAction.Action.AutoType; }
            else if(radio_Paste.Checked) { action.PastingAction = PasteAction.Action.Paste; }
        }

        private void SetControlsFromPasteAction()
        {
            txt_Name.Text = this.PasteAction.Name;
            chk_ConvertNLToEntry.Checked = this.PasteAction.ReplaceNewline;
            chk_ClearClipboard.Checked = this.PasteAction.ClearClipboard;
            txt_Split.Text = this.PasteAction.Split;
            txt_EntryText.Text = this.PasteAction.EntryText;
            txt_EndText.Text = this.PasteAction.EndText;
            num_DelayMS.Value = this.PasteAction.DelayMS;
            if(this.PasteAction.Hotkey != null) { txt_Hotkey.Text = this.PasteAction.Hotkey.ToString(); }
            else { txt_Hotkey.Text = ""; }
            

            switch(this.PasteAction.PastingAction)
            {
                case PasteAction.Action.None:
                    radio_None.Checked = true;
                    break;
                case PasteAction.Action.AutoType:
                    radio_Autotype.Checked = true;
                    break;
                case PasteAction.Action.Paste:
                    radio_Paste.Checked = true;
                    break;
            }

        }

        private void ActionEditor_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChangeHotkey_Click(object sender, EventArgs e)
        {
            if(this.PasteAction.Hotkey == null)
            {
                using (frm_HotkeyEditor dialog = new frm_HotkeyEditor())
                {
                    dialog.ShowDialog();
                    if(dialog.Hotkey == null)
                    {
                        this.PasteAction.Hotkey = null;
                    } else
                    {
                        this.PasteAction.Hotkey = new WindowsHelper.Hotkey(dialog.Hotkey.Modifiers, dialog.Hotkey.Key);
                    }
                    
                }
            } 
            else
            {
                using (frm_HotkeyEditor dialog = new frm_HotkeyEditor(this.PasteAction.Hotkey))
                {
                    dialog.ShowDialog();
                    if (dialog.Hotkey == null)
                    {
                        this.PasteAction.Hotkey = null;
                    }
                    else
                    {
                        this.PasteAction.Hotkey = new WindowsHelper.Hotkey(dialog.Hotkey.Modifiers, dialog.Hotkey.Key);
                    }
                }
            }
            SetControlsFromPasteAction();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SetPasteActionFromControls(this.PasteAction);
            if (PasteAction.ValidateData(this.PasteAction))
            {
                if(this.isNew)
                {
                    Global.Actions.Add(this.PasteAction);
                    Global.SaveActions();
                } else
                {
                    SetPasteActionFromControls(this.ExistingAction);
                    Global.SaveActions();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("One or more settings are not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openCommandInfo()
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.8#remarks");
        }

        private void pb_EntryInfo_Click(object sender, EventArgs e)
        {
            openCommandInfo();
        }

        private void pb_EndInfo_Click(object sender, EventArgs e)
        {
            openCommandInfo();
        }

        private void btn_ClearHotkey_Click(object sender, EventArgs e)
        {
            this.PasteAction.Hotkey = null;
            SetControlsFromPasteAction();
            updateControls();
        }
    }
}
