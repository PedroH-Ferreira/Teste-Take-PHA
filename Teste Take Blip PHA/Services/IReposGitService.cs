using System.Collections.Generic;
using System.Threading.Tasks;
using Teste_Take_Blip_PHA.Models;

namespace Teste_Take_Blip_PHA.Services
{
    public interface IReposGitService
    {
        Task<IEnumerable<GitReposModel>> GetAllGitReposOrgs();
    }
}
