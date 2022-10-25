using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Spu
{
    public class QueryBookNameByISBNRequest : IRequest
    {
        public string method { get; set; } = "spu.queryBookNameByISBN";
        public string path { get; set; } = "/spu/queryBookNameByISBN";
        public long? category_leaf_id { get; set; }

        public string isbn { get; set; }

        public long page_no { get; set; }

        public long page_size { get; set; }
    }
}
