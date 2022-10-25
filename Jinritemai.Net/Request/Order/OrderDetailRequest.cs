using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Order
{
    public class OrderDetailRequest : IRequest
    {
        public string method { get; set; } = "order.orderDetail";
        public string path { get; set; } = "/order/orderDetail";
        /// <summary>
        /// 订单号
        /// </summary>
        public string shop_order_id { get; set; }
    }
}
