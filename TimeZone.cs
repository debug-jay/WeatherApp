using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinApp
{
    public class TimeZone
    {
        public class timezone
        {
            [JsonProperty(PropertyName = "timezone_abbr")]
            public string timezone_abbr { get; set; }
        }

        public class root
        {
            public timezone timezone { get; set; }
        }
    }
}
