using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.Registration
{
    public partial class Registration
    {
        public string name { get; set; }
        public string job { get; set; }

        public Registration(string email_, string password_)
        {
            name = email_;
            job = password_;
        }
    }
}
