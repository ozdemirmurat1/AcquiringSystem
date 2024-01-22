using Application.Features.Merchants.Commands.Create;
using Application.Features.Merchants.Commands.Delete;
using Application.Features.Merchants.Commands.Update;
using Application.Features.Merchants.Queries.GetByIdChainAndTerminals;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantsController:BaseController
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Create([FromBody]CreateMerchantCommand request, CancellationToken cancellationToken)
        {
            CreateMerchantCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete([FromBody] DeleteMerchantCommand request, CancellationToken cancellationToken)
        {
            DeleteMerchantCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateMerchantCommand request, CancellationToken cancellationToken)
        {
            UpdateMerchantCommandResponse response = await Mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdWithChainAndTerminals([FromRoute] GetByIdMerchantQuery getByIdMerchantQuery)
        {
            GetByIdMerchantQueryResponse result = await Mediator.Send(getByIdMerchantQuery);
            return Ok(result);
        }
    }
}
