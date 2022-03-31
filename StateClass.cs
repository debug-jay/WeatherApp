using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinApp
{
    public class StateClass
    {

        public class places
        {
            [JsonProperty(PropertyName = "state abbreviation")]
            public string state_abbreviaton { get; set; }
        }

        public class root
        {
            [JsonProperty(PropertyName = "country abbreviation")]
            public string country_abbreviation { get; set; }

            public List<places> places { get; set; }

        }




    }
}
