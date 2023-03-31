using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.Registration
{
    public partial class Registration
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        public Registration(string name_, string job_)
        {
            Name = name_;
            Job = job_;
        }
    }
}
