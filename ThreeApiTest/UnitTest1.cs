using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ThreeApiTest
{
    [TestFixture]

    public class Tests
    {

        [TestCase]
        public void ListOfLinks()
        {
            Clients.ConnectSwapi connectSwapi = new Clients.ConnectSwapi();

            var response = connectSwapi.GetMethod(TestSettings.Resources.GetRequestSwapi);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Error statusCode");

            var content = response.Content;
            var characteristic = JsonConvert.DeserializeObject<HumanCharacteristic.HumanCharacteristic>(content);

            for (int i = 0; i < characteristic.Films.Count; i++)
            {
                Console.WriteLine(characteristic.Films[i]);
            }
        }

        [TestCase]
        public void DisplayEmail()
        {
            Clients.ConnectReqres connectReqres = new Clients.ConnectReqres();

            var response = connectReqres.GetMethod(TestSettings.Resources.GetRequestReqres);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Error statusCode");

            var content = response.Content;
            var users = JsonConvert.DeserializeObject<ListOfUsers.ListOfUsers>(content);

            var dataPerson = users.Data.First(x => x.FirstName == "George" && x.LastName == "Edwards");
            Console.WriteLine(dataPerson.Email);
        }

        [TestCase]
        public void Registration()
        {
            Clients.ConnectReqres connectReqres = new Clients.ConnectReqres();

            Registration.Registration reg = new Registration.Registration("morpheus", "leader");
            string json = JsonConvert.SerializeObject(reg);
            var response = connectReqres.PostMethod(TestSettings.Resources.PostRequestReqres, json);
            var content = response.Content;
            var successfullyReg = JsonConvert.DeserializeObject<SuccessfullyRegistration.SuccessfullyRegistration>(content);

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode, "Error statusCode");
            Assert.IsNotNull(successfullyReg.Id, "NULL");
        }
    }
}