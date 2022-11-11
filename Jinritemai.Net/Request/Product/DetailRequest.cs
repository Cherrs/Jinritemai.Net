using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class DetailRequest: IRequest
    {
        public string method { get; set; } = "product.detail";
        public string path { get; set; } = "/product/detail";

        public string product_id { get; set; }
        public string out_product_id { get; set; }
        public string show_draft { get; set; }
    }
}
