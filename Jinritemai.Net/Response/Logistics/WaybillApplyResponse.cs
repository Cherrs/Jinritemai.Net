using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jinritemai.Net.Logistics
{
    public class WaybillApplyResponse
    {
        [JsonProperty("err_infos")]
        public List<ErrInfos> err_infos { get; set; }

        [JsonProperty("waybill_infos")]
        public List<WaybillInfo> waybill_infos { get; set; }
    }

    public class WaybillInfo
    {
        public string order_id { get; set; }
        public string track_no { get; set; }
        public string print_data { get; set; }
        public string sign { get; set; }

    }
    public class ErrInfos
    {
        public string track_no { get; set; }
        public string order_id { get; set; }
        public int err_code { get; set; }
        public string err_msg { get; set; }

    }
}

