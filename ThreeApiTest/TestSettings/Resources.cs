using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.TestSettings
{
    static class Resources
    {
        static public string SwapiUrl = "https://swapi.dev/";
        static public string ReqresUrl = "https://reqres.in";

        static public string GetRequestSwapi = "api/people/1/";
        static public string GetRequestReqres = "api/users?page=2";
        static public string PostRequestReqres = "api/users";
    }
}
