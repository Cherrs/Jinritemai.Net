using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Order
{

    public class ShareDiscountCost
    {
        public int platform_cost { get; set; }
        public int shop_cost { get; set; }
    }

    public class FullDiscountInfo
    {
        public long campaign_id { get; set; }
        public int campaign_type { get; set; }
        public ShareDiscountCost share_discount_cost { get; set; }
        public string campaign_name { get; set; }
        public int campaign_amount { get; set; }
        public int campaign_sub_type { get; set; }
    }

    public class ShopDiscountDetail
    {
        public int total_amount { get; set; }
        public int coupon_amount { get; set; }
        public int full_discount_amount { get; set; }
        public List<CouponInfo> coupon_info { get; set; }
        public List<FullDiscountInfo> full_discount_info { get; set; }
    }

    public class PlatformDiscountDetail
    {
        public int total_amount { get; set; }
        public int coupon_amount { get; set; }
        public int full_discount_amount { get; set; }
        public List<CouponInfo> coupon_info { get; set; }
        public List<FullDiscountInfo> full_discount_info { get; set; }
    }

    public class KolDiscountDetail
    {
        public int total_amount { get; set; }
        public int coupon_amount { get; set; }
        public int full_discount_amount { get; set; }
        public List<CouponInfo> coupon_info { get; set; }
        public List<FullDiscountInfo> full_discount_info { get; set; }
    }

    public class PromotionDetail
    {
        public ShopDiscountDetail shop_discount_detail { get; set; }
        public PlatformDiscountDetail platform_discount_detail { get; set; }
        public KolDiscountDetail kol_discount_detail { get; set; }
    }

    public class CampaignInfo
    {
        public long campaign_id { get; set; }
        public int campaign_type { get; set; }
        public ShareDiscountCost share_discount_cost { get; set; }
        public string campaign_name { get; set; }
        public int campaign_amount { get; set; }
        public int campaign_sub_type { get; set; }
    }

    public class SkuOrderTagUi
    {
        public string key { get; set; }
        public string text { get; set; }
        public string hover_text { get; set; }
        public string tag_type { get; set; }
        public string help_doc { get; set; }
        public int sort { get; set; }
    }
    public class AfterSaleInfo
    {
        public int after_sale_status { get; set; }
    }
    public class OrderPhaseList
    {
        public string phase_order_id { get; set; }
        public int total_phase { get; set; }
        public int current_phase { get; set; }
        public int sku_price { get; set; }
        public bool pay_success { get; set; }
        public string sku_order_id { get; set; }
        public string campaign_id { get; set; }
        public int phase_payable_price { get; set; }
        public int phase_pay_type { get; set; }
        public int phase_open_time { get; set; }
        public int phase_pay_time { get; set; }
        public int phase_close_time { get; set; }
        public string channel_payment_no { get; set; }
        public int phase_order_amount { get; set; }
        public int phase_sum_amount { get; set; }
        public int phase_post_amount { get; set; }
        public int phase_pay_amount { get; set; }
        public int phase_promotion_amount { get; set; }
        public string current_phase_status_desc { get; set; }
    }

    public class ShopOrderDetail
    {
        public int shop_id { get; set; }
        public string shop_name { get; set; }
        public string open_id { get; set; }
        public string order_id { get; set; }
        public int order_level { get; set; }
        public int biz { get; set; }
        public string biz_desc { get; set; }
        public int order_type { get; set; }
        public string order_type_desc { get; set; }
        public int trade_type { get; set; }
        public string trade_type_desc { get; set; }
        public int order_status { get; set; }
        public string order_status_desc { get; set; }
        public int main_status { get; set; }
        public string main_status_desc { get; set; }
        public int pay_time { get; set; }
        public int order_expire_time { get; set; }
        public int finish_time { get; set; }
        public int create_time { get; set; }
        public int update_time { get; set; }
        public string cancel_reason { get; set; }
        public string buyer_words { get; set; }
        public string seller_words { get; set; }
        public int b_type { get; set; }
        public string b_type_desc { get; set; }
        public int sub_b_type { get; set; }
        public string sub_b_type_desc { get; set; }
        public long app_id { get; set; }
        public int pay_type { get; set; }
        public string channel_payment_no { get; set; }
        public int order_amount { get; set; }
        public int pay_amount { get; set; }
        public int post_amount { get; set; }
        public int post_insurance_amount { get; set; }
        public int modify_amount { get; set; }
        public int modify_post_amount { get; set; }
        public int promotion_amount { get; set; }
        public int promotion_shop_amount { get; set; }
        public int promotion_platform_amount { get; set; }
        public int shop_cost_amount { get; set; }
        public int platform_cost_amount { get; set; }
        public int promotion_talent_amount { get; set; }
        public int promotion_pay_amount { get; set; }
        public string post_tel { get; set; }
        public string post_receiver { get; set; }
        public PostAddr post_addr { get; set; }
        public int exp_ship_time { get; set; }
        public int ship_time { get; set; }
        public List<LogisticsInfo> logistics_info { get; set; }
        public PromotionDetail promotion_detail { get; set; }
        public List<SkuOrderList> sku_order_list { get; set; }
        public int seller_remark_stars { get; set; }
        public List<OrderPhaseList> order_phase_list { get; set; }
        public string encrypt_post_tel { get; set; }
        public string encrypt_post_receiver { get; set; }
    }

    public class OrderDetailResponse
    {
        public ShopOrderList shop_order_detail { get; set; }
    }
}
