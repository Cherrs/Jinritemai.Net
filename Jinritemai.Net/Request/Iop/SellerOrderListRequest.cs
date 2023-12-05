using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Iop
{
    public class SellerOrderListRequest : IRequest
    {
        /// <summary>
        /// 更新时间 开始
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? start_update_time { get; set; }
        /// <summary>
        /// 更新时间 结束
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? end_update_time { get; set; }
        /// <summary>
        /// 页数（默认为0，第一页从0开始）
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 每页订单数（默认为10，最大100）
        ///超过100则会按照最大值100处理
        /// </summary>
        public int size { get; set; }
        public string method { get; set; } = "iop.sellerOrderList";

        public string path { get; set; } = "/iop/sellerOrderList";

    }
}
