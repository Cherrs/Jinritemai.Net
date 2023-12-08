using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace Jinritemai.Net
{
    public class RequestBase
    {
        /// <summary>
        /// 调用的API接口名称
        /// </summary>
        public string method { get; set; }
        /// <summary>
        /// 应用创建完成后被分配的key
        /// </summary>
        public string app_key { get; set; }
        /// <summary>
        /// 用于调用 API 的 access_token
        /// </summary>
        [JsonIgnore]
        public string access_token { get; set; }
        /// <summary>
        /// 标准json类型，里面是业务参数按照参数名的字符串大小排序具体参数值，参考每个接口的参数表
        /// </summary>
        public string param_json { get; set; }
        /// <summary>
        /// 时间格式，格式要求为yyyy-MM-dd HH:mm:ss，时区为GMT+8，例如：2016-01-01 12:00:00
        /// </summary>
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd HH:mm:ss")]
        public DateTimeOffset timestamp { get; set; } = DateTimeOffset.Now;
        /// <summary>
        /// API协议版本，当前版本为2
        /// </summary>
        public string v { get; set; } = "2";
        /// <summary>   
        /// 输入参数签名结果
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 签名算法类型（不传则默认为"md5"）
        ///1. md5。表示用md5算法加密字符串
        ///2. hmac-sha256。表示用hmac_sha_256算法加密字符串
        /// </summary>
        [JsonIgnore]
        public string sign_method { get; set; } = "hmac-sha256";
        [JsonIgnore]
        public string path { get; set; }
    }
}
