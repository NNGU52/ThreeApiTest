using Newtonsoft.Json;
using NUnit.Framework;
using System;
using ThreeApiTest.Specification;

namespace ThreeApiTest
{
    [TestFixture]

    public class Tests : Specification.Specification
    {

        [TestCase]
        public void ListOfLinks()
        {
            var response = GetMethod("api/people/1/", HostPrefixOne);
            Assert.AreEqual(StatusCode200(), GetStatusCode(response), "Error statusCode");

            var content = response.Content;
            var characteristic = JsonConvert.DeserializeObject<HumanCharacteristic.HumanCharacteristic>(content);

            // вывод в консоль список ссылок на фильмы
            for (int i = 0; i < characteristic.films.Length; i++)
            {
                Console.WriteLine(characteristic.films[i]);
            }
        }

        [TestCase]
        public void DisplayEmail()
        {
            var response = GetMethod("api/users?page=2", HostPrefixTwo);
            Assert.AreEqual(StatusCode200(), GetStatusCode(response), "Error statusCode");

            var content = response.Content;
            var users = JsonConvert.DeserializeObject<ListOfUsers.ListOfUsers>(content);

            for (int i = 0; i < users.data.Count; i++)
            {
                if (users.data[i].first_name == "George" && users.data[i].last_name == "Edwards")
                {
                    // вывод в консоль email пользователя
                    Console.WriteLine(users.data[i].email);
                }
            }
        }

        [TestCase]
        public void Registration()
        {
            Registration.Registration reg = new Registration.Registration("morpheus", "leader");
            string json = JsonConvert.SerializeObject(reg);
            var response = PostMethod("api/users", HostPrefixTwo, json);
            var content = response.Content;
            var successfullyReg = JsonConvert.DeserializeObject<SuccessfullyRegistration.SuccessfullyRegistration>(content);

            Assert.AreEqual(StatusCode201(), GetStatusCode(response), "Error statusCode");
            Assert.IsNotNull(successfullyReg.id, "NULL");
        }
    }
}