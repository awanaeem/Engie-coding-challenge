using Newtonsoft.Json;

namespace Powerplant.API.Dtos
{
    public class PerformanceOutputsDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "p")]
        public int Power { get; set; }
    }
}
