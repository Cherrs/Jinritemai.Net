using Jinritemai.Net.Alliance;
using Jinritemai.Net.Iop;
using Jinritemai.Net.Material;
using Jinritemai.Net.Order;
using Jinritemai.Net.Product;
using Jinritemai.Net.Shop;
using Jinritemai.Net.Sku;
using Jinritemai.Net.Spu;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Jinritemai.Net
{
    public static class JinritemaiExtensions
    {
        public static async Task<Result<OrderDetailResponse>> GetOrderDetailAsync(this JinritemaiClient client, OrderDetailRequest request)
        {
            return await client.GetResultAsync<OrderDetailResponse>(request);
        }
        public static async Task<Result<SearchListResponse>> GetOrdersAsync(this JinritemaiClient client, SearchListRequest request)
        {
            return await client.GetResultAsync<SearchListResponse>(request);
        }
        public static async Task<Result<BatchDecryptResponse>> BatchDecrypt(this JinritemaiClient client, BatchDecryptRequest request)
        {
            return await client.GetResultAsync<BatchDecryptResponse>(request);
        }

        /// <summary>
        /// 适配云内调用，自用
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<Result<BatchDecryptResponse>> BatchDecrypt(this JinritemaiClient client, BatchDecryptRequest request, string url)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await client.http.PostAsync($"{url}/orders/BatchDecrypt", content);
            var result_str = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Result<BatchDecryptResponse>>(result_str);
        }
        public static async Task<Result<List<GetShopCategoryResponse>>> GetShopCategory(this JinritemaiClient client, GetShopCategoryRequest request)
        {
            return await client.GetResultAsync<List<GetShopCategoryResponse>>(request);
        }
        public static async Task<Result<QueryBookNameByISBNResponse>> QueryBookNameByISBN(this JinritemaiClient client, QueryBookNameByISBNRequest request)
        {
            return await client.GetResultAsync<QueryBookNameByISBNResponse>(request);
        }
        public static async Task<Result<QualificationConfigResponse>> QualificationConfig(this JinritemaiClient client, QualificationConfigRequest request)
        {
            return await client.GetResultAsync<QualificationConfigResponse>(request);
        }
        #region Spu
        public static async Task<Result<GetSpuResponse>> GetSpu(this JinritemaiClient client, GetSpuRequest request)
        {
            return await client.GetResultAsync<GetSpuResponse>(request);
        }
        #endregion

        #region Product
        public static async Task<Result<BrandListResponse>> BrandList(this JinritemaiClient client, BrandListRequest request)
        {
            return await client.GetResultAsync<BrandListResponse>(request);
        }
        public static async Task<Result<AddV2Response>> AddV2(this JinritemaiClient client, AddV2Request request)
        {
            return await client.GetResultAsync<AddV2Response>(request);
        }
        public static async Task<Result<object>> EditV2(this JinritemaiClient client, EditV2Request request)
        {
            return await client.GetResultAsync<object>(request);
        }
        public static async Task<Result<object>> SetOffline(this JinritemaiClient client, SetOfflineRequest request)
        {
            return await client.GetResultAsync<object>(request);
        }
        public static async Task<Result<DetailResponse>> Detail(this JinritemaiClient client, DetailRequest request)
        {
            return await client.GetResultAsync<DetailResponse>(request);
        }
        #endregion
        #region Material
        public static async Task<Result<UploadImageSyncResponse>> UploadImageSync(this JinritemaiClient client, UploadImageSyncRequest request)
        {
            return await client.GetResultAsync<UploadImageSyncResponse>(request);
        }
        public static async Task<Result<QueryMaterialDetailResponse>> QueryMaterialDetail(this JinritemaiClient client, string MaterialId)
        {
            return await client.GetResultAsync<QueryMaterialDetailResponse>(new QueryMaterialDetailRequest { material_id = MaterialId });
        }
        #endregion
        #region Sku
        public static async Task<Result<object>> SyncStock(this JinritemaiClient client, SyncStockRequest request)
        {
            return await client.GetResultAsync<object>(request);
        }
        public static async Task<Result<object>> SkuEditPrice(this JinritemaiClient client, EditPriceRequest request)
        {
            return await client.GetResultAsync<object>(request);
        }
        #endregion

        #region Iop
        public static async Task<string> GetIopSellerOrderListAsync(this JinritemaiClient client, SellerOrderListRequest request)
        {
            return await client.GetJsonResultAsync(request);
        }
        #endregion

        #region Alliance
        public static async Task<Result<GetOrderListResponse>> GetOrderList(this JinritemaiClient client, GetOrderListRequest request)
        {
            return await client.GetResultAsync<GetOrderListResponse>(request);
        }
        #endregion
    }
}
