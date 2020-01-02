using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paster.Classes;
using System.Windows;
using System.Reflection;

namespace Paster
{
    public partial class frm_Main : Form
    {
        private Mutex _mutex;                           // Make sure there is only one running instance of the application
        private frm_ActionPicker ActionPicker = null;   // This is to make sure it will only be one action picker active at a time

        public frm_Main()
        {
            // Check if another instance of Paster is already running
            bool isNewInstance = false;
            _mutex = new Mutex(true, "Paster", out isNewInstance);
            GC.KeepAlive(_mutex);
            if(!isNewInstance) {
                Environment.Exit(0);
                return; 
            }

            InitializeComponent();
            Global.ThisWindowsHandle = this.Handle; // Get the window handle
            Global.LoadConfiguration();             // Load application configuration
            Global.LoadActions();                   // Load actions
            Global.RegisterActionHotkeys();         // Register Hotkeys
            if(Global.Configuration.StartMinimized) // Start minimized if configured
            {
                this.WindowState = FormWindowState.Minimized;
            }
            timer_ActiveWindow.Start();             // Start the timer for checking active windows
            notifyIcon.Visible = true;              // Make the tray-icon visible
            System.Windows.Forms.Application.ApplicationExit += Application_ApplicationExit;

            lbl_Version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            // Unregister all hotkeys
            foreach (PasteAction action in Global.Actions)
            {
                if (action.HotKeyRegistrationID != null)
                {
                    WindowsHelper.UnregisterHotKey(this.Handle, (int)action.HotKeyRegistrationID);
                }
            }
        }

        // Handle global hotkeys
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if(m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                WindowsHelper.KeyModifier modifier = (WindowsHelper.KeyModifier)((int)m.LParam & 0xFFFF);
                int id = m.WParam.ToInt32();

                PasteAction matchedAction = new PasteAction();
                foreach(PasteAction action in Global.Actions)
                {
                    if(action.HotKeyRegistrationID == id) { matchedAction = action; }
                }

                if(string.IsNullOrEmpty(matchedAction.Name))
                {
                    MessageBox.Show("No action is matched to that hotkey");
                    this.Close();
                    return;
                }

                if(matchedAction.ID == "{00000000-0000-0000-0000-000000000000}")
                {
                    openActionPicker();
                }
                else if(matchedAction.ID == "{00000000-0000-0000-0000-000000000001}")
                {
                    WindowsHelper.SetForegroundWindow(this.Handle);
                    WindowsHelper.ShowWindowAsync(this.Handle, 1);
                }
                else
                {
                    matchedAction.Paste(Global.LastApplications[0].WindowHandle, Global.LastApplications[0].LastActiveWindowMode);
                }
            }
        }

        private void openActionPicker()
        {
            if(this.ActionPicker == null)
            {
                this.Activate();
                this.ActionPicker = new frm_ActionPicker();
                this.ActionPicker.WindowState = FormWindowState.Normal;
                this.ActionPicker.ShowDialog();
                this.ActionPicker = null;
            } else
            {
                this.ActionPicker.WindowState = FormWindowState.Normal;
                this.ActionPicker.Activate();
            }
        }

        private void timer_ActiveWindow_Tick(object sender, EventArgs e)
        {
            IntPtr handle = WindowsHelper.GetForegroundWindow();                        // Get the process ID of the current active windows handle
            if(handle == null) { return; }                                              // Return if no handle is found
            if (handle == Global.ThisWindowsHandle) { return; }                         // Return if the handle is the paster application handle
            if (handle == Global.LastActiveWindowHandle) { return; }                    // Return if the handle is the same as the last handle

            Global.LastActiveWindowHandle = handle;                                     // Set the last active windows handle

            // Check if the application already exists
            Classes.Application existingApplication = null;                                                  
            foreach (Classes.Application appl in Global.LastApplications)               
            {
                if (appl.WindowHandle == handle) { existingApplication = appl; }
            }

            // Re-order if applicable
            if (existingApplication != null)
            {
                Global.LastApplications.Remove(existingApplication);
                Global.LastApplications.Insert(0, existingApplication);
                return;
            }

            // Return if the application title is one of the paster application titles
            string title = WindowsHelper.GetWindowLabel(handle);
            if(Global.ExcludedTitles.Contains(title)) { return; }
            if(string.IsNullOrEmpty(title)) { return; }             // Return if the title is empty

            // Add the new application
            Classes.Application app = new Classes.Application();
            app.WindowHandle = handle;
            app.WindowTitle = WindowsHelper.GetWindowLabel(app.WindowHandle); 
            app.WindowIcon = WindowsHelper.GetAppIcon(handle);

            // Remove the last application if it is 5 or more applications in the list
            if (Global.LastApplications.Count >= 5) { Global.LastApplications.RemoveAt(Global.LastApplications.Count - 1); }
            Global.LastApplications.Insert(0, app);
        }

        private void btn_SetupHotkeys_Click(object sender, EventArgs e)
        {
            using(frm_Actions dialog = new frm_Actions())
            {
                dialog.ShowDialog();
            }
        }

        private void btn_Paste_Click(object sender, EventArgs e)
        {
            openActionPicker();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void frm_Main_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsmi_Open_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pb_Information_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/karleinarb/Paster");
        }

        private void pb_Settings_Click(object sender, EventArgs e)
        {
            using(frm_Settings dialog = new frm_Settings())
            {
                dialog.ShowDialog();
            }
        }

        private void pb_Settings_MouseHover(object sender, EventArgs e)
        {
            pb_Settings.BorderStyle = BorderStyle.FixedSingle;
            pb_Settings.Update();
        }

        private void pb_Settings_MouseLeave(object sender, EventArgs e)
        {
            pb_Settings.BorderStyle = BorderStyle.None;
            pb_Settings.Update();
        }

        private void pb_Information_MouseHover(object sender, EventArgs e)
        {
            pb_Information.BorderStyle = BorderStyle.FixedSingle;
            pb_Information.Update();
        }

        private void pb_Information_MouseLeave(object sender, EventArgs e)
        {
            pb_Information.BorderStyle = BorderStyle.None;
            pb_Information.Update();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
