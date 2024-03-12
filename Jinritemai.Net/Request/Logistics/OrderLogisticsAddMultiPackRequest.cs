using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Logistics
{
    public class OrderLogisticsAddMultiPackRequest : IRequest
    {
        public string OrderId { get; set; }
        public PackList[] PackList { get; set; }
        public bool IsRejectRefund { get; set; }
        public long AddressId { get; set; }
        public string[] SerialNumberList { get; set; }
        public bool IsRefundReject { get; set; }
        public long StoreId { get; set; }
        public long AfterSaleAddressId { get; set; }
        public string method { get; set; } = "order.logisticsAddMultiPack";
        public string path { get; set; } = "/order/logisticsAddMultiPack";
    }

    public partial class PackList
    {
        public ShippedOrderInfo[] ShippedOrderInfo { get; set; }
        public string LogisticsCode { get; set; }
        public string Company { get; set; }
        public string CompanyCode { get; set; }
        public long LogisticsId { get; set; }
    }

    public partial class ShippedOrderInfo
    {
        public long ShippedOrderId { get; set; }
        public long ShippedNum { get; set; }
        public object[] ShippedItemIds { get; set; }
        public BundleList[] BundleList { get; set; }
    }

    public partial class BundleList
    {
        public long SubProductId { get; set; }
        public long SubSkuId { get; set; }
        public long ComboNum { get; set; }
    }
}
