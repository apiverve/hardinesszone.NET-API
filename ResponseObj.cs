using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Details data
    /// </summary>
    public class Details
    {
        [JsonProperty("tempRange")]
        public string TempRange { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("plantSurvival")]
        public string PlantSurvival { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("tempRange")]
        public string TempRange { get; set; }

        [JsonProperty("zoneTitle")]
        public string ZoneTitle { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
