using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Paster.Classes;


namespace Paster.Classes
{
    public class PasteAction
    {
        public enum Action
        {
            None,
            AutoType,
            Paste
        }

        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pastingaction")]
        public Action PastingAction { get; set; }
        [JsonProperty("replacenewline")]
        public bool ReplaceNewline { get; set; }
        [JsonProperty("clearclipboard")]
        public bool ClearClipboard { get; set; }
        [JsonProperty("splitstring")]
        public string Split { get; set; }
        [JsonProperty("entrytext")]
        public string EntryText { get; set; }
        [JsonProperty("endtext")]
        public string EndText { get; set; }
        [JsonProperty("hotkey")]
        public WindowsHelper.Hotkey Hotkey { get; set; }
        [JsonIgnore]
        public int? HotKeyRegistrationID { get; set; }


        public PasteAction()
        {
            this.ID = Guid.NewGuid().ToString();
            this.PastingAction = Action.AutoType;
        }

        public PasteAction(
            string ID,
            string Name,
            Action PastingAction,
            bool ReplaceNewlineWithEntryText,
            bool ClearClipboardAfterPaste,
            string Split,
            string EntryText, string EndText,
            WindowsHelper.Hotkey Hotkey)
        {
            this.ID = ID;
            this.Name = Name;
            this.PastingAction = PastingAction;
            this.ReplaceNewline = ReplaceNewlineWithEntryText;
            this.ClearClipboard = ClearClipboardAfterPaste;
            this.Split = Split;
            this.EntryText = EntryText;
            this.EndText = EndText;
            this.Hotkey = Hotkey;
        }

        public static List<string> ReservedIDs = new List<string>
        {
            "{00000000-0000-0000-0000-000000000000}",
            "{00000000-0000-0000-0000-000000000001}"
        };

        /// <summary>
        /// Validate that a paste action is OK, could be used before saving
        /// </summary>
        /// <param name="PasteAction"></param>
        /// <returns></returns>
        public static bool ValidateData(PasteAction PasteAction)
        {
            if(string.IsNullOrEmpty(PasteAction.Name)) { return false; }
            foreach(PasteAction action in Global.Actions)
            {
                if(PasteAction.ID == action.ID) { continue; }
                if(action.Hotkey == null) { continue; }
                if(PasteAction.Hotkey == null) { continue; }
                if(PasteAction.Hotkey.Modifiers == action.Hotkey.Modifiers && PasteAction.Hotkey.Key == action.Hotkey.Key)
                {
                    return false;
                }
            }
            return true;
        }

        public PasteAction Clone()
        {
            return (PasteAction)this.MemberwiseClone();
        }

        private class LineReplacement{
            public int IndexToReplace = 0;
            public List<string> Entries = new List<string>();
        }
        public async void Paste(IntPtr WindowHandle, Application.WindowState State)
        {
            // Initial validation
            if(WindowHandle == null || WindowHandle == IntPtr.Zero) { return; } // If the provided window handle is null or zero
            if (!Clipboard.ContainsText()) { return; }                          // If the clipboard does not contains text

            // Array for storing all clipboarddata (Some software like Devolutions RDM sometimes store data in a kind of Clipboard-stack)
            List<string> ClipboardArray = new List<string>();

            // Get all available clipboard data into the clipboard array
            for (int i = 0; i <= 24; i++)
            {
                string clipboardText = Clipboard.GetText();
                if(!ClipboardArray.Contains(clipboardText)) { ClipboardArray.Add(clipboardText); }
                else { break; }
                await Task.Delay(25);
            }

            // Split the clipboard entries on new line of configured
            if(this.ReplaceNewline)
            {
                List<string> NewData = new List<string>();
                foreach(string line in ClipboardArray)
                {
                    if(!line.Contains(Environment.NewLine)) { NewData.Add(line); }
                    else
                    {
                        string[] entries = line.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                        foreach(string entry in entries)
                        {
                            NewData.Add(entry);
                        }
                    }
                }
                ClipboardArray = NewData;
            }

            if (!string.IsNullOrEmpty(this.Split))
            {
                List<string> NewData = new List<string>();
                foreach (string line in ClipboardArray)
                {
                    if (!line.Contains(this.Split)) { NewData.Add(line); }
                    else
                    {
                        string[] entries = line.Split(new[] { this.Split }, StringSplitOptions.None);
                        foreach (string entry in entries)
                        {
                            NewData.Add(entry);
                        }
                    }
                }
                ClipboardArray = NewData;
            }

            // Create the output string to type
            string Output = "";
            foreach(string entry in ClipboardArray)
            {
                Output += entry + this.EntryText;
            }
            if(!string.IsNullOrEmpty(this.EntryText))
            {
                if (Output.EndsWith(this.EntryText + this.EntryText))
                {
                    Output = Output.Substring(0, Output.LastIndexOf(this.EntryText));
                }
            }
            if(!string.IsNullOrEmpty(this.EndText)) { Output += this.EndText; } // Add the end text

            WindowsHelper.SetForegroundWindow(WindowHandle);
            if(State == Application.WindowState.Maximized)
            {
                WindowsHelper.ShowWindowAsync(WindowHandle, (int)WindowsHelper.ShowWindowEnum.ShowMaximized); // Keep the window maximized if it already is
            } 
            else
            {
                WindowsHelper.ShowWindowAsync(WindowHandle, (int)WindowsHelper.ShowWindowEnum.ShowNormal); // Open minizmized windows and keep normal windows normal
            }
            
            await Task.Delay(150);
            if(this.PastingAction == Action.AutoType)
            {
                SendKeys.SendWait(Output);
            }
            else if(this.PastingAction == Action.Paste)
            {
                Clipboard.SetText(Output);
                SendKeys.Send("^v");
            }
            

            if(this.ClearClipboard) {
                Clipboard.Clear(); 
            }
        }

    }
}
