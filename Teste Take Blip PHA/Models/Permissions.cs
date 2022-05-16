using Newtonsoft.Json;

namespace Teste_Take_Blip_PHA.Models
{
    public class Permissions
    {
        [JsonProperty("admin")]
        public bool? Admin { get; set; }
        [JsonProperty("maintain")]
        public bool? Maintain { get; set; }
        [JsonProperty("push")]
        public bool? Push { get; set; }
        [JsonProperty("triage")]
        public bool? Triage { get; set; }
        [JsonProperty("pull")]
        public bool? Pull { get; set; }
    }
}
