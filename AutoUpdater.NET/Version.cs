using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutoUpdater.NET
{
    public class MandatoryStyle
    {
        [JsonProperty("hideCloseButton", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideCloseButton { get; set; }

        [JsonProperty("forceUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceUpdate { get; set; }
    }

    public class VersionInfo
    {
        public static VersionInfo[] FromJson(string json) => JsonConvert.DeserializeObject<VersionInfo[]>(json, Converter.Settings);

        [JsonProperty("version")]
        public string VersionNumber { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonProperty("changelog", NullValueHandling = NullValueHandling.Ignore)]
        public string Changelog { get; set; }

        [JsonProperty("mandatory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatory { get; set; }

        [JsonProperty("mandatoryStyle", NullValueHandling = NullValueHandling.Include)]
        public MandatoryStyle MandatoryStyle { get; set; }
    }

    public static class Serialize
    {
        public static string ToJson(this VersionInfo[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
