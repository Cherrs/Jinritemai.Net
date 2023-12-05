using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;

namespace Jinritemai.Net
{
    public class JinritemaiClient
    {
        public JinritemaiClient(string appkey, string secret, string url)
        {
            if (string.IsNullOrWhiteSpace(appkey))
            {
                throw new ArgumentException($"“{nameof(appkey)}”不能为 null 或空白。", nameof(appkey));
            }

            if (string.IsNullOrWhiteSpace(secret))
            {
                throw new ArgumentException($"“{nameof(secret)}”不能为 null 或空白。", nameof(secret));
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException($"“{nameof(url)}”不能为 null 或空白。", nameof(url));
            }

            Appkey = appkey;
            Secret = secret;
            Url = url;
            this.http = new HttpClient();
        }
        internal readonly HttpClient http;
        public string Appkey { get; }
        public string Secret { get; }
        public string Url { get; }
        public static Token AccessToken { get; set; }
        /// <summary>
        /// 生成请求参数
        /// </summary>
        /// <param name="requestbase"></param>
        /// <param name="req"></param>
        /// <returns></returns>
        private static string BuildParam(IRequest req)
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new OrderedContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None
            };
            var re = JsonConvert.SerializeObject(req, settings);
            return re;
        }
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="requestbase"></param>
        /// <returns></returns>
        private string BuildSign(RequestBase requestbase)
        {
            var h = new HMACSHA256(Encoding.UTF8.GetBytes(Secret));
            var strs = BuildSignStr(requestbase);
            var hashmessage = h.ComputeHash(Encoding.UTF8.GetBytes(strs));
            var x = BitConverter.ToString(hashmessage).Replace("-", "").ToLower();
            return x;
        }
        // 计算签名
        private string Sign(string appKey, string appSecret, string method, long timestamp, string paramJson)
        {
            // 按给定规则拼接参数
            var paramPattern = "app_key" + appKey + "method" + method + "param_json" + paramJson + "timestamp" +
                               timestamp + "v2";
            var signPattern = appSecret + paramPattern + appSecret;
            Console.WriteLine("sign_pattern:" + signPattern);

            return Hmac(signPattern, appSecret);
        }

        // 计算hmac
        private static string Hmac(string plainText, string appSecret)
        {
            var h = new HMACSHA256(Encoding.UTF8.GetBytes(appSecret));
            var sum = h.ComputeHash(Encoding.UTF8.GetBytes(plainText));

            var sb = new StringBuilder();
            foreach (byte b in sum)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }


        private string BuildSignStr(RequestBase requestbase)
        {
            var result = $"{Secret}app_key{Appkey}method{requestbase.method}param_json{requestbase.param_json}timestamp{requestbase.timestamp:yyyy-MM-dd HH:mm:ss}v{requestbase.v}{Secret}";
            return result;
        }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        public async Task<Token> GetAccessTokenAsync()
        {
            //var result  = await http.GetStringAsync($"{Url}/oauth2/access_token?app_id={Appkey}&app_secret={Secret}&grant_type=authorization_self");
            var result = await GetResultNotTokenAsync<Token>(new CreateTokenRequest { grant_type = "authorization_self", shop_id = "7095877", code = "" });
            if (result.data is null)
            {
                Error(result);
            }
            AccessToken = result.data;
            AccessToken.expires_date = DateTime.Now.AddSeconds(AccessToken.expires_in);
            return result.data;
        }
        /// <summary>
        /// 生成请求
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        private RequestBase BuildRequest(IRequest req)
        {
            var reqbase = new RequestBase();
            reqbase.method = req.method;
            reqbase.path = req.path;
            reqbase.app_key = Appkey;
            reqbase.access_token = AccessToken?.access_token;
            return reqbase;
        }

        private static void Error<T>(Result<T> result)
        {
            throw new JinritemaiApiException<T>(result);
        }

        public async Task<Result<T>> GetResultAsync<T>(IRequest req)
        {
            var ptr = await GetJsonResultAsync(req);
            return JsonConvert.DeserializeObject<Result<T>>(ptr);
        }
        /// <summary>
        /// 获取json报文
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<string> GetJsonResultAsync(IRequest req)
        {
            if (AccessToken == null || AccessToken.expires_date < DateTime.Now)
            {
                await GetAccessTokenAsync();
            }
            var reqbase = BuildRequest(req);
            reqbase.param_json = BuildParam(req);
            reqbase.sign = BuildSign(reqbase);
            var content = new StringContent(reqbase.param_json, Encoding.UTF8, "application/json");
            var presult = await http.PostAsync($"{Url}{req.path}?method={reqbase.method}&app_key={reqbase.app_key}&timestamp={reqbase.timestamp:yyyy-MM-dd HH:mm:ss}&v={reqbase.v}&sign={reqbase.sign}&access_token={reqbase.access_token}&sign_method=hmac-sha256", content);
            var ptr = await presult.Content.ReadAsStringAsync();
            return ptr;
        }
        public async Task<Result<T>> GetResultNotTokenAsync<T>(IRequest req)
        {
            var reqbase = BuildRequest(req);
            reqbase.param_json = BuildParam(req);
            reqbase.sign = BuildSign(reqbase);
            var content = new StringContent(reqbase.param_json, Encoding.UTF8, "application/json");
            var presult = await http.PostAsync($"{Url}{req.path}?method={reqbase.method}&app_key={reqbase.app_key}&timestamp={reqbase.timestamp.ToString("yyyy-MM-dd HH:mm:ss")}&v={reqbase.v}&sign={reqbase.sign}&access_token={reqbase.access_token}&sign_method=hmac-sha256", content);
            var ptr = await presult.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Result<T>>(ptr);
        }
        public async Task<Result<NullValue>> GetResultAsync(IRequest req)
        {
            return await GetResultAsync<NullValue>(req);
        }
        public string GetQueryString(object obj)
        {

            var properties = obj.GetType().GetProperties().Where(x => x.GetValue(obj, null) != null && x.Name != "path").Select(x => x.Name + "=" + GetValue(x, obj, null));

            return String.Join("&", properties.ToArray());
        }
        private string GetValue(PropertyInfo p, object obj, object[] index)
        {
            if (p.PropertyType.Equals(typeof(DateTime)))
                return ((DateTime)p.GetValue(obj, null)).ToString("yyyy-MM-dd HH:mm:ss");
            return p.GetValue(obj, null)?.ToString();
        }
    }
}
