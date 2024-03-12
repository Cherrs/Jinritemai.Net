using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Logistics
{
    public class OrderLogisticsAddRequest : IRequest
    {
        /// <summary>
        /// 订单ID需要带大写A
        /// </summary>
        public string order_id { get; set; }
        /// <summary>
        /// 物流公司ID（与company_code二选一）
        /// </summary>
        public int logistics_id { get; set; }
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string company { get; set; }
        /// <summary>
        /// 物流公司code（与logistics_id二选一，其他物流只写此值）
        /// </summary>
        public string company_code { get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string logistics_code { get; set; }
        /// <summary>
        /// 是否拒绝退款申请（默认不传即为false，则发货失败；true即拒绝退款，发货成功
        /// </summary>
        public bool is_refund_reject { get; set; }
        public string method { get; set; } = "order.logisticsAdd";
        public string path { get; set; } = "/order/logisticsAdd";
    }
}
