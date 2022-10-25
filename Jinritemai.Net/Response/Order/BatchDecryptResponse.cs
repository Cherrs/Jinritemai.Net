using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Order
{

    public class Decrypt_infosItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string auth_id { get; set; }
        /// <summary>
        /// 密文，具体内容参考[数据安全加密对接文档](https://op.jinritemai.com/docs/guide-docs/56/589)
        /// </summary>
        public string cipher_text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string decrypt_text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int err_no { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string err_msg { get; set; }
    }

    public class Custom_err
    {
        /// <summary>
        /// 
        /// </summary>
        public int err_code { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string err_msg { get; set; }
    }

    public class BatchDecryptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Decrypt_infosItem> decrypt_infos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Custom_err custom_err { get; set; }
    }

}
