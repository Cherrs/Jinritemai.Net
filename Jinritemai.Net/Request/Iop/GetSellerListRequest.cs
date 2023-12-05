using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jinritemai.Net.Iop
{

    public partial class GetSellerListRequest : IRequest
    {

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        [JsonProperty("bind_status")]
        public List<long> BindStatus { get; set; }
        public string method { get; set; } = "iop.getSellerList";
        public string path { get; set; } = "/iop/getSellerList";
    }
}