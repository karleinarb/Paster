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
    public partial class frm_HotkeyEditor : Form
    {

        private bool isNew = false;
        private WindowsHelper.Hotkey existingHotkey;
        public WindowsHelper.Hotkey Hotkey;
        private List<Keys> availableKeys = new List<Keys>();
        private List<Keys> standardKeys = new List<Keys>
            {
                Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.G, Keys.H, Keys.I, Keys.J, Keys.K,Keys.L, Keys.M,
                Keys.N, Keys.O, Keys.P, Keys.Q, Keys.R, Keys.S, Keys.T, Keys.U, Keys.V, Keys.W, Keys.X, Keys.Y, Keys.Z,
                Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
                Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8,
                Keys.NumPad9, Keys.Multiply, Keys.Add, Keys.Subtract, Keys.Decimal, Keys.Divide,
                Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12,
                Keys.F13, Keys.F14, Keys.F15, Keys.F16, Keys.F17, Keys.F18, Keys.F19, Keys.F20, Keys.F21, Keys.F22, Keys.F23, Keys.F24,
                Keys.Insert, Keys.Delete, Keys.Home, Keys.End, Keys.PageUp, Keys.PageDown,
                Keys.Up, Keys.Down, Keys.Left, Keys.Right
            };
        private List<Keys> unavailableKeys = new List<Keys>
            {
                Keys.None,
                Keys.LButton,
                Keys.RButton,
                Keys.Cancel,
                Keys.MButton,
                Keys.XButton1,
                Keys.XButton2,
                Keys.Back,
                Keys.Tab,
                Keys.LineFeed,
                Keys.Clear,
                Keys.Enter,
                Keys.ShiftKey,
                Keys.ControlKey,
                Keys.Menu,
                Keys.Pause,
                Keys.Capital,
                Keys.KanaMode, Keys.JunjaMode, Keys.FinalMode, Keys.HanjaMode,
                Keys.Escape,
                Keys.IMEConvert, Keys.IMENonconvert, Keys.IMEAceept, Keys.IMEAccept, Keys.IMEModeChange,
                Keys.Select,
                Keys.Print,
                Keys.Execute,
                Keys.PrintScreen,
                Keys.Help,
                Keys.LWin, Keys.RWin,
                Keys.Apps,
                Keys.Sleep,
                Keys.Separator,
                Keys.NumLock,
                Keys.Scroll,
                Keys.LShiftKey, Keys.RShiftKey, Keys.LControlKey, Keys.RControlKey, Keys.LMenu, Keys.RMenu,
                Keys.BrowserBack, Keys.BrowserForward, Keys.BrowserRefresh, Keys.BrowserStop, Keys.BrowserSearch, Keys.BrowserFavorites, Keys.BrowserHome,
                Keys.VolumeMute, Keys.VolumeDown, Keys.VolumeUp,
                Keys.MediaNextTrack, Keys.MediaPreviousTrack, Keys.MediaStop, Keys.MediaPlayPause,
                Keys.LaunchMail, Keys.SelectMedia, Keys.LaunchApplication1, Keys.LaunchApplication2,
                Keys.ProcessKey, Keys.Packet, Keys.Attn, Keys.Crsel, Keys.Exsel, Keys.EraseEof, Keys.NoName, Keys.Pa1,
                Keys.KeyCode,
                ((int)Keys.Shift + Keys.None), ((int)Keys.Control + Keys.None), ((int)Keys.Alt + Keys.None),
            };
        private List<Keys> advancedKeys = new List<Keys>();

        public frm_HotkeyEditor()
        {
            InitializeComponent();
            isNew = true;
            populateCharacterCombobox();
            this.Hotkey = new WindowsHelper.Hotkey();
            combo_Character.DataSource = availableKeys;
            UpdateControls();
        }

        public frm_HotkeyEditor(WindowsHelper.Hotkey Hotkey)
        {
            InitializeComponent();
            isNew = false;
            populateCharacterCombobox();
            this.existingHotkey = Hotkey;
            this.Hotkey = Hotkey.Clone();
            
            combo_Character.DataSource = availableKeys;
            UpdateControls();
        }

        private void populateCharacterCombobox()
        {
            foreach(Keys key in standardKeys)
            {
                if(availableKeys.Contains(key)) { continue; }
                availableKeys.Add(key);
            }

            // Create list of advanced keys
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (standardKeys.Contains(key)) { continue; }
                if (unavailableKeys.Contains(key)) { continue; }

                advancedKeys.Add(key);
            }

            if (chk_ShowAdvanced.Checked)
            {
                foreach(Keys key in advancedKeys)
                {
                    if(availableKeys.Contains(key)) { continue; }
                    availableKeys.Add(key);
                }
            } 
            else
            {
                foreach(Keys key in advancedKeys) { availableKeys.Remove(key); }
            }

            combo_Character.DataSource = null;
            combo_Character.DataSource = availableKeys;
        }

        private void UpdateControls()
        {
            chk_Alt.Checked = Hotkey.Modifiers.HasFlag(WindowsHelper.KeyModifier.Alt);
            chk_Control.Checked = Hotkey.Modifiers.HasFlag(WindowsHelper.KeyModifier.Control);
            chk_Shift.Checked = Hotkey.Modifiers.HasFlag(WindowsHelper.KeyModifier.Shift);

            if(advancedKeys.Contains(Hotkey.Key)) { chk_ShowAdvanced.Checked = true; }

            combo_Character.SelectedItem = Hotkey.Key;
        }

        private WindowsHelper.Hotkey GetHotkeyFromControls()
        {
            WindowsHelper.KeyModifier Modifiers = WindowsHelper.KeyModifier.None;
            if(chk_Alt.Checked) { Modifiers += (int)WindowsHelper.KeyModifier.Alt; }
            if (chk_Control.Checked) { Modifiers += (int)WindowsHelper.KeyModifier.Control; }
            if (chk_Shift.Checked) { Modifiers += (int)WindowsHelper.KeyModifier.Shift; }

            Keys key = (Keys)combo_Character.SelectedItem;

            return new WindowsHelper.Hotkey(Modifiers, key);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chk_ShowAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            populateCharacterCombobox();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            WindowsHelper.Hotkey Validator = GetHotkeyFromControls();
            if (Validator.Modifiers == WindowsHelper.KeyModifier.None || Validator.Key == Keys.None)
            {
                this.existingHotkey = null;
                this.Hotkey = null;
                this.Close();
                return;
            }
            if (!Validator.Validate())
            {
                MessageBox.Show("One or more settings is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isNew)
            {
                this.existingHotkey = GetHotkeyFromControls();
                this.Hotkey = GetHotkeyFromControls();
                this.Close();
            } else
            {
                this.Hotkey = GetHotkeyFromControls();
                this.Close();
            }
        }
    }
}
