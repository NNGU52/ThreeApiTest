using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.HumanCharacteristic
{
    public partial class HumanCharacteristic
    {
        public string name { get; set; }
        public long height { get; set; }
        public long mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public Uri homeworld { get; set; }
        public Uri[] films { get; set; }
        public Uri[] species { get; set; }
        public Uri[] vehicles { get; set; }
        public Uri[] starships { get; set; }
        public DateTimeOffset created { get; set; }
        public DateTimeOffset edited { get; set; }
        public Uri url { get; set; }
    }
}
