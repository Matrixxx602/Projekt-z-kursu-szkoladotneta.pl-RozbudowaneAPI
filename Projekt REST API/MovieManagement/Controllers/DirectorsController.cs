using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Application.Directors.Command.CreateDirector;
using MovieManagement.Application.Directors.Queries.GetDirectorDetail;
using MovieManagement.Application.Directors.Queries.GetDirectors;
using System.Threading.Tasks;

namespace MovieManagement.Api.Controllers
{
    [Route("api/directors")]
    [Authorize]
    public class DirectorsController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<DirectorDetailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetDirectorDetailQuery() { DirectorId = id });
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDirector(CreateDirectorCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
