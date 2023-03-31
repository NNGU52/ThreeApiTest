using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.Clients
{
    class ConnectSwapi
    {
        RestClient client = new RestClient(TestSettings.Resources.SwapiUrl);

        // метод Get
        public IRestResponse GetMethod(string urlRequest)
        {
            RestRequest request = new RestRequest(urlRequest, Method.GET);
            IRestResponse response = client.Get(request);
            return response;
        }

    }
}
