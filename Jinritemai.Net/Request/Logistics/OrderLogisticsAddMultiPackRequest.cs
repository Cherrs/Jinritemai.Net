using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Jinritemai.Net.Logistics
{
    public class OrderLogisticsAddMultiPackRequest : IRequest
    {
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }
        [JsonProperty("pack_list", NullValueHandling = NullValueHandling.Ignore)]
        public PackList[] PackList { get; set; }

        [JsonProperty("is_reject_refund", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsRejectRefund { get; set; }
        [JsonProperty("address_id", NullValueHandling = NullValueHandling.Ignore)]
        public long AddressId { get; set; }
        [JsonProperty("serial_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public string[] SerialNumberList { get; set; }
        [JsonProperty("is_refund_reject", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsRefundReject { get; set; }
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public long StoreId { get; set; }
        [JsonProperty("after_sale_address_id", NullValueHandling = NullValueHandling.Ignore)]
        public long AfterSaleAddressId { get; set; }
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }
        public string method { get; set; } = "order.logisticsAddMultiPack";
        public string path { get; set; } = "/order/logisticsAddMultiPack";
    }

    public partial class PackList
    {
        [JsonProperty("shipped_order_info", NullValueHandling = NullValueHandling.Ignore)]
        public ShippedOrderInfo[] ShippedOrderInfo { get; set; }
        [JsonProperty("logistics_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LogisticsCode { get; set; }
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }
        [JsonProperty("company_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyCode { get; set; }
        [JsonProperty("logistics_id", NullValueHandling = NullValueHandling.Ignore)]
        public long LogisticsId { get; set; }
    }

    public partial class ShippedOrderInfo
    {
        [JsonProperty("shipped_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public long ShippedOrderId { get; set; }
        [JsonProperty("shipped_num", NullValueHandling = NullValueHandling.Ignore)]
        public long ShippedNum { get; set; }
        [JsonProperty("shipped_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public object[] ShippedItemIds { get; set; }
        [JsonProperty("bundle_list", NullValueHandling = NullValueHandling.Ignore)]
        public BundleList[] BundleList { get; set; }
    }

    public partial class BundleList
    {
        [JsonProperty("sub_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public long SubProductId { get; set; }
        [JsonProperty("sub_sku_id", NullValueHandling = NullValueHandling.Ignore)]
        public long SubSkuId { get; set; }
        [JsonProperty("combo_num", NullValueHandling = NullValueHandling.Ignore)]
        public long ComboNum { get; set; }
    }
}
