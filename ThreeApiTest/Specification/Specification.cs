using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeApiTest.Specification
{
    public class Specification
    {
        protected static string HostPrefixOne = "https://swapi.dev/";
        protected static string HostPrefixTwo = "https://reqres.in";

        // метод Get
        protected IRestResponse GetMethod(string urlRequest, string host)
        {
            RestClient client = new RestClient(host);

            RestRequest request = new RestRequest(urlRequest, Method.GET);
            IRestResponse response = client.Get(request);
            return response;
        }

        // метод Post
        protected IRestResponse PostMethod(string urlRequest, string host, string payload)
        {
            RestClient client = new RestClient(host);

            RestRequest request = new RestRequest(urlRequest, Method.POST);
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            IRestResponse response = client.Post(request);

            return response;
        }

        protected int GetStatusCode(IRestResponse response)
        {
            int statusCode = (int)response.StatusCode;
            return statusCode;
        }

        protected int StatusCode200()
        {
            return 200;
        }

        protected int StatusCode201()
        {
            return 201;
        }

    }
}
