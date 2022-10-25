using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Shop
{
    public class GetShopCategoryResponse
    {
        public long id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public long parent_id { get; set; }
        public bool is_leaf { get; set; }
        public bool enable { get; set; }
    }
}
