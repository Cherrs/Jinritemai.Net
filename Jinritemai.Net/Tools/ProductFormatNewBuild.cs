using Jinritemai.Net.Spu;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Tools
{
    public static class ProductFormatNewBuild
    {
        public static string BuildProductFormatNewByPropertyInfo(List<PropertyInfo> info)
        {
            JObject result = new JObject();
            foreach(var i in info)
            {
                var _item = i.property_values.Select(x =>
                    new JObject(
                        new JProperty("value", x.value_id),
                        new JProperty("name", x.value_name),
                        new JProperty("diy_type", 0)
                        )
                    );
                var _arr = new JArray(_item);
                result.Add(i.property_id.ToString(), _arr);
            }
            return result.ToString();
        }
    }
}
