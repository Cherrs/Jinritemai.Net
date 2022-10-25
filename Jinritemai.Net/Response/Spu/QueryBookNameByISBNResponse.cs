using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Spu
{
    public class QueryBookNameByISBNResponse
    {
        public List<NData> data { get; set; }
        public string total { get; set; }
    }
    public class NData
    {
        public string book_name { get; set; }
        public long category_leaf_id { get; set; }
        public long spu_id { get; set; }
    }
}
