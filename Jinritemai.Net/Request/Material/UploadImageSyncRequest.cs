using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Material
{
    public class UploadImageSyncRequest:IRequest
    {
        public string method { get; set; } = "material.uploadImageSync";
        public string path { get; set; } = "/material/uploadImageSync";
        public string folder_id { get; set; }
        public string url { get; set; }
        public string material_name { get; set; }
        public string file_uri { get; set; }
    }
}
