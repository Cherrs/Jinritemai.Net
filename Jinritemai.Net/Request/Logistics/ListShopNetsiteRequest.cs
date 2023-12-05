namespace Jinritemai.Net.Logistics
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ListShopNetsiteRequest
    {
        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("accessToken")]
        public Guid AccessToken { get; set; }

        [JsonProperty("logistics_code")]
        public string LogisticsCode { get; set; }
    }
}
