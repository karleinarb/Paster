using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paster.Classes;
using Newtonsoft.Json;

namespace Paster.Classes
{
    public class Configuration
    {
        [JsonProperty("autostart")] public bool AutoStart { get; set; }

        [JsonProperty("startminimized")] public bool StartMinimized { get; set; }

        public Configuration()
        {

        }

        public Configuration(bool AutoStart, bool StartMinimized)
        {
            this.AutoStart = AutoStart;
            this.StartMinimized = StartMinimized;
        }

        public Configuration Clone()
        {
            return (Configuration)this.MemberwiseClone();
        }
    }
}
