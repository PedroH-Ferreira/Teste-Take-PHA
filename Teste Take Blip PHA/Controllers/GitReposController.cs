using Microsoft.AspNetCore.Mvc;
using Refit;
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

        //Http Client
        [HttpGet("GetAllRepos")]
        public async Task<ActionResult> GetGitRepositore()
        {
            return Ok(await _reposGitService.GetAllGitReposOrgs().ConfigureAwait(false));
        }

        //Refit
        [HttpGet("GetAllGitRepos")]
        public async Task<ActionResult> GetAll()
        {
            var api = RestService.For<IGitReposRefitService>("https://api.github.com/");

            return Ok(await api.GetAll().ConfigureAwait(false));
        }
    }
}
