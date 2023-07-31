using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Jinritemai.Net.Product
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DelayRule
    {
        public string enable { get; set; }
        public string config_type { get; set; }
        public string config_value { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }

    public class PoiResource
    {
        public string valid_days { get; set; }
        public string valid_start { get; set; }
        public string valid_end { get; set; }
        public string service_num { get; set; }
        public string notification { get; set; }
        public string code_type { get; set; }
        public string count { get; set; }
        public string couponSecondExchange { get; set; }
        public string total_can_use_count { get; set; }
        public string link { get; set; }
        public string condition { get; set; }
        public List<int> coupon_return_methods { get; set; }
    }

    public class QualityAttachment
    {
        public string media_type { get; set; }
        public string url { get; set; }
    }

    public class QualityList
    {
        public string quality_key { get; set; }
        public string quality_name { get; set; }
        public List<QualityAttachment> quality_attachments { get; set; }
    }

    public class RecruitInfo
    {
        public string recruit_follow_id { get; set; }
        public string recruit_type { get; set; }
    }

    public class ReferencePriceCertificate
    {
        public string certificate_type { get; set; }
        public List<string> certificate_urls { get; set; }
    }

    public class AddV2Request : IRequest
    {
        public string method { get; set; } = "product.addV2";
        public string path { get; set; } = "/product/addV2";
        public string outer_product_id { get; set; }
        public int product_type { get; set; }
        public long category_leaf_id { get; set; }
        public string product_format { get; set; }
        public string name { get; set; }
        public string recommend_remark { get; set; }
        public string pic { get; set; }
        public string description { get; set; }
        public string pay_type { get; set; }
        public string delivery_method { get; set; }
        public string cdf_category { get; set; }
        public int reduce_type { get; set; }
        public string assoc_ids { get; set; }
        public long freight_id { get; set; }
        public string weight_unit { get; set; }
        public long delivery_delay_day { get; set; }
        public int presell_type { get; set; }
        public string presell_delay { get; set; }
        public string presell_end_time { get; set; }
        public int supply_7day_return { get; set; }
        public string mobile { get; set; }
        public bool commit { get; set; }
        public string brand_id { get; set; }
        public string remark { get; set; }
        public string out_product_id { get; set; }
        public List<QualityList> quality_list { get; set; }
        public string spec_name { get; set; }
        public string specs { get; set; }
        public SpecPrices spec_prices { get; set; }
        public string spec_pic { get; set; }
        public string maximum_per_order { get; set; }
        public string limit_per_buyer { get; set; }
        public string minimum_per_order { get; set; }
        public string product_format_new { get; set; }
        public long spu_id { get; set; }
        public string appoint_delivery_day { get; set; }
        public string third_url { get; set; }
        public string extra { get; set; }
        public string src { get; set; }
        public long standard_brand_id { get; set; }
        public string need_check_out { get; set; }
        public PoiResource poi_resource { get; set; }
        public string car_vin_code { get; set; }
        public string presell_config_level { get; set; }
        public string need_recharge_mode { get; set; }
        public string account_template_id { get; set; }
        public string presell_delivery_type { get; set; }
        public string white_back_ground_pic_url { get; set; }
        public string long_pic_url { get; set; }
        public List<object> sell_channel { get; set; }
        public string start_sale_type { get; set; }
        public DelayRule delay_rule { get; set; }
        public string material_video_id { get; set; }
        public string pickup_method { get; set; }
        public string size_info_template_id { get; set; }
        public string substitute_goods_url { get; set; }
        public string sale_channel_type { get; set; }
        public RecruitInfo recruit_info { get; set; }
        public string store_id { get; set; }
        public string main_product_id { get; set; }
        public string sale_limit_id { get; set; }
        public string name_prefix { get; set; }
        public string reference_price { get; set; }
        public ReferencePriceCertificate reference_price_certificate { get; set; }
    }

    public class SpecPrices
    {
        [JsonProperty("spec_detail_name1")]
        public string SpecDetailName1 { get; set; }

        [JsonProperty("spec_detail_name2")]
        public string SpecDetailName2 { get; set; }

        [JsonProperty("spec_detail_name3")]
        public string SpecDetailName3 { get; set; }

        [JsonProperty("stock_num")]
        public long StockNum { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("step_stock_num")]
        public long StepStockNum { get; set; }

        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }

        [JsonProperty("outer_sku_id")]
        public string OuterSkuId { get; set; }

        [JsonProperty("delivery_infos")]
        public object[] DeliveryInfos { get; set; }
    }

}
