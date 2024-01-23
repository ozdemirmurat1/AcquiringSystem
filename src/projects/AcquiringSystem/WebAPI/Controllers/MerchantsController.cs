using Application.Features.Merchants.Commands.Create;
using Application.Features.Merchants.Commands.Delete;
using Application.Features.Merchants.Commands.Update;
using Application.Features.Merchants.Queries.GetById;
using Application.Features.Merchants.Queries.GetByIdChainAndTerminals;
using Application.Features.Merchants.Queries.GetList;
using Application.Features.Merchants.Queries.GetListChainAndTerminals;
using Core.Application.Requests;
using Core.Application.Responses;
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

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByIdWithChainAndTerminals([FromRoute] GetByIdMerchantWithAllQuery getByIdMerchantQuery)
        {
            GetByIdMerchantWithAllQueryResponse result = await Mediator.Send(getByIdMerchantQuery);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetListAllParameters([FromQuery] PageRequest pageRequest)
        {
            GetListMerchantWithAllQuery getListMerchantWithAll = new() { PageRequest = pageRequest };
            GetListResponse<GetListMerchantWithAllQueryResponse> result = await Mediator.Send(getListMerchantWithAll);
            return Ok(result);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdMerchantQuery getByIdMerchantQuery)
        {
            GetByIdMerchantQueryResponse result = await Mediator.Send(getByIdMerchantQuery);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListMerchantQuery getListMerchantQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListMerchantQueryResponse> result = await Mediator.Send(getListMerchantQuery);
            return Ok(result);

        }
    }
}
