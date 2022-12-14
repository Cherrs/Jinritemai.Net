using Jinritemai.Net.Material;
using Jinritemai.Net.Order;
using Jinritemai.Net.Product;
using Jinritemai.Net.Request.Product;
using Jinritemai.Net.Shop;
using Jinritemai.Net.Sku;
using Jinritemai.Net.Spu;
using System;
using System.Collections.Generic;
using System.Text;
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
        #endregion
        #region Sku
        public static async Task<Result<object>> SyncStock(this JinritemaiClient client, SyncStockRequest request)
        {
            return await client.GetResultAsync<object>(request);
        }
        #endregion
    }
}
