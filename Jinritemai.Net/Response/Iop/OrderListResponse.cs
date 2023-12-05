using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Jinritemai.Net.Iop
{
    public class OrderListResponse
    {
        [JsonProperty("order_list")]
        public List<OrderList> OrderList { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public class OrderList
    {
        [JsonProperty("aftersale_status")]

        public long AftersaleStatus { get; set; }

        [JsonProperty("buyer_words")]

        public long BuyerWords { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_id")]

        public long CityId { get; set; }

        [JsonProperty("distr_cancel_reason")]
        public string DistrCancelReason { get; set; }

        [JsonProperty("distr_order_id")]
        public string DistrOrderId { get; set; }

        [JsonProperty("distr_status")]

        public long DistrStatus { get; set; }

        [JsonProperty("distr_time")]

        public long DistrTime { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("district_id")]

        public long DistrictId { get; set; }

        [JsonProperty("exp_ship_time")]

        public long ExpShipTime { get; set; }

        [JsonProperty("out_sku_id")]
        public string OutSkuId { get; set; }

        [JsonProperty("pack_list")]
        public List<PackList> PackList { get; set; }

        [JsonProperty("product_count")]

        public long ProductCount { get; set; }

        [JsonProperty("product_id")]

        public long ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_price")]

        public long ProductPrice { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("province_id")]

        public long ProvinceId { get; set; }

        [JsonProperty("receiver_id")]
        public string ReceiverId { get; set; }

        [JsonProperty("seller_words")]
        public string SellerWords { get; set; }

        [JsonProperty("serial_number_list")]
        public string SerialNumberList { get; set; }

        [JsonProperty("ship_time")]

        public long ShipTime { get; set; }

        [JsonProperty("sku_spec")]
        public string SkuSpec { get; set; }

        [JsonProperty("spec")]
        public List<Spec> Spec { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street_id")]

        public long StreetId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }

    public class PackList
    {
        [JsonProperty("company_code")]
        public string CompanyCode { get; set; }

        [JsonProperty("deliver_id")]
        public string DeliverId { get; set; }

        [JsonProperty("track_no")]

        public long TrackNo { get; set; }
    }

    public class Spec
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
