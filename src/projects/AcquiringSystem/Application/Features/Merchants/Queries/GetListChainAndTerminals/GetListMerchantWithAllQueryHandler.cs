using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Merchants.Queries.GetListChainAndTerminals
{
    public sealed class GetListMerchantWithAllQueryHandler : IRequestHandler<GetListMerchantWithAllQuery, GetListResponse<GetListMerchantWithAllQueryResponse>>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;

        public GetListMerchantWithAllQueryHandler(IMerchantRepository merchantRepository, IMapper mapper)
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListMerchantWithAllQueryResponse>> Handle(GetListMerchantWithAllQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Merchant> merchants = await _merchantRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                include: c => c.Include(c => c.Chain).Include(c=>c.Terminals),
                cancellationToken: cancellationToken);

            GetListResponse<GetListMerchantWithAllQueryResponse> response = _mapper.Map<GetListResponse<GetListMerchantWithAllQueryResponse>>(merchants);

            return response;
        }
    }
}
