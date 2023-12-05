namespace Jinritemai.Net.Logistics
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NewCreateOrderRequest : IRequest
    {
        [JsonProperty("appId", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AccessToken { get; set; }

        [JsonProperty("sender_info", NullValueHandling = NullValueHandling.Ignore)]
        public SenderInfo SenderInfo { get; set; }

        [JsonProperty("logistics_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LogisticsCode { get; set; }

        [JsonProperty("order_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderInfo> OrderInfos { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [JsonProperty("delivery_req", NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryReq DeliveryReq { get; set; }

        [JsonProperty("order_channel", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderChannel { get; set; }

        [JsonProperty("ebill_delivery_info", NullValueHandling = NullValueHandling.Ignore)]
        public EbillDeliveryInfo EbillDeliveryInfo { get; set; }
        public string method { get; set; } = "logistics.newCreateOrder";
        public string path { get; set; } = "/logistics/newCreateOrder";
    }

    public partial class DeliveryReq
    {
        [JsonProperty("is_center_delivery", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCenterDelivery { get; set; }

        [JsonProperty("is_pickup_self", NullValueHandling = NullValueHandling.Ignore)]
        public string IsPickupSelf { get; set; }
    }

    public partial class EbillDeliveryInfo
    {
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }
    }

    public partial class OrderInfo
    {
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        [JsonProperty("pack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackId { get; set; }

        [JsonProperty("service_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceList> ServiceList { get; set; }

        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductType { get; set; }

        [JsonProperty("pay_method", NullValueHandling = NullValueHandling.Ignore)]
        public string PayMethod { get; set; }

        [JsonProperty("pay_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PayAmount { get; set; }

        [JsonProperty("pod_model_address", NullValueHandling = NullValueHandling.Ignore)]
        public PodModelAddressClass PodModelAddress { get; set; }

        [JsonProperty("receiver_info", NullValueHandling = NullValueHandling.Ignore)]
        public ReceiverInfo ReceiverInfo { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        [JsonProperty("sender_fetch_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderFetchTime { get; set; }

        [JsonProperty("is_sign_back", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSignBack { get; set; }

        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public string Extra { get; set; }

        [JsonProperty("total_pack_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPackCount { get; set; }

        [JsonProperty("total_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalWeight { get; set; }

        [JsonProperty("total_length", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLength { get; set; }

        [JsonProperty("total_width", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalWidth { get; set; }

        [JsonProperty("total_height", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalHeight { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public string Volume { get; set; }

        [JsonProperty("warehouse", NullValueHandling = NullValueHandling.Ignore)]
        public Warehouse Warehouse { get; set; }

        [JsonProperty("net_info", NullValueHandling = NullValueHandling.Ignore)]
        public NetInfo NetInfo { get; set; }

        [JsonProperty("shipping_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ShippingCode { get; set; }

        [JsonProperty("special_delivery_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialDeliveryTypeCode { get; set; }

        [JsonProperty("special_delivery_type_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialDeliveryTypeValue { get; set; }

        [JsonProperty("package_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageWeight { get; set; }

        [JsonProperty("combine_orders", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CombineOrders { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("item_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        [JsonProperty("item_specs", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemSpecs { get; set; }

        [JsonProperty("item_count", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemCount { get; set; }

        [JsonProperty("item_volume", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemVolume { get; set; }

        [JsonProperty("item_weight", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemWeight { get; set; }

        [JsonProperty("item_net_weight", NullValueHandling = NullValueHandling.Ignore)]
        public long ItemNetWeight { get; set; }
    }

    public partial class NetInfo
    {
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty("net_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NetCode { get; set; }

        [JsonProperty("monthly_account", NullValueHandling = NullValueHandling.Ignore)]
        public string MonthlyAccount { get; set; }

        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }
    }

    public partial class PodModelAddressClass
    {
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; } = "CHN";

        [JsonProperty("province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceName { get; set; }

        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CityName { get; set; }

        [JsonProperty("district_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictName { get; set; }

        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }

        [JsonProperty("detail_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailAddress { get; set; }
    }

    public partial class ReceiverInfo
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public ReceiverInfoAddress Address { get; set; }

        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public Contact Contact { get; set; }
    }

    public partial class ReceiverInfoAddress
    {
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; } = "CHN";

        [JsonProperty("province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceName { get; set; }

        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CityName { get; set; }

        [JsonProperty("district_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictName { get; set; }

        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetName { get; set; }

        [JsonProperty("detail_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailAddress { get; set; }

        [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; set; }

        [JsonProperty("city_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CityCode { get; set; }

        [JsonProperty("district_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DistrictCode { get; set; }

        [JsonProperty("street_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetCode { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }
    }

    public partial class ServiceList
    {
        [JsonProperty("service_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCode { get; set; }

        [JsonProperty("service_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceValue { get; set; }
    }

    public partial class Warehouse
    {
        [JsonProperty("is_sum_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSumUp { get; set; }

        [JsonProperty("wh_code", NullValueHandling = NullValueHandling.Ignore)]
        public string WhCode { get; set; }

        [JsonProperty("wh_order_no", NullValueHandling = NullValueHandling.Ignore)]
        public string WhOrderNo { get; set; }

        [JsonProperty("delivery_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryType { get; set; }
    }

    public partial class SenderInfo
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public PodModelAddressClass Address { get; set; }

        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public Contact Contact { get; set; }
    }
}
