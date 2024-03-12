using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net
{
    public class Token
    {
        /// <summary>
        /// 用于调用API的access_token
        ///过期时间为expires_in值
        ///可通过refresh_token刷新获取新的access_token，过期时间仍为 expires_in值
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// access_token接口调用凭证超时时间，单位（秒），默认有效期：7天
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// 授权作用域，使用逗号,分隔。预留字段
        /// </summary>
        public string scope { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int shop_id { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string shop_name { get; set; }
        /// <summary>
        /// 用于刷新access_token的刷新令牌（有效期：14 天）
        /// </summary>
        public string refresh_token { get; set; }
        /// <summary>
        /// 获取时间
        /// </summary>
        public DateTime expires_date { get; set; }
    }


    public class Result<T>
    {
        public T data { get; set; }
        public string msg { get; set; }
        public string sub_msg { get; set; }
        public string sub_code { get; set; }

        public string raw_body { get; set; }
    }
}
