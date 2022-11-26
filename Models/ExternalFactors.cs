using Newtonsoft.Json;

namespace Powerplant.API.Models
{
    public class ExternalFactors
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double Gas { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double Kerosine { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double Co2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double Wind { get; set; }
    }
}
