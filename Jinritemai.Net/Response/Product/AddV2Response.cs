using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class AddV2Response
    {
        public string create_time { get; set; }
        public string out_product_id { get; set; }
        public string outer_product_id { get; set; }
        public string product_id { get; set; }
        public List<Sku> sku { get; set; }
    }

    public class Sku
    {
        public string code { get; set; }
        public string out_sku_id { get; set; }
        public string outer_sku_id { get; set; }
        public string sku_id { get; set; }
        public string spec_detail_id1 { get; set; }
        public string spec_detail_id2 { get; set; }
        public string spec_detail_id3 { get; set; }
    }

}
