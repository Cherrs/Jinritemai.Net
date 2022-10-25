using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net
{
    public class CreateTokenRequest:IRequest
    {
        public string code { get; set; }
        public string grant_type { get; set; }
        public string test_shop { get; set; }
        public string shop_id { get; set; }
        public string method { get; set; } = "token.create";
        public string path { get; set; } = "/token/create";
    }
}
