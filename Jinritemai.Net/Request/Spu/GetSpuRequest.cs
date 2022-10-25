using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Spu
{
    public class KeyProperty
    {
        public string property_id { get; set; }
        public List<PropertyValue> property_values { get; set; }
    }

    public class PropertyValue
    {
        public long value_id { get; set; }
        public string value_name { get; set; }
    }

    public class GetSpuRequest: IRequest
    {
        public string category_leaf_id { get; set; }
        public List<KeyProperty> key_properties { get; set; }
        public long spu_id { get; set; }
        public string method { get; set; } = "spu.getSpu";
        public string path { get; set; } = "/spu/getSpu";
    }
}
