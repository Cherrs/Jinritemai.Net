namespace Jinritemai.Net.Logistics
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TemplateListResponse
    {
        [JsonProperty("template_data")]
        public List<TemplateDatum> TemplateData { get; set; }
    }

    public partial class TemplateDatum
    {
        [JsonProperty("logistics_code")]
        public string LogisticsCode { get; set; }

        [JsonProperty("template_infos")]
        public List<TemplateInfo> TemplateInfos { get; set; }
    }

    public partial class TemplateInfo
    {
        [JsonProperty("perview_url")]
        public Uri PerviewUrl { get; set; }

        [JsonProperty("template_code")]
        public string TemplateCode { get; set; }

        [JsonProperty("template_id")]
        public long TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("template_type")]
        public long TemplateType { get; set; }

        [JsonProperty("template_url")]
        public Uri TemplateUrl { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }
}
