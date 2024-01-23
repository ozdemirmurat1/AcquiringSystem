using Application.Features.Terminals.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalsController:BaseController
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody] CreateTerminalCommand request, CancellationToken cancellationToken)
        {
            CreateTerminalCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
