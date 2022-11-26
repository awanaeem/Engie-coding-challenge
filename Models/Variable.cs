using Newtonsoft.Json;
using Powerplant.API.Helpers;

namespace Powerplant.API.Models
{
    public class Variable
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public PowerplantType Type { get; set; }

        [JsonProperty(PropertyName = "efficiency")]
        public double Efficiency { get; set; }

        [JsonProperty(PropertyName = "pmin")]
        public int PMin { get; set; }

        [JsonProperty(PropertyName = "pmax")]
        public int PMax { get; set; }

        public double RunningCost { get; set; }
    }
}
