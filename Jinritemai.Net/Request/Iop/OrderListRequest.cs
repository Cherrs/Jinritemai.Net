using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Iop
{
    public class OrderListRequest : IRequest
    {

        [JsonProperty("start_update_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartUpdateTime { get; set; }

        [JsonProperty("end_update_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndUpdateTime { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("distr_status")]
        public long DistrStatus { get; set; }

        [JsonProperty("start_distr_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDistrTime { get; set; }

        [JsonProperty("end_distr_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndDistrTime { get; set; }
        public string method { get; set; } = "iop.orderList";

        public string path { get; set; } = "/iop/orderList";
    }
}