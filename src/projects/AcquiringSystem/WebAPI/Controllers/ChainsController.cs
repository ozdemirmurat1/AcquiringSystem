﻿using Application.Features.Chains.Commands.Create;
using Application.Features.Chains.Commands.Delete;
using Application.Features.Chains.Commands.Update;
using Application.Features.Chains.Queries.GetById;
using Application.Features.Chains.Queries.GetByIdWithMerchant;
using Application.Features.Chains.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdChainQuery getByIdChainQuery)
        {
            GetByIdChainQueryResponse result = await Mediator.Send(getByIdChainQuery);
            return Ok(result);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByIdWithMerchant([FromRoute] GetByIdWithMerchantChainQuery getByIdWithMerchantChainQuery)
        {
            GetByIdWithMercantChainQueryResponse result = await Mediator.Send(getByIdWithMerchantChainQuery);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery]PageRequest pageRequest)
        {
            GetListChainQuery getListChainQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListChainQueryResponse> result = await Mediator.Send(getListChainQuery);
            return Ok(result);

        }


    }
}
