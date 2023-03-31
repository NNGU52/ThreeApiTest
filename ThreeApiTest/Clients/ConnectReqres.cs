using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.Clients
{
    class ConnectReqres
    {
        RestClient client = new RestClient(TestSettings.Resources.ReqresUrl);

        // метод Get
        public IRestResponse GetMethod(string urlRequest)
        {
            RestRequest request = new RestRequest(urlRequest, Method.GET);
            IRestResponse response = client.Get(request);
            return response;
        }

        // метод Post
        public IRestResponse PostMethod(string urlRequest, string payload)
        {
            RestRequest request = new RestRequest(urlRequest, Method.POST);
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            IRestResponse response = client.Post(request);

            return response;
        }
    }
}
