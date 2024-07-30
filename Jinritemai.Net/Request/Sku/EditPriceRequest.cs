using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Sku
{
    public class EditPriceRequest : IRequest
    {
        public string method { get; set; } = "sku.editPrice";
        public string path { get; set; } = "/sku/editPrice";
        public long sku_id { get; set; }
        public string out_sku_id { get; set; }
        public long product_id { get; set; }
        public string out_product_id { get; set; }

        public long price { get; set; }
    }
}
