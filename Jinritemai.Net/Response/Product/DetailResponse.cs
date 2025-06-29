using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CategoryDetail
    {
        public long first_cid { get; set; }
        public string first_cname { get; set; }
        public long fourth_cid { get; set; }
        public string fourth_cname { get; set; }
        public long second_cid { get; set; }
        public string second_cname { get; set; }
        public long third_cid { get; set; }
        public string third_cname { get; set; }
    }

    public class CustomsReportInfo
    {
        public string bar_code { get; set; }
        public long first_measure_qty { get; set; }
        public string first_measure_unit { get; set; }
        public string g_model { get; set; }
        public string hs_code { get; set; }
        public string report_brand_name { get; set; }
        public string report_name { get; set; }
        public long second_measure_qty { get; set; }
        public string second_measure_unit { get; set; }
        public string unit { get; set; }
        public string usage { get; set; }
    }

    public class DetailResponse
    {
        public object account_template_id { get; set; }
        public string after_sale_service { get; set; }
        public long appolong_delivery_day { get; set; }
        public object brand_id { get; set; }
        public object car_vin_code { get; set; }
        public CategoryDetail category_detail { get; set; }
        public object cdf_category { get; set; }
        public long check_status { get; set; }
        public string create_time { get; set; }
        public DelayRule delay_rule { get; set; }
        public long delivery_delay_day { get; set; }
        public object delivery_method { get; set; }
        public string description { get; set; }
        public long discount_price { get; set; }
        public long draft_status { get; set; }
        public string extra { get; set; }
        public long freight_id { get; set; }
        public string img { get; set; }
        public long is_create { get; set; }
        public bool is_sub_product { get; set; }
        public long limit_per_buyer { get; set; }
        public LogisticsInfo logistics_info { get; set; }
        public object long_pic_url { get; set; }
        public object main_product_id { get; set; }
        public long market_price { get; set; }
        public object material_video_id { get; set; }
        public long maximum_per_order { get; set; }
        public long minimum_per_order { get; set; }
        public string mobile { get; set; }
        public string name { get; set; }
        public object name_prefix { get; set; }
        public bool need_recharge_mode { get; set; }
        public long open_user_id { get; set; }
        public long out_product_id { get; set; }
        public string outer_product_id { get; set; }
        public long pay_type { get; set; }
        public List<string> pic { get; set; }
        public string pickup_method { get; set; }
        public object presell_config_level { get; set; }
        public long presell_delay { get; set; }
        public long presell_type { get; set; }
        public long price_has_tax { get; set; }
        public string product_format { get; set; }
        public string product_format_new { get; set; }
        public long product_id { get; set; }
        public string product_id_str { get; set; }
        public List<object> quality_list { get; set; }
        public string recommend_remark { get; set; }
        public object sale_channel_type { get; set; }
        public object sale_limit_id { get; set; }
        public List<long> sell_channel { get; set; }
        public object size_info_template_id { get; set; }
        public long spec_id { get; set; }
        public List<object> spec_pics { get; set; }
        public List<SpecPrice> spec_prices { get; set; }
        public List<Spec> specs { get; set; }
        public long standard_brand_id { get; set; }
        public long status { get; set; }
        public long store_id { get; set; }
        public DateTime update_time { get; set; }
        public object white_back_ground_pic_url { get; set; }
    }


    public class LogisticsInfo
    {
        public long brand_country_id { get; set; }
        public long customs_clear_type { get; set; }
        public long net_weight_qty { get; set; }
        public long origin_country_id { get; set; }
        public long source_country_id { get; set; }
        public long tax_payer { get; set; }
    }

    public class Spec
    {
        public long id { get; set; }
        public long is_leaf { get; set; }
        public string name { get; set; }
        public long pid { get; set; }
        public long spec_id { get; set; }
        public List<Value> values { get; set; }
    }

    public class SpecPrice
    {
        public string code { get; set; }
        public CustomsReportInfo customs_report_info { get; set; }
        public List<object> delivery_infos { get; set; }
        public long lock_step_stock_num { get; set; }
        public long lock_stock_num { get; set; }
        public long out_sku_id { get; set; }
        public string outer_sku_id { get; set; }
        public object presell_delay { get; set; }
        public long price { get; set; }
        public long prom_step_stock_num { get; set; }
        public long prom_stock_num { get; set; }
        public object promotion_step_stock_num { get; set; }
        public object promotion_stock_num { get; set; }
        public long sku_id { get; set; }
        public long sku_type { get; set; }
        public long spec_detail_id1 { get; set; }
        public long spec_detail_id2 { get; set; }
        public long spec_detail_id3 { get; set; }
        public List<long> spec_detail_ids { get; set; }
        public long step_stock_num { get; set; }
        public long stock_num { get; set; }
        public object stock_num_map { get; set; }
        public string supplier_id { get; set; }
        public TaxExemptionSkuInfo tax_exemption_sku_info { get; set; }
    }

    public class TaxExemptionSkuInfo
    {
        public object is_suit { get; set; }
        public object suit_num { get; set; }
        public object volume { get; set; }
    }

    public class Value
    {
        public long id { get; set; }
        public long is_leaf { get; set; }
        public string name { get; set; }
        public long pid { get; set; }
        public long spec_id { get; set; }
        public long status { get; set; }
    }


}
