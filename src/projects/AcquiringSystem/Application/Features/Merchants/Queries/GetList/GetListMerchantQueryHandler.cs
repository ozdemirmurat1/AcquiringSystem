using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Merchants.Queries.GetList
{
    public sealed class GetListMerchantQueryHandler : IRequestHandler<GetListMerchantQuery, GetListResponse<GetListMerchantQueryResponse>>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;

        public GetListMerchantQueryHandler(IMerchantRepository merchantRepository, IMapper mapper)
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListMerchantQueryResponse>> Handle(GetListMerchantQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Merchant> merchants = await _merchantRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken);

            GetListResponse<GetListMerchantQueryResponse> response = _mapper.Map<GetListResponse<GetListMerchantQueryResponse>>(merchants);

            return response;
        }
    }
}
