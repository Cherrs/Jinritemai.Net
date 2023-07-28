using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Material
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class PhotoInfo
    {
        public string format { get; set; }
        public string height { get; set; }
        public string width { get; set; }
    }

    public class QueryMaterialDetailResponse
    {
        public MaterialInfo material_info { get; set; }
    }

    public class MaterialInfo
    {
        public string audit_reject_desc { get; set; }
        public int audit_status { get; set; }
        public string byte_url { get; set; }
        public string create_time { get; set; }
        public string delete_time { get; set; }
        public string folder_id { get; set; }
        public string material_id { get; set; }
        public string material_type { get; set; }
        public string materil_name { get; set; }
        public string operate_status { get; set; }
        public string origin_url { get; set; }
        public PhotoInfo photo_info { get; set; }
        public string size { get; set; }
        public string update_time { get; set; }
        public VideoInfo video_info { get; set; }
    }

    public class VideoInfo
    {
        public string duration { get; set; }
        public string format { get; set; }
        public string height { get; set; }
        public string vid { get; set; }
        public string video_cover_url { get; set; }
        public string width { get; set; }
    }

}
