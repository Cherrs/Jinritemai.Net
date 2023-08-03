using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class BrandListResponse
    {
        public List<AuthBrandList> auth_brand_list { get; set; }
        public string auth_required { get; set; }
        public List<BrandList> brand_list { get; set; }
    }

    public class AuthBrandList
    {
        public string brand_id { get; set; }
        public string name_cn { get; set; }
        public string name_en { get; set; }
    }

    public class BrandList
    {
        public string brand_id { get; set; }
        public string name_cn { get; set; }
        public string name_en { get; set; }
    }

}
