namespace Teste_Take_Blip_PHA.Configuration
{
    public interface IApiConfig
    {
        public string BaseUrl { get; set; }
    }
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; }
    }
}
