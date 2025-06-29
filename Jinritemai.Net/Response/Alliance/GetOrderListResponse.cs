namespace Jinritemai.Net.Alliance;

public class GetOrderListResponse
{
    public string alliance_biz_type { get; set; }
    public string author_account { get; set; }
    public long commission_rate { get; set; }
    public long estimated_comission { get; set; }
    public string order_id { get; set; }
    public string order_status { get; set; }
    public long phase_id { get; set; }

    public string product_id { get; set; }
    public string real_comission { get; set; }
    public string shop_id { get; set; }
    public string short_id { get; set; }
    public long total_pay_amount { get; set; }
}