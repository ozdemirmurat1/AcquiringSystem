using Application.Features.Chains.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Chains.Queries.GetListWithMerchant
{
    public sealed class GetListWithMerchantChainQueryHandler : IRequestHandler<GetListWithMerchantChainQuery, GetListResponse<GetListWithMerchantChainQueryResponse>>
    {
        private readonly IChainRepository _chainRepository;
        private readonly IMapper _mapper;

        public GetListWithMerchantChainQueryHandler(IChainRepository chainRepository, IMapper mapper)
        {
            _chainRepository = chainRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListWithMerchantChainQueryResponse>> Handle(GetListWithMerchantChainQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Chain> chains = await _chainRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                include:c => c.Include(c => c.Merchants),
                cancellationToken: cancellationToken);

            // MAPPER KULLANDIK

            GetListResponse<GetListWithMerchantChainQueryResponse> response = _mapper.Map<GetListResponse<GetListWithMerchantChainQueryResponse>>(chains);
            return response;
        }
    }
}
