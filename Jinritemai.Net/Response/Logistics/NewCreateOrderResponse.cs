namespace Jinritemai.Net.Logistics
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public partial class NewCreateOrderResponse
    {
        [JsonProperty("ebill_infos")]
        public List<EbillInfo> EbillInfos { get; set; }

        [JsonProperty("err_infos")]
        public List<ErrInfo> ErrInfos { get; set; }
    }

    public partial class EbillInfo
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("extra_resp")]

        public long ExtraResp { get; set; }

        [JsonProperty("hint_msg")]
        public string HintMsg { get; set; }

        [JsonProperty("order_channel")]
        public string OrderChannel { get; set; }

        [JsonProperty("order_id")]

        public long OrderId { get; set; }

        [JsonProperty("pack_id")]

        public long PackId { get; set; }

        [JsonProperty("package_center_code")]

        public long PackageCenterCode { get; set; }

        [JsonProperty("package_center_name")]

        public long PackageCenterName { get; set; }

        [JsonProperty("shipping_code")]

        public long ShippingCode { get; set; }

        [JsonProperty("short_address_code")]

        public long ShortAddressCode { get; set; }

        [JsonProperty("short_address_name")]

        public long ShortAddressName { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }

        [JsonProperty("sub_waybill_codes")]
        public string SubWaybillCodes { get; set; }

        [JsonProperty("track_no")]

        public long TrackNo { get; set; }
    }

    public partial class ErrInfo
    {
        [JsonProperty("err_code")]

        public long ErrCode { get; set; }

        [JsonProperty("err_msg")]
        public string ErrMsg { get; set; }

        [JsonProperty("order_channel")]

        public long OrderChannel { get; set; }

        [JsonProperty("order_id")]

        public long OrderId { get; set; }

        [JsonProperty("pack_id")]

        public long PackId { get; set; }
    }
}
