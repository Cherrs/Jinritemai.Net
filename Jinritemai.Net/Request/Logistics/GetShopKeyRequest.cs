using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Logistics
{
    public class GetShopKeyRequest : IRequest
    {
        public string method { get; set; } = "logistics.getShopKey";
        public string path { get; set; } = "/logistics/getShopKey";
    }
}
