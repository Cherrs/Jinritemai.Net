using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Material
{
    public class QueryMaterialDetailRequest : IRequest
    {
        public string method { get; set; } = "material.queryMaterialDetail";
        public string path { get; set; } = "/material/queryMaterialDetail";
        public string material_id { get; set; }
    }
}
