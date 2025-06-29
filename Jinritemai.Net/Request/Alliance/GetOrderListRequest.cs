using System.Collections.Generic;
using Jinritemai.Net;

namespace Jinritemai.Net.Alliance;

public class GetOrderListRequest : IRequest
{
    public string method { get; set; } = "alliance.getOrderList";
    public string path { get; set; } = "/alliance/getOrderList";

    public List<string> order_ids { get; set; }
}