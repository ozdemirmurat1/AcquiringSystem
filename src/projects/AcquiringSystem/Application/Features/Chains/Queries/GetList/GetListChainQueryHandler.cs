using Application.Features.Chains.Queries.GetListWithMerchant;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Chains.Queries.GetList
{
    public sealed class GetListChainQueryHandler : IRequestHandler<GetListChainQuery, ResponseDto<GetListResponse<GetListChainQueryResponse>>>
    {
        private readonly IChainRepository _chainRepository;
        private readonly IMapper _mapper;

        public GetListChainQueryHandler(IChainRepository chainRepository, IMapper mapper)
        {
            _chainRepository = chainRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<GetListResponse<GetListChainQueryResponse>>> Handle(GetListChainQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Chain> chains = await _chainRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken:cancellationToken);


            GetListResponse<GetListChainQueryResponse> response = _mapper.Map<GetListResponse<GetListChainQueryResponse>>(chains);

            var responseDto = new Core.Application.Responses.ResponseDto<GetListResponse<GetListChainQueryResponse>>
            {
                Data = response,
            };
                
            return responseDto;


        }
    }
}
