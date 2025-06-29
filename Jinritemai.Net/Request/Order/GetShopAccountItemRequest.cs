namespace Jinritemai.Net.Order;

public class GetShopAccountItemRequest : IRequest
{
    public string method { get; set; } = "order.getShopAccountItem";
    public string path { get; set; } = "/order/getShopAccountItem";

    public string order_id { get; set; }

    public string start_time { get; set; }

    public string end_time { get; set; }

    public string start_index { get; set; }

    public int size { get; set; }
}