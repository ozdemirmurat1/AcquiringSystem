using Application.Features.Chains.Commands.Create;
using Application.Features.Chains.Commands.Delete;
using Application.Features.Chains.Commands.Update;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChainsController:BaseController
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateChainCommand request, CancellationToken cancellationToken)
        {
            CreateChainCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UpdateChainCommand request, CancellationToken cancellationToken)
        {
            UpdateChainCommandResponse response = await Mediator.Send(request,cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(DeleteChainCommand request, CancellationToken cancellationToken)
        {
            DeleteChainCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }


    }
}
