using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Jinritemai.Net.Order
{
    public class InvoiceListRequest : IRequest
    {
        public string method { get; set; } = "order.invoiceList";
        public string path { get; set; } = "/order/invoiceList";
        public string order_id { get; set; }
        public string order_status { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? start_time { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public string end_time { get; set; }
        public int status { get; set; }
        public int page_no { get; set; }
        public int page_size { get; set; }
        public string order_by { get; set; }
        public string order_field { get; set; }

    }
}
