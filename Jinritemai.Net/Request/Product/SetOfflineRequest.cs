using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Request.Product
{
    public class SetOfflineRequest:IRequest
    {
        public string method { get; set; } = "product.setOffline";
        public string path { get; set; } = "/product/setOffline";
        public long product_id { get; set; }
    }
}
