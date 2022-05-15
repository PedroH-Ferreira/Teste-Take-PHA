using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Teste_Take_Blip_PHA.Services;

namespace Teste_Take_Blip_PHA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitReposController : Controller
    {
        private readonly IReposGitService _reposGitService;

        public GitReposController(IReposGitService reposGitService)
        {
            _reposGitService = reposGitService;
        }

        [HttpGet("GetAllRepos")]
        public async Task<ActionResult> GetGitRepositore()
        {
            return Ok(await _reposGitService.GetAllGitReposOrgs().ConfigureAwait(false));
        }
    }
}
