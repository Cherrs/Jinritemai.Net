using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Order
{
    public class CouponInfo
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int credit { get; set; }
        public int type { get; set; }
        public int discount { get; set; }
        public int pay_type { get; set; }
    }

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Province
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Town
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class PostAddr
    {
        public City city { get; set; }
        public string detail { get; set; }
        public Province province { get; set; }
        public Town town { get; set; }
        public string encrypt_detail { get; set; }
    }

    public class ShopFullCampaign
    {
        public long shop_campaign_id { get; set; }
        public int shop_full_amount { get; set; }
    }

    public class SpecDesc
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Child
    {
        public string b_type { get; set; }
        public int shipped_num { get; set; }
        public List<string> item_ids { get; set; }
        public string buyer_words { get; set; }
        public string cancel_reason { get; set; }
        public string code { get; set; }
        public int combo_amount { get; set; }
        public int combo_id { get; set; }
        public int combo_num { get; set; }
        public string cos_ratio { get; set; }
        public int coupon_amount { get; set; }
        public List<CouponInfo> coupon_info { get; set; }
        public string coupon_meta_id { get; set; }
        public string create_time { get; set; }
        public string is_comment { get; set; }
        public string logistics_code { get; set; }
        public int logistics_id { get; set; }
        public string logistics_time { get; set; }
        public string order_id { get; set; }
        public int order_status { get; set; }
        public int order_type { get; set; }
        public int out_product_id { get; set; }
        public int out_sku_id { get; set; }
        public int pay_type { get; set; }
        public string pay_time { get; set; }
        public string pid { get; set; }
        public PostAddr post_addr { get; set; }
        public int post_amount { get; set; }
        public string post_code { get; set; }
        public string post_receiver { get; set; }
        public string post_tel { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public string product_pic { get; set; }
        public string receipt_time { get; set; }
        public string seller_words { get; set; }
        public int shop_coupon_amount { get; set; }
        public ShopFullCampaign shop_full_campaign { get; set; }
        public int shop_id { get; set; }
        public List<SpecDesc> spec_desc { get; set; }
        public int total_amount { get; set; }
        public int update_time { get; set; }
        public int urge_cnt { get; set; }
    }
    public class Street
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class SkuSpec
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class ProductInfo
    {
        public string product_name { get; set; }
        public int price { get; set; }
        public string outer_sku_id { get; set; }
        public string sku_id { get; set; }
        public List<SkuSpec> sku_specs { get; set; }
        public int product_count { get; set; }
        public long product_id { get; set; }
        public string sku_order_id { get; set; }
    }

    public class LogisticsInfo
    {
        public string tracking_no { get; set; }
        public string company { get; set; }
        public int ship_time { get; set; }
        public string delivery_id { get; set; }
        public string company_name { get; set; }
        public List<ProductInfo> product_info { get; set; }
    }

    public class Spec
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class InventoryList
    {
        public string warehouse_id { get; set; }
        public string out_warehouse_id { get; set; }
        public int inventory_type { get; set; }
        public string inventory_type_desc { get; set; }
    }

    public class SkuOrderList
    {
        public string order_id { get; set; }
        public string parent_order_id { get; set; }
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
        public int b_type { get; set; }
        public string b_type_desc { get; set; }
        public int sub_b_type { get; set; }
        public string sub_b_type_desc { get; set; }
        public string send_pay { get; set; }
        public string send_pay_desc { get; set; }
        public string author_id { get; set; }
        public string author_name { get; set; }
        public string theme_type { get; set; }
        public string theme_type_desc { get; set; }
        public long app_id { get; set; }
        public long room_id { get; set; }
        public string content_id { get; set; }
        public string video_id { get; set; }
        public string origin_id { get; set; }
        public long cid { get; set; }
        public long c_biz { get; set; }
        public string c_biz_desc { get; set; }
        public long page_id { get; set; }
        public int pay_type { get; set; }
        public string channel_payment_no { get; set; }
        public int order_amount { get; set; }
        public int pay_amount { get; set; }
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
        public int shop_receivable_amount { get; set; }
        public string code { get; set; }
        public string post_tel { get; set; }
        public string post_receiver { get; set; }
        public PostAddr post_addr { get; set; }
        public int exp_ship_time { get; set; }
        public int ship_time { get; set; }
        public int logistics_receipt_time { get; set; }
        public int confirm_receipt_time { get; set; }
        public int goods_type { get; set; }
        public long product_id { get; set; }
        public string sku_id { get; set; }
        public List<Spec> spec { get; set; }
        public int first_cid { get; set; }
        public int second_cid { get; set; }
        public int third_cid { get; set; }
        public int fourth_cid { get; set; }
        public string out_sku_id { get; set; }
        public string supplier_id { get; set; }
        public string out_product_id { get; set; }
        public List<string> warehouse_ids { get; set; }
        public List<string> out_warehouse_ids { get; set; }
        public string inventory_type { get; set; }
        public string inventory_type_desc { get; set; }
        public int reduce_stock_type { get; set; }
        public string reduce_stock_type_desc { get; set; }
        public int origin_amount { get; set; }
        public bool has_tax { get; set; }
        public int item_num { get; set; }
        public int sum_amount { get; set; }
        public string source_platform { get; set; }
        public string product_pic { get; set; }
        public int is_comment { get; set; }
        public string product_name { get; set; }
        public List<InventoryList> inventory_list { get; set; }
    }

    public class ShopOrderList
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
        public int shop_receivable_amount { get; set; }
        public string post_tel { get; set; }
        public string post_receiver { get; set; }
        public PostAddr post_addr { get; set; }
        public int exp_ship_time { get; set; }
        public int ship_time { get; set; }
        public List<LogisticsInfo> logistics_info { get; set; }
        public List<SkuOrderList> sku_order_list { get; set; }
        public int seller_remark_stars { get; set; }

        public DateTime UpdateTime { get => DateTimeOffset.FromUnixTimeSeconds(this.update_time).DateTime; }

        public string encrypt_post_tel { get; set; }
        public string encrypt_post_receiver { get; set; }
    }

    public class SearchListResponse
    {
        public int page { get; set; }
        public int total { get; set; }
        public int size { get; set; }
        public List<ShopOrderList> shop_order_list { get; set; }
    }
}
