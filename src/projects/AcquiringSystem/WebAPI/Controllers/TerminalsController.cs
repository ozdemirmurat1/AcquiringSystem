using Application.Features.Terminals.Commands.Create;
using Application.Features.Terminals.Commands.Delete;
using Application.Features.Terminals.Commands.Update;
using Application.Features.Terminals.Queries.GetById;
using Application.Features.Terminals.Queries.GetByIdTerminalWithMerchant;
using Application.Features.Terminals.Queries.GetList;
using Application.Features.Terminals.Queries.GetListTerminalWithMerchant;
using Core.Application.Requests;
using Core.Application.Responses;
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

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete([FromBody] DeleteTerminalCommand request, CancellationToken cancellationToken)
        {
            DeleteTerminalCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateTerminalCommand request, CancellationToken cancellationToken)
        {
            UpdateTerminalCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdTerminalQuery getByIdTerminalQuery)
        {
            GetByIdTerminalQueryResponse result = await Mediator.Send(getByIdTerminalQuery);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListTerminalQuery getListTerminalQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListTerminalQueryResponse> result = await Mediator.Send(getListTerminalQuery);
            return Ok(result);

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetListWithMerchant([FromQuery] PageRequest pageRequest)
        {
            GetListTerminalWithMerchantQuery getListTerminalWithMerchantQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListTerminalWithMerchantQueryResponse> result = await Mediator.Send(getListTerminalWithMerchantQuery);
            return Ok(result);

        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByIdTerminalWithMerchant([FromRoute] GetByIdTerminalWithMerchantQuery getByIdTerminalWithMerchantQuery)
        {
            GetByIdTerminalWithMerchantQueryResponse result = await Mediator.Send(getByIdTerminalWithMerchantQuery);
            return Ok(result);
        }
    }
}
