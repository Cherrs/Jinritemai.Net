using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Jinritemai.Net
{
    public interface IRequest
    {
        [JsonIgnore]
        string method { get; set; }
        [JsonIgnore]
        string path { get; set; }
    }
}
