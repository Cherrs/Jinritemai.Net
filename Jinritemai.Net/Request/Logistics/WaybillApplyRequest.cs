using System;
using System.Collections.Generic;
using System.Text;

namespace Jinritemai.Net.Logistics
{
    public class WaybillApplyRequest : IRequest
    {
        public string method { get; set; } = "logistics.waybillApply";
        public string path { get; set; } = "/logistics/waybillApply";

        public List<WaybillApplies> waybill_applies { get; set; }
    }

    public class WaybillApplies
    {
        public string logistics_code { get; set; }
        public string track_no { get; set; }

    }
}
