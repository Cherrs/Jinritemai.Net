using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Order
{
    public class SearchListRequest : IRequest
    {
        public string after_sale_status_desc { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? create_time_start { get; set; }
        /// <summary>
        /// 结束时间，必须大于等于开始时间
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? create_time_end { get; set; }
        /// <summary>
        /// 更新时间 开始
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? update_time_start { get; set; }
        /// <summary>
        /// 更新时间 结束
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? update_time_end { get; set; }
        /// <summary>
        /// 1、默认按订单创建时间搜索
        ///2、值为“create_time”：按订单创建时间；值为“update_time”：按订单更新时间
        /// </summary>
        public string order_by { get; set; }
        /// <summary>
        /// 订单排序方式：0按时间升序， 1按时间降序
        ///默认为1
        /// </summary>
        public bool order_asc { get; set; }
        /// <summary>
        /// 页数（默认为0，第一页从0开始）
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 每页订单数（默认为10，最大100）
        ///超过100则会按照最大值100处理
        /// </summary>
        public int size { get; set; }
        public List<combine_status> combine_status { get; set; }
        public string method { get; set; } = "order.searchList";

        public string path { get; set; } = "/order/searchList";

    }

    public class combine_status
    {
        public int order_status { get; set; }
        public int main_status { get; set; }
    }
}
