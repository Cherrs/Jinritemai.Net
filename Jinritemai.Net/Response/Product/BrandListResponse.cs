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
        public bool auth_required { get; set; }
        public List<BrandList> brand_list { get; set; }
    }

    public class AuthBrandList
    {
        public long brand_id { get; set; }
        public string name_cn { get; set; }
        public string name_en { get; set; }
    }

    public class BrandList
    {
        public long brand_id { get; set; }
        public string name_cn { get; set; }
        public string name_en { get; set; }
    }

}
