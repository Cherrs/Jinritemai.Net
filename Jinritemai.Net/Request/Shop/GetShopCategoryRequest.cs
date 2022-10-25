using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Shop
{
    public class GetShopCategoryRequest : IRequest
    {
        public string method { get; set; } = "shop.getShopCategory";
        public string path { get; set; } = "/shop/getShopCategory";

        public long cid { get; set; }
    }
}
