using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThreeApiTest.ListOfUsers
{
    public partial class ListOfUsers
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public List<Data.Data> Data { get; set; }

        [JsonProperty("support")]
        public Support.Support Support { get; set; }
    }
}
