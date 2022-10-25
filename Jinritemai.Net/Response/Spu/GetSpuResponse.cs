using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Spu
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Cspu
    {
        public long cspu_id { get; set; }
        public List<SaleProperty> sale_properties { get; set; }
        public long spu_id { get; set; }
    }

    public class GetSpuResponse
    {
        public long category_leaf_id { get; set; }
        public List<Cspu> cspus { get; set; }
        public List<PropertyInfo> property_infos { get; set; }
        public long spu_id { get; set; }
        public string spu_name { get; set; }
        public string status { get; set; }
    }

    public class PropertyInfo
    {
        public long property_id { get; set; }
        public string property_name { get; set; }
        public long property_type { get; set; }
        public List<PropertyValue> property_values { get; set; }
    }

    public class SaleProperty
    {
        public long property_id { get; set; }
        public string property_name { get; set; }
        public long value_id { get; set; }
        public string value_name { get; set; }
    }


}
