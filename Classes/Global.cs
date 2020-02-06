using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Paster.Classes;
using System.ComponentModel;

namespace Paster.Classes
{
    static class Global
    {
        public static System.Drawing.Icon TransparentIcon = Icon.FromHandle(Properties.Resources.Transparent.GetHicon());

        public static List<string> ExcludedTitles = new List<string>                        // List of window titles that will be excluded from the application array
        {
            "Paster", "Action", "Actions", "Action Editor", "Hotkey Editor", "Settings"
        };

        public static string ApplicationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Paster");
        private static void CreateApplicationFolder()
        {
            try
            {
                if (!Directory.Exists(ApplicationFolder))        // Create the app data folder
                {
                    Directory.CreateDirectory(ApplicationFolder);
                }
            }
            catch { }
        }
        public static string ConfigurationFile = Path.Combine(ApplicationFolder, "Configuration.json");
        public static string ActionsFile = Path.Combine(ApplicationFolder, "Actions.json");

        public static Configuration Configuration = new Configuration();
        private static Configuration DefaultConfiguration = new Configuration(false, true);
        private static void CreateDefaultConfiguration()
        {
            CreateApplicationFolder();              // Create the applicationfolder if missing
            if (!File.Exists(ConfigurationFile))     // Create the default configuration file
            {
                string json = JsonConvert.SerializeObject(Global.DefaultConfiguration, Formatting.Indented);
                File.WriteAllText(ConfigurationFile, json);
                Global.Configuration = Global.DefaultConfiguration;
            }
        }
        public static void OpenConfigurationFile()
        {
            CreateDefaultConfiguration();
            System.Diagnostics.Process.Start(ConfigurationFile);
        }
        public static void LoadConfiguration()
        {
            CreateApplicationFolder();              // Create the applicationfolder if missing
            if(!File.Exists(ConfigurationFile))     // Create the default configuration file
            {
                CreateDefaultConfiguration();
            }
            else                                    // Load the configurations
            {
                Configuration config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(Global.ConfigurationFile));
                Global.Configuration = config;
            }
        }
        public static void SaveConfiguration()
        {
            CreateApplicationFolder();
            // Create the app data folder
            string json = JsonConvert.SerializeObject(Global.Configuration, Formatting.Indented);
            File.WriteAllText(Global.ConfigurationFile, json);
        }
        public static void EnforceConfiguration()
        {
            string FilePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutName = AppDomain.CurrentDomain.FriendlyName + ".lnk";
            string shortcutPath = Path.Combine(startupFolder, shortcutName);

            string existingShortcut = FindExistingShortcut(startupFolder, FilePath);

            if (Global.Configuration.AutoStart) //Create the link
            {
                if (string.IsNullOrEmpty(existingShortcut))
                {
                    try {
                        var shell = new IWshRuntimeLibrary.WshShell();
                        var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);
                        shortcut.TargetPath = FilePath;                 // The path of the file that will launch when the shortcut is run
                        shortcut.Save();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(existingShortcut))
                {
                    try { File.Delete(existingShortcut); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }
        public static void ResetConfiguration()
        {
            Global.Configuration = Global.DefaultConfiguration;
            Global.SaveConfiguration();
            Global.EnforceConfiguration();
        }

        public static string FindExistingShortcut(string folder, string filepath)
        {
            if (string.IsNullOrEmpty(folder)) { return null; }
            string[] shortcuts = Directory.GetFiles(folder);
            string foundShortCut = "";
            foreach (string shortcut in shortcuts)
            {
                if (!shortcut.ToUpper().EndsWith(".LNK")) { continue; } // Skip of not .LNK file

                var shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut link = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcut);

                if (link.TargetPath.ToUpper() == filepath.ToUpper()) { foundShortCut = shortcut; }
            }

            return foundShortCut;
        }

        private static List<PasteAction> _actions = new List<PasteAction>();

        private static List<PasteAction> DefaultActions = new List<PasteAction>
        {
            new PasteAction("{00000000-0000-0000-0000-000000000001}",
                    "Open Paster",
                    PasteAction.Action.None,
                    false,
                    false,
                    "",
                    "",
                    "",
                    0,
                    null
                ),
            new PasteAction("{00000000-0000-0000-0000-000000000000}",
                    "Open Action Picker",
                    PasteAction.Action.None,
                    false,
                    false,
                    "",
                    "",
                    "",
                    0,
                    new WindowsHelper.Hotkey((int)WindowsHelper.KeyModifier.Alt + WindowsHelper.KeyModifier.Control, Keys.Q)
                ),
                new PasteAction("{CEC8C6FF-FDEF-4301-90A0-D367CDD561DB}",
                    "Autotype clipboard",
                    PasteAction.Action.AutoType,
                    false,
                    false,
                    "",
                    "",
                    "",
                    0,
                    new WindowsHelper.Hotkey((int)WindowsHelper.KeyModifier.Alt + WindowsHelper.KeyModifier.Control, Keys.W)
                ),
                new PasteAction("{18E870FA-B43E-4E8C-9966-A63B4BCD7D3C}",
                    "Login Username and Password",
                    PasteAction.Action.AutoType,
                    true,
                    true,
                    "",
                    "{TAB}",
                    "{ENTER}",
                    0,
                    new WindowsHelper.Hotkey((int)WindowsHelper.KeyModifier.Alt + WindowsHelper.KeyModifier.Control, Keys.E)
                )
    };
        public static IntPtr ThisWindowsHandle {get;set;}

        public static List<PasteAction> Actions {
            get { return _actions; }
            set { _actions = value; }
        }

        // List of all latest applications
        private static BindingList<Application> _LastApplications = new BindingList<Application>();
        public static BindingList<Application> LastApplications
        {
            get { return _LastApplications; }
            set
            {
                _LastApplications = value;
            }
        }
        

        private static IntPtr _lastActiveWindowHandle;
        public static event EventHandler OnLastActiveWindowHandleChanged;
        public static IntPtr LastActiveWindowHandle
        {
            get { return _lastActiveWindowHandle; }
            set {
                _lastActiveWindowHandle = value;
                EventHandler tmp = OnLastActiveWindowHandleChanged;
                if (tmp != null)
                    OnLastActiveWindowHandleChanged.Invoke(Global.LastActiveWindowHandle, new EventArgs());

            }
        }

        private static Icon _lastActiveWindowIcon;
        public static event EventHandler OnLastActiveWindowIconChanged;
        public static Icon LastActiveWindowIcon
        {
            get { return _lastActiveWindowIcon; }
            set {
                _lastActiveWindowIcon = value;
                EventHandler tmp = OnLastActiveWindowIconChanged;
                if (tmp != null)
                    OnLastActiveWindowIconChanged.Invoke(null, null);
            }
        }

        private static string _lastActiveWindowTitle = "";
        public static event EventHandler OnLastActiveWindowTitleChanged;
        public static string LastActiveWindowTitle
        {
            get { return _lastActiveWindowTitle; }
            set {
                _lastActiveWindowTitle = value;
                EventHandler tmp = OnLastActiveWindowTitleChanged;
                if (tmp != null)
                    OnLastActiveWindowTitleChanged.Invoke(null, null);
            }
        }

        public enum WindowState { Normal, Minimized, Maximized };

        public static WindowState LastActiveWindowMode
        {
            get
            {
                if (WindowsHelper.IsIconic(Global.LastActiveWindowHandle))
                {
                    return WindowState.Minimized;
                }
                else if (WindowsHelper.IsZoomed(Global.LastActiveWindowHandle))
                {
                    return WindowState.Maximized;
                }
                else
                {
                    return WindowState.Normal;
                }
            }
        }

        public static int CurrentHotkeyID {
            get; set;
        }

        public static void RegisterActionHotkeys()
        {
            foreach (PasteAction action in Global.Actions)
            {
                // Unregister existing hotkeybinding if already present
                if(action.HotKeyRegistrationID != null) 
                { 
                    WindowsHelper.UnregisterHotKey(ThisWindowsHandle, (int)action.HotKeyRegistrationID);
                    action.HotKeyRegistrationID = null;
                }
                // Check if hotkey is valid
                if (action.Hotkey == null) { continue; }     //Skip if no hotkey
                if(!action.Hotkey.Validate()) { continue; } //Skip if hotkey is invalid

                // Register the new hotkey binding
                WindowsHelper.RegisterHotKey(ThisWindowsHandle, Global.CurrentHotkeyID, (int)action.Hotkey.Modifiers, action.Hotkey.Key.GetHashCode());
                action.HotKeyRegistrationID = Global.CurrentHotkeyID;
                Global.CurrentHotkeyID++;
            }
        }

        public static void UnregisterActionHotkeys()
        {
            foreach (PasteAction action in Global.Actions)
            {
                if (action.HotKeyRegistrationID != null)
                {
                    WindowsHelper.UnregisterHotKey(Global.ThisWindowsHandle, (int)action.HotKeyRegistrationID);
                }
            }
        }

        private static void CreateDefaultActions()
        {
            CreateApplicationFolder();         // Create the applicationfolder if missing
            if (!File.Exists(ActionsFile))     // Create the default configuration file
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Global.DefaultActions, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ActionsFile, json);
            }
        }

        public static void OpenActionsFile()
        {
            CreateDefaultActions();
            System.Diagnostics.Process.Start(ActionsFile);
        }

        public static void LoadActions()
        {
            CreateApplicationFolder();
            if (!File.Exists(ActionsFile))     // Create the default configuration file
            {
                CreateDefaultActions();
            }
            else
            {
                List<PasteAction> ConfigActions = JsonConvert.DeserializeObject<List<PasteAction>>(File.ReadAllText(ActionsFile));
                Global.Actions = ConfigActions;
            }
        }

        public static void SaveActions()
        {
            CreateApplicationFolder();
            // Create the app data folder
            string json = JsonConvert.SerializeObject(Global.Actions, Formatting.Indented);
            File.WriteAllText(Global.ActionsFile, json);
        }

        public static void ResetActions()
        {
            Global.UnregisterActionHotkeys();
            if(File.Exists(Global.ActionsFile)) { File.Delete(Global.ActionsFile); }
            CreateDefaultConfiguration();
            LoadConfiguration();
            RegisterActionHotkeys();
        }
    }
}
