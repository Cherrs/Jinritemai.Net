using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Logistics
{
    public class OrderLogisticsCompanyListRequest : IRequest
    {
        public string method { get; set; } = "order.logisticsCompanyList";
        public string path { get; set; } = "/order/logisticsCompanyList";
    }
}
