﻿using Jinritemai.Net;
using Jinritemai.Net.Iop;
using Jinritemai.Net.Logistics;
using Jinritemai.Net.Material;
using Jinritemai.Net.Order;
using Jinritemai.Net.Product;
using Jinritemai.Net.Shop;
using Jinritemai.Net.Sku;
using Jinritemai.Net.Spu;
using Jinritemai.Net.Tools;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Jinritemai.Net.Tests
{
    [TestClass()]
    public class JinritemaiTests
    {
        private IConfiguration config;
        private JinritemaiClient J;

        public JinritemaiTests()
        {
            config = new ConfigurationBuilder().AddJsonFile("my-config.json").Build();
            J = new JinritemaiClient(config["appkey"], config["secret"], config["url"], config["shopid"]);
        }

        [TestMethod()]
        public async Task GetAccessTokenAsyncTest()
        {
            var result = await J.GetAccessTokenAsync();
        }

        [TestMethod()]
        public async Task GetShopCategoryRequestTest()
        {
            var x = new GetShopCategoryRequest();
            var r = await J.GetShopCategory(x);
            var str = JsonConvert.SerializeObject(r.data);
        }

        [TestMethod()]
        public async Task _QueryBookNameByISBN()
        {
            var isbns = File.ReadAllLines("cat.txt");
            var cats = File.ReadAllLines("c.csv");
            var _tmid = File.ReadAllLines("1.csv");
            var tmid = _tmid.ToDictionary(x => x.Split(',')[0]);
            var catd = cats.ToDictionary(x => Convert.ToInt64(x.Split(',')[0]));
            foreach (var i in isbns)
            {
                var x = new QueryBookNameByISBNRequest();
                x.isbn = i;
                x.page_size = 10;
                x.page_no = 0;
                var r = await J.QueryBookNameByISBN(x);
                try
                {
                    var _t = r.data.data.Select(x => $"{x.spu_id},{catd[x.category_leaf_id]},{i},{tmid[i]},{x.book_name}");
                    await File.AppendAllLinesAsync("isbncat.csv", _t);
                }
                catch
                {
                }
            }
        }

        [TestMethod()]
        public void ggga()
        {
            var rsp = J.GetResultAsync<TemplateListResponse>(new TemplateListRequest { }).Result;
            var p = J.GetPrintParams();
        }

        [TestMethod()]
        public async Task OrderListRequest()
        {
            var x = new OrderListRequest()
            {
                StartUpdateTime = DateTime.Now.AddMinutes(-20),
                EndUpdateTime = DateTime.Now,
                Size = 100,
                Page = 0,
                DistrStatus = 1
            };
            var rsp = await J.GetResultAsync<OrderListResponse>(x);
        }

        [TestMethod()]
        public async Task GetSellerListRequest()
        {
            var x = new GetSellerListRequest()
            {
                BindStatus = [1, 2],
                Page = 0,
                PageSize = 100
            };
            var rsp = await J.GetResultAsync<GetSellerListResponse>(x);
        }

        [TestMethod()]
        public async Task QueryBookNameByISBN()
        {
            var x = new QueryBookNameByISBNRequest();
            x.isbn = "9787552284355";
            x.page_size = 10;
            x.page_no = 0;
            var r = await J.QueryBookNameByISBN(x);
        }

        private async Task gga(long cid)
        {
            var x = new GetShopCategoryRequest();
            x.cid = cid;
            var r = await J.GetShopCategory(x);
            foreach (var i in r.data)
            {
                File.AppendAllLines("c.csv", new string[] { $"{i.id},{i.name}" });
                if (i.is_leaf == false)
                {
                    await gga(i.id);
                }
            }
        }

        #region Order

        [TestMethod()]
        public async Task SearchListRequestTest()
        {
            // await J.GetAccessTokenAsync();
            var x = new SearchListRequest() { update_time_start = DateTime.Now.AddHours(-24), update_time_end = DateTime.Now, size = 100, page = 0/*, combine_status = new List<combine_status> { new combine_status { main_status = 16, order_status = 16 } }*/ };
            var r = await J.GetResultAsync<SearchListResponse>(x);
        }

        [TestMethod()]
        public async Task OrderDetailTest()
        {
            J.ShopID = "7095877";
            await J.GetAccessTokenAsync();
            var x = new OrderDetailRequest() { shop_order_id = "6931667723982804759" };
            var r = await J.GetOrderDetailAsync(x);
        }

        [TestMethod()]
        public async Task BatchDecryptTest()
        {
            await J.GetAccessTokenAsync();
            var x = new BatchDecryptRequest() { cipher_infos = new List<CipherInfos> { new CipherInfos { cipher_text = @"$iXOh30LnmB02MO5p/m45tSP5II4n/pahqyajR3Thw2s=$LiCIJFkK8HEO0L5BKe1DEPOcZJfSsqppnv5dT7QfX/DKiLJjjCjUtctF2V1gvDDfzOKH8C0QA+WG8eNTU0ybG6M1UWYlaXu2xQgnhIowpsX4*CgkIARCtHCABKAESPgo82ubmOAIOYzy5OResbfzaIqNVPbqrWTAm8jU6tvuXxEfod7YugdpJM0lmyep5MctvQiRHepfGKXCTWxqwGgA=$1$$", auth_id = "4874151216487663149" } } };
            var r = await J.BatchDecrypt(x);
        }

        #endregion Order

        #region Logistics

        [TestMethod()]
        public async Task GetShopKeyRequestTest()
        {
            var x = new GetShopKeyRequest();
            var result = await J.GetResultAsync(x);
        }


        [TestMethod("获取面单")]
        public async Task NewCreateOrderRequestTest()
        {
            var x = new NewCreateOrderRequest();
            x.LogisticsCode = "zhongtong";
            x.SenderInfo = new SenderInfo
            {
                Address = new PodModelAddressClass
                {
                    CityName = "南京市",
                    DetailAddress = "仙新路98号",
                    CountryCode = "CHN",
                    ProvinceName = "江苏省",
                    DistrictName = "栖霞区",
                    StreetName = "栖霞经济开发区"
                },
                Contact = new Contact
                {
                    Mobile = "025-85588100",
                    Name = "菲尼克斯图书专营店"
                },

            };
            x.OrderInfos = new List<OrderInfo> {
                new OrderInfo{
                    OrderId = "6925146951201854829",
                    ReceiverInfo = new ReceiverInfo{
                     Address = new ReceiverInfoAddress{
                        ProvinceName = "江苏省",
                        CityName = "苏州市",
                        DistrictName = "昆山市",
                        DetailAddress = "#O8LcGiXJXSH5L7u9dmNCiyxcoVjTvVt/NQlc6JNlZEgrf/ekgTKnKWq9i/LcMANZ#0LCSQZMd+c9yhEZ9+ZVzCA3KzbQoRzyhG47jhl/LIAmkAFImhSggBHjEkYFlrfm4XI/ECw/2Z6+YtbtHB7f9P1NE+UgJpZbM3p8ZQl6qviYW7UBXqPxOT/OGqUiQX6kOYoSXWwm4br6Ozq0c3A==*CgYIASAHKAESPgo8DqAIDUXPdD6QpkaDmkbCRClYaaZ4n8s8mrBk35rMZbBvgE3NafmUiHEJ3eHwk/LYVxOxhPr6a3IyUsSoGgA=#1##"
                     },
                     Contact = new Contact{
                        Name="#J6qA#5iI8DsuFaqbPcZxlqH5kkHm79pFOlhe8AouEwcvDv6IVj6CGunsZRzR+hJS0jNhenSBhfabTXsFq3NtzZWpVvxlqmnhtTSNV8yGQLQ==*CgYIASAHKAESPgo8BVlgRAAXsKqQGM4y0tMzRHa/sMXPlcKMb1fbUmB9lF0KuN0/bBL1mKTC2lnvmcz/I3HQw2QFV+NZ9y7AGgA=#1##",
                        Mobile = "$RPaxMtUURQ429umTpyYIYh+w2zIQsgxOgV+yHhA/Z5s=$OfU3P7ex95RwcF/MVvF66kRh+trCnlba0JQGJHlgGh/B+rVRGvyt1wNyiDGHdJvlxStlDJnJeHZBQoY6r1104RUXpMWfvWnB341IYZwPHxbU*CgYIASAHKAESPgo8Zc6sQD+Lq7yMm6Ox3RJOk//wUwvh/+M61SQ6WVg3MeRW89N96DOKE3r6RbBs7ztoBF6hg2gvCAMU+w8qGgA=$1$$"
                     }
                    },
                    Items = new List<Item>{
                        new Item{
                            ItemName = "shu",
                            ItemCount =1,
                            ItemWeight=100,
                            ItemNetWeight = 100
                        }
                     },
                     NetInfo = new NetInfo{
                        Category = "直营",
                        MonthlyAccount = "1100094331158"
                     }
                }
            };

            var r = await J.GetResultAsync<NewCreateOrderResponse>(x);

            var w = new WaybillApplyRequest() { waybill_applies = r.data.EbillInfos.Select(x => new WaybillApplies { logistics_code = "youzhengguonei", track_no = x.TrackNo }).ToList() };
            var res_r = await J.GetResultAsync<WaybillApplyResponse>(w);

        }

        [TestMethod("抖音获取标准模板")]
        public async Task TemplateListRequestTest()
        {
            var x = new TemplateListRequest();

            var r = await J.GetResultAsync<TemplateListResponse>(x);

        }


        [TestMethod()]
        public async Task OrderLogisticsCompanyListRequestTest()
        {
            var x = new OrderLogisticsCompanyListRequest();

            var r = await J.GetResultAsync<List<OrderLogisticsCompanyListResponse>>(x);
            var str = JsonConvert.SerializeObject(r.data);
        }

        [TestMethod()]
        public async Task OrderLogisticsAddRequestTest()
        {
            await DeliverGoods("4980275202627585743", "YTO", "YT6755141122363", false);
        }

        private async Task DeliverGoods(string Tid, string CompanyCode, string OutSid, bool IsSplit)
        {
            var o = new OrderLogisticsAddRequest() { order_id = Tid, company_code = "yuantong", is_refund_reject = true, logistics_code = OutSid, logistics_id = 7 };
            var token = await J.GetAccessTokenAsync();
            var rsp = await J.GetResultAsync<OrderLogisticsAddResponse>(o);
        }

        #endregion Logistics

        #region Product
        [TestMethod()]
        public async Task QualificationConfig()
        {
            var x = new QualificationConfigRequest();
            x.category_id = 23363;
            var r = await J.QualificationConfig(x);
        }

        #endregion Product
        [TestMethod()]
        public async Task AddV2()
        {
            var s = new GetSpuRequest();
            s.spu_id = 7135803288259150088;
            var sr = await J.GetSpu(s);
            var result = ProductFormatNewBuild.BuildProductFormatNewByPropertyInfo(sr.data.property_infos);
            var x = new AddV2Request();
            x.spu_id = 7135803288259150088;
            x.product_type = 0;
            x.category_leaf_id = 23363;
            x.name = "测试商品勿拍!测试商品勿拍!";
            x.pic = "https://p3-aio.ecombdimg.com/obj/ecom-shop-material/njdUDUW_m_57dec559579857afc2c830210dd7fb3f_sx_579541_www600-600";
            x.description = "https://p3-aio.ecombdimg.com/obj/ecom-shop-material/njdUDUW_m_57dec559579857afc2c830210dd7fb3f_sx_579541_www600-600";
            x.reduce_type = 1;
            x.freight_id = 616006;
            x.mobile = "18552830263";
            x.commit = true;
            x.specs = "规格|图书";
            x.product_format_new = result;
            x.supply_7day_return = 2;
            x.standard_brand_id = 596120136;
            x.presell_type = 0;
            x.delivery_delay_day = 2;
            var r = await J.AddV2(x);
        }

        [TestMethod()]
        public async Task Detail()
        {
            var req = new DetailRequest();
            req.product_id = "3582109616743521364";
            var rsp = await J.Detail(req);
        }
        #region Spu
        [TestMethod()]
        public async Task GetSpu()
        {
            var x = new GetSpuRequest();
            x.spu_id = 7135803288259150088;
            var r = await J.GetSpu(x);
            var result = ProductFormatNewBuild.BuildProductFormatNewByPropertyInfo(r.data.property_infos);
        }
        #endregion

        #region Material
        [TestMethod()]
        public async Task UploadImageSync()
        {
            var x = new UploadImageSyncRequest();
            x.url = "https://douyin-1251151800.cos.ap-nanjing.myqcloud.com/22-1.jpg";
            x.folder_id = "71580217606828526081877";
            x.material_name = "22-1.jpg";
            var r = await J.UploadImageSync(x);
        }
        #endregion
        #region Sku
        [TestMethod()]
        public async Task SyncStock()
        {
            var x = new SyncStockRequest();
            x.product_id = 3579337116603303875;
            x.sku_id = 1747723195830275;
            x.stock_num = 5;
            x.incremental = false;
            var r = await J.SyncStock(x);
        }
        #endregion
        #region Iop
        [TestMethod()]
        public async Task SellerOrderListRequestTest()
        {
            await J.GetAccessTokenAsync();
            var x = new SellerOrderListRequest() { start_update_time = DateTime.Now.AddDays(-10), end_update_time = DateTime.Now, size = 100, page = 0/*, combine_status = new List<combine_status> { new combine_status { main_status = 16, order_status = 16 } }*/ };
            var r = await J.GetIopSellerOrderListAsync(x);
        }
        #endregion
    }
}