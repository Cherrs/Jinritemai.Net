using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class QualificationConfigRequest:IRequest
    {
        public string method { get; set; } = "product.qualificationConfig";
        public string path { get; set; } = "/product/qualificationConfig";

        public long category_id { get; set; }
    }
}
