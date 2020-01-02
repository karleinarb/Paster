using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paster.Classes
{
    public class Application
    {
        public enum WindowState { Normal, Minimized, Maximized };
        public IntPtr WindowHandle { get; set; }
        public string WindowTitle { get; set; }
        private System.Drawing.Icon windowIcon;
        public System.Drawing.Icon WindowIcon { 
            get
            {
                if(windowIcon == null) { return Global.TransparentIcon; }
                return windowIcon;
            }
            set { windowIcon = value; }
        }
        public WindowState LastActiveWindowMode
        {
            get
            {
                if (WindowsHelper.IsIconic(this.WindowHandle))
                {
                    return WindowState.Minimized;
                }
                else if (WindowsHelper.IsZoomed(this.WindowHandle))
                {
                    return WindowState.Maximized;
                }
                else
                {
                    return WindowState.Normal;
                }
            }
        }
    }
}
