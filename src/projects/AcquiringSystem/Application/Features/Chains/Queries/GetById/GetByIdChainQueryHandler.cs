using Application.Features.Chains.Rules;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Chains.Queries.GetById
{
    public sealed class GetByIdChainQueryHandler : IRequestHandler<GetByIdChainQuery, GetByIdChainQueryResponse>
    {
        private readonly IChainRepository _chainRepository;
        private readonly ChainBusinessRules _chainBusinessRules;

        public GetByIdChainQueryHandler(IChainRepository chainRepository, ChainBusinessRules chainBusinessRules)
        {
            _chainRepository = chainRepository;
            _chainBusinessRules = chainBusinessRules;
        }

        public async Task<GetByIdChainQueryResponse> Handle(GetByIdChainQuery request, CancellationToken cancellationToken)
        {
            await _chainBusinessRules.GetChainExistsCheck(request.id);

            Chain? chain=await _chainRepository.GetAsync(c=>c.Id==request.id);

            GetByIdChainQueryResponse response = new(
                ChainCode:chain.ChainCode,
                TaxAdministration:chain.TaxAdministration,
                ChamberOfCommerce:chain.ChamberOfCommerce,
                IdType:chain.IdType
                );
            
            return response;
        }
    }
}
