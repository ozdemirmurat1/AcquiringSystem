using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Chains.Queries.GetByIdWithMerchant
{
    public sealed class GetByIdWithMerchantChainQueryHandler : IRequestHandler<GetByIdWithMerchantChainQuery, GetByIdWithMercantChainQueryResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdWithMerchantChainQueryHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules, IMapper mapper)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetByIdWithMercantChainQueryResponse> Handle(GetByIdWithMerchantChainQuery request, CancellationToken cancellationToken)
        {
            await _chainBusinessRules.GetChainExistsCheck(request.id);

            Chain? chain = await _chainRepository.GetAsync(c => c.Id == request.id,include:c=>c.Include(c=>c.Merchants));

            var mappedChainListModel=_mapper.Map<GetByIdWithMercantChainQueryResponse>(chain);

            return mappedChainListModel;
        }
    }
}
