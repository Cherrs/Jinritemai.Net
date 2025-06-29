namespace Jinritemai.Net.Order;

using System.Collections.Generic;

public class Datum
{
    public long channel_promotion_fee { get; set; }
    public long other_sharing_amount { get; set; }
    public long bank_pay_promotion_amount { get; set; }
    public string fund_flow_desc { get; set; }
    public long platform_service_fee { get; set; }
    public long channel_fee { get; set; }
    public long colonel_service_fee { get; set; }
    public long actual_zt_pay_promotion { get; set; }
    public string after_sale_service_no { get; set; }
    public string order_type_desc { get; set; }
    public string shop_id { get; set; }
    public string account_trade_no { get; set; }
    public long account_bill_desc_tag { get; set; }
    public long refund_amount { get; set; }
    public long order_type { get; set; }
    public string biz_type_desc { get; set; }
    public string author_id { get; set; }
    public long promotion_amount { get; set; }
    public long partner_commission { get; set; }
    public string trans_scene { get; set; }
    public string free_commission_flag { get; set; }
    public string product_name { get; set; }
    public long fund_flow { get; set; }
    public long pay_amount { get; set; }
    public long commission { get; set; }
    public string product_id { get; set; }
    public long account_amount { get; set; }
    public long account_type { get; set; }
    public long author_coupon_subsidy { get; set; }
    public string author_name { get; set; }
    public long gov_promotion_amount { get; set; }
    public string bill_time { get; set; }
    public string account_bill_desc { get; set; }
    public string shop_order_id { get; set; }
    public long biz_type { get; set; }
    public long actual_zr_pay_promotion { get; set; }
    public long real_free_commission_amount { get; set; }
    public long post_promotion_amount { get; set; }
    public string business_order_create_time { get; set; }
    public string account_type_desc { get; set; }
    public long other_platform_promotion_amount { get; set; }
    public string remark { get; set; }
    public long post_amount { get; set; }
    public long trans_scene_tag { get; set; }
    public long recycler_amount { get; set; }
    public string order_id { get; set; }
}

public class GetShopAccountItemResponse
{
    public string code { get; set; }
    public string code_msg { get; set; }
    public List<Datum> data { get; set; }
    public string next_start_index { get; set; }
    public string next_start_time { get; set; }
    public long size { get; set; }
    public long data_size { get; set; }
    public long is_end { get; set; }
}

