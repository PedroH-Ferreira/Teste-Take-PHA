using Newtonsoft.Json;

namespace Teste_Take_Blip_PHA.Models
{
    public class Owner
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("node_id")]
        public string Node_Id { get; set; }
        [JsonProperty("avatar_url")]
        public string Avatar_Url { get; set; }
        [JsonProperty("gravatar_id")]
        public string Gravatar_Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("html_url")]
        public string Html_Url { get; set; }
        [JsonProperty("followers_url")]
        public string Followers_Url { get; set; }
        [JsonProperty("following_url")]
        public string Following_Url { get; set; }
        [JsonProperty("gists_url")]
        public string Gists_Url { get; set; }
        [JsonProperty("starred_url")]
        public string Starred_Url { get; set; }
        [JsonProperty("subscriptions_url")]
        public string Subscriptions_Url { get; set; }
        [JsonProperty("organizations_url")]
        public string Organizations_Url { get; set; }
        [JsonProperty("repos_url")]
        public string Repos_Url { get; set; }
        [JsonProperty("events_url")]
        public string Events_Url { get; set; }
        [JsonProperty("received_events_url")]
        public string Received_Events_Url { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("site_admin")]
        public bool? Site_Admin { get; set; }
    }
}
