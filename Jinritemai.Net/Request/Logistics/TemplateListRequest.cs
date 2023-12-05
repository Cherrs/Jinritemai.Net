using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Logistics
{
    public class TemplateListRequest : IRequest
    {
        public string method { get; set; } = "logistics.templateList";
        public string path { get; set; } = "/logistics/templateList";
    }
}
