using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class details
{
    [JsonProperty("tempRange")]
    public string tempRange { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("plantSurvival")]
    public string plantSurvival { get; set; }

}

public class data
{
    [JsonProperty("zipCode")]
    public string zipCode { get; set; }

    [JsonProperty("zone")]
    public string zone { get; set; }

    [JsonProperty("tempRange")]
    public string tempRange { get; set; }

    [JsonProperty("zoneTitle")]
    public string zoneTitle { get; set; }

    [JsonProperty("details")]
    public details details { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
