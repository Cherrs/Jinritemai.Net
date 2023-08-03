using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class BrandListRequest : IRequest
    {
        public string method { get; set; } = "product.detail";
        public string path { get; set; } = "/brand/list";
        public List<int> categories { get; set; }
        public string offset { get; set; }
        public string size { get; set; }
        public string sort { get; set; }
        public string status { get; set; }
        public string full_brand_info { get; set; }
        public string category_id { get; set; }
        public string query { get; set; }
        public List<int> brand_ids { get; set; }
    }
}
