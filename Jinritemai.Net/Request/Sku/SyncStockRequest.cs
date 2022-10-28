using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Sku
{
    public class SyncStockRequest:IRequest
    {
        public string method { get; set; } = "sku.syncStock";
        public string path { get; set; } = "/sku/syncStock";
        public string code { get; set; }
        public long sku_id { get; set; }
        public string out_sku_id { get; set; }
        public long product_id { get; set; }
        public string out_product_id { get; set; }
        public string out_warehouse_id { get; set; }
        public string supplier_id { get; set; }
        public bool incremental { get; set; }
        public string idempotent_id { get; set; }
        public long stock_num { get; set; }
        public string step_stock_num { get; set; }
    }
}
