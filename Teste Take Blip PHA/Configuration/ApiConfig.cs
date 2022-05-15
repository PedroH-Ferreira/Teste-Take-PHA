namespace Teste_Take_Blip_PHA.Configuration
{
    public interface IApiConfig
    {
        public string BaseUrl { get; set; }
        public string Client_Id { get; set; }
        public string Client_Secret { get; set; }
    }
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; }
        public string Client_Id { get; set; }
        public string Client_Secret { get; set; }
    }
}
