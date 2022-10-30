using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class EditV2Request:IRequest
    {
        public string method { get; set; } = "product.editV2";
        public string path { get; set; } = "/product/editV2";
        public long product_id { get; set; }
        public string product_type { get; set; }
        public string category_leaf_id { get; set; }
        public string product_format { get; set; }
        public string name { get; set; }
        public string recommend_remark { get; set; }
        public string pic { get; set; }
        public string description { get; set; }
        public string pay_type { get; set; }
        public string delivery_method { get; set; }
        public string cdf_category { get; set; }
        public string reduce_type { get; set; }
        public string assoc_ids { get; set; }
        public string freight_id { get; set; }
        public string weight_unit { get; set; }
        public string delivery_delay_day { get; set; }
        public string presell_type { get; set; }
        public string presell_delay { get; set; }
        public string presell_end_time { get; set; }
        public string supply_7day_return { get; set; }
        public string mobile { get; set; }
        public bool commit { get; set; }
        public string brand_id { get; set; }
        public string remark { get; set; }
        public string out_product_id { get; set; }
        public List<QualityList> quality_list { get; set; }
        public string spec_name { get; set; }
        public string specs { get; set; }
        public string spec_prices { get; set; }
        public string spec_pic { get; set; }
        public string maximum_per_order { get; set; }
        public string limit_per_buyer { get; set; }
        public string minimum_per_order { get; set; }
        public string product_format_new { get; set; }
        public string spu_id { get; set; }
        public string appoint_delivery_day { get; set; }
        public string third_url { get; set; }
        public string extra { get; set; }
        public string src { get; set; }
        public string outer_product_id { get; set; }
        public string standard_brand_id { get; set; }
        public string need_check_out { get; set; }
        public PoiResource poi_resource { get; set; }
        public string force_use_quality_list { get; set; }
        public string car_vin_code { get; set; }
        public string presell_config_level { get; set; }
        public string need_recharge_mode { get; set; }
        public string account_template_id { get; set; }
        public string presell_delivery_type { get; set; }
        public string white_back_ground_pic_url { get; set; }
        public string long_pic_url { get; set; }
        public List<int> sell_channel { get; set; }
        public string start_sale_type { get; set; }
        public DelayRule delay_rule { get; set; }
        public string material_video_id { get; set; }
        public string pickup_method { get; set; }
        public string size_info_template_id { get; set; }
        public string substitute_goods_url { get; set; }
        public string sale_channel_type { get; set; }
        public string name_prefix { get; set; }
        public string store_id { get; set; }
        public string main_product_id { get; set; }
        public string sale_limit_id { get; set; }
        public string reference_price { get; set; }
        public ReferencePriceCertificate reference_price_certificate { get; set; }
    }


}
