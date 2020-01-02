using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Paster.Classes;
using IWshRuntimeLibrary;

namespace Paster
{
    public partial class frm_Settings : Form
    {

        Configuration configClone;
        public frm_Settings()
        {
            InitializeComponent();
            configClone = Global.Configuration.Clone();
            UpdateControls();
        }

        private void UpdateControls()
        {
            chk_StartWithWindows.Checked = configClone.AutoStart;
            chk_StartMinimized.Checked = configClone.StartMinimized;
        }

        private void btn_OpenConfigFile_Click(object sender, EventArgs e)
        {
            Global.OpenActionsFile();
        }

        private void btn_ResetDefault_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the settings?", "Reset settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Global.ResetActions();
            }
        }

        private void chk_StartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            configClone.AutoStart = chk_StartWithWindows.Checked;
        }

        private void chk_StartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            configClone.StartMinimized = chk_StartMinimized.Checked;
        }

        private void btn_OpenConfigurationFile_Click(object sender, EventArgs e)
        {
            Global.OpenConfigurationFile();
        }

        private void btn_OpenActionsFile_Click(object sender, EventArgs e)
        {
            Global.OpenActionsFile();
        }

        private void btn_ResetDefaultConfiguration_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the settings?", "Are your sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Global.ResetActions();
            }
        }

        private void btn_ResetActionsDefault_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the actions?", "Are your sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Global.ResetActions();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Global.Configuration = configClone;
            Global.SaveConfiguration();
            Global.EnforceConfiguration();
            this.Close();
        }
    }
}
