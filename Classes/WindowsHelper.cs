using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Paster.Classes
{
    public static class WindowsHelper
    {
        #region ICON
        const int GCL_HICONSM = -34;
        const int GCL_HICON = -14;

        const int ICON_SMALL = 0;
        const int ICON_BIG = 1;
        const int ICON_SMALL2 = 2;

        const int WM_GETICON = 0x7F;

        static IntPtr GetClassLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size > 4)
                return GetClassLongPtr64(hWnd, nIndex);
            else
                return new IntPtr(GetClassLongPtr32(hWnd, nIndex));
        }

        [DllImport("user32.dll", EntryPoint = "GetClassLong")]
        static extern uint GetClassLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetClassLongPtr")]
        static extern IntPtr GetClassLongPtr64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public static Icon GetAppIcon(IntPtr hwnd)
        {
            try
            {
                IntPtr iconHandle = SendMessage(hwnd, WM_GETICON, ICON_SMALL2, 0);
                if (iconHandle == IntPtr.Zero)
                    iconHandle = SendMessage(hwnd, WM_GETICON, ICON_SMALL, 0);
                if (iconHandle == IntPtr.Zero)
                    iconHandle = SendMessage(hwnd, WM_GETICON, ICON_BIG, 0);
                if (iconHandle == IntPtr.Zero)
                    iconHandle = GetClassLongPtr(hwnd, GCL_HICON);
                if (iconHandle == IntPtr.Zero)
                    iconHandle = GetClassLongPtr(hwnd, GCL_HICONSM);
                if (iconHandle == IntPtr.Zero)
                    return null;

                Icon icn = Icon.FromHandle(iconHandle);

                return icn;
            } catch
            {
                return null;
            }
        }
        #endregion

        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        public enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };

        [DllImport("user32.dll")] public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")] private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        public static string GetWindowLabel(IntPtr hWnd)
        {
            const int nChars = 256;                             // Buffersize for reading text
            StringBuilder Buff = new StringBuilder(nChars);     // StringBuild object
            GetWindowText(hWnd, Buff, nChars);                  // Write the windows text to the buffer

            return Buff.ToString();                             // Return the text from the buffer
        }
        [DllImport("user32.dll")] public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")] public static extern int SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll")] public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);
        [DllImport("user32.dll")] public static extern bool IsZoomed(IntPtr hWnd);
        [DllImport("user32.dll")][return: MarshalAs(UnmanagedType.Bool)] public static extern bool IsIconic(IntPtr hWnd);

        //
        // Hotkeys
        //
        public enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        public class Hotkey
        {
            [JsonProperty("modifiers")]
            public KeyModifier Modifiers { get; set; }
            [JsonProperty("key")]
            public Keys Key { get; set; }

            public Hotkey() {
            }

            public Hotkey(KeyModifier Modifiers, Keys Key)
            {
                this.Modifiers = Modifiers;
                this.Key = Key;
            }

            public bool Validate()
            {
                if(this.Modifiers == KeyModifier.None) { return false; }
                if(this.Key == Keys.None) { return false; }

                return true;
            }

            public override string ToString()
            {
                string returnString = "";

                if (this.Modifiers.HasFlag(KeyModifier.Control)) { returnString += "Control + "; }
                if (this.Modifiers.HasFlag(KeyModifier.Shift)) { returnString += "Shift + "; }
                if (this.Modifiers.HasFlag(KeyModifier.Alt)) { returnString += "Alt + "; }
                if(this.Key != Keys.None) { returnString += this.Key.ToString() + " + "; }

                if(returnString.Contains(" + "))
                {
                    returnString = returnString.Substring(0, returnString.LastIndexOf(" + "));
                }

                return returnString;
            }

            public Hotkey Clone()
            {
                return (Hotkey)this.MemberwiseClone();
            }
        }
        [DllImport("user32.dll")] public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")] public static extern bool UnregisterHotKey(IntPtr hWnd, int id);


    }
}
