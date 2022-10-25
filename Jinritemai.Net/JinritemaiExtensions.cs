using Jinritemai.Net.Order;
using Jinritemai.Net.Product;
using Jinritemai.Net.Shop;
using Jinritemai.Net.Spu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net
{
    public static class JinritemaiExtensions
    {
        public static async Task<Result<OrderDetailResponse>> GetOrderDetailAsync(this Jinritemai client, OrderDetailRequest request)
        {
            return await client.GetResultAsync<OrderDetailResponse>(request);
        }
        public static async Task<Result<SearchListResponse>> GetOrdersAsync(this Jinritemai client, SearchListRequest request)
        {
            return await client.GetResultAsync<SearchListResponse>(request);
        }
        public static async Task<Result<BatchDecryptResponse>> BatchDecrypt(this Jinritemai client, BatchDecryptRequest request)
        {
            return await client.GetResultAsync<BatchDecryptResponse>(request);
        }
        public static async Task<Result<List<GetShopCategoryResponse>>> GetShopCategory(this Jinritemai client, GetShopCategoryRequest request)
        {
            return await client.GetResultAsync<List<GetShopCategoryResponse>>(request);
        }
        public static async Task<Result<QueryBookNameByISBNResponse>> QueryBookNameByISBN(this Jinritemai client, QueryBookNameByISBNRequest request)
        {
            return await client.GetResultAsync<QueryBookNameByISBNResponse>(request);
        }
        public static async Task<Result<QualificationConfigResponse>> QualificationConfig(this Jinritemai client, QualificationConfigRequest request)
        {
            return await client.GetResultAsync<QualificationConfigResponse>(request);
        }
        #region Spu
        public static async Task<Result<GetSpuResponse>> GetSpu(this Jinritemai client, GetSpuRequest request)
        {
            return await client.GetResultAsync<GetSpuResponse>(request);
        }
        #endregion

        #region Product
        public static async Task<Result<AddV2Response>> AddV2(this Jinritemai client, AddV2Request request)
        {
            return await client.GetResultAsync<AddV2Response>(request);
        }
        #endregion
    }
}
