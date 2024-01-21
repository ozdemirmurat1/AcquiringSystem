using Application.Features.Chains.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChainsController:BaseController
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateChain(CreateChainCommand request, CancellationToken cancellationToken)
        {
            CreateChainCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
