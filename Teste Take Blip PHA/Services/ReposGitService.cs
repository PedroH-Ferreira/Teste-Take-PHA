using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Teste_Take_Blip_PHA.Configuration;
using Teste_Take_Blip_PHA.Models.Teste_Take.Models;

namespace Teste_Take_Blip_PHA.Services
{
    public class ReposGitService : IReposGitService
    {
        private readonly IApiConfig _apiConfig;
        private readonly HttpClient _httpClient;

        public ReposGitService(IApiConfig apiConfig, HttpClient httpClient)
        {
            _apiConfig = apiConfig;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GitReposModel>> GetAllGitReposOrgs()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GitReposModel>>($"{_apiConfig.BaseUrl}takenet?{_apiConfig.Client_Id}&{_apiConfig.Client_Secret}").ConfigureAwait(false);
        }
    }
}
