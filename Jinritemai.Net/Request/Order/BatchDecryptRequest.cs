using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Order
{
    public class BatchDecryptRequest : IRequest
    {
        public string method { get; set; } = "order.batchDecrypt";
        public string path { get; set; } = "/order/batchDecrypt";
        /// <summary>
        /// 订单号
        /// </summary>
        public List<CipherInfos> cipher_infos { get; set; }
    }

    public class CipherInfos
    {
        public string auth_id { get; set; }

        public string cipher_text { get; set; }
    }
}
