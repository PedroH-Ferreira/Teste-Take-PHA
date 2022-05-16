using Newtonsoft.Json;

namespace Teste_Take_Blip_PHA.Models
{
    public class License
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("spdx_id")]
        public string Spdx_Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("node_id")]
        public string Node_Id { get; set; }
    }
}
