using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Teste_Take_Blip_PHA.Configuration;
using Teste_Take_Blip_PHA.Models;

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

        public async Task<ICollection<GitReposModelResponse>> GetAllGitReposOrgs()
        {
            try
            {
                ICollection<GitReposModel> responseGit = await _httpClient.GetFromJsonAsync<ICollection<GitReposModel>>($"{_apiConfig.BaseUrl}orgs/takenet/repos?{_apiConfig.Client_Id}&{_apiConfig.Client_Secret}").ConfigureAwait(false);
                var gitRepositores = responseGit.OrderBy(git => git.Created_At);
                var repositores = new List<GitReposModelResponse>();

                foreach (var repositore in gitRepositores)
                {
                    repositores.Add(
                        new GitReposModelResponse
                        {
                            FullName = repositore.Full_Name,
                            Description = repositore.Description,
                            AvatarImg = repositore.Owner.Avatar_Url,
                            CreatedAt = repositore.Created_At,
                        });
                }

                return repositores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
