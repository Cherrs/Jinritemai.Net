using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinritemai.Net.Material
{
    public class UploadImageSyncResponse
    {
        public string audit_status { get; set; }
        public string byte_url { get; set; }
        public string folder_id { get; set; }
        public string is_new { get; set; }
        public string material_id { get; set; }
    }
}
