namespace Jinritemai.Net.Iop
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetSellerListResponse
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        [JsonProperty("seller_shop_list")]
        public List<SellerShopList> SellerShopList { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public partial class SellerShopList
    {
        [JsonProperty("apply_time")]
        public long ApplyTime { get; set; }

        [JsonProperty("band_time")]
        public long BandTime { get; set; }

        [JsonProperty("bind_status")]
        public long BindStatus { get; set; }

        [JsonProperty("refuse_time")]
        public long RefuseTime { get; set; }

        [JsonProperty("seller_shop_id")]
        public long SellerShopId { get; set; }

        [JsonProperty("seller_shop_name")]
        public string SellerShopName { get; set; }
    }
}
