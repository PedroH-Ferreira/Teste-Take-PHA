using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teste_Take_Blip_PHA.Models;

namespace Teste_Take_Blip_PHA.Services
{
    public interface IGitReposRefitService
    {
        [Get("/orgs/takenet/repos")]
        Task<IEnumerable<GitReposModel>> GetAll();
    }
}
