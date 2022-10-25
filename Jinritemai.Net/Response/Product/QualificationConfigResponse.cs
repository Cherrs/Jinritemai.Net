using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Product
{
    public class ConfigList
    {
        public bool is_required { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string support_web_url_type { get; set; }
        public List<string> text_list { get; set; }
    }

    public class QualificationConfigResponse
    {
        public List<ConfigList> config_list { get; set; }
    }

}
