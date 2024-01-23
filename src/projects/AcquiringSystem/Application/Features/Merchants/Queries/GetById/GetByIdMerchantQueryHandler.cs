using Application.Features.Merchants.Queries.GetByIdChainAndTerminals;
using Application.Features.Merchants.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Merchants.Queries.GetById
{
    public sealed class GetByIdMerchantQueryHandler : IRequestHandler<GetByIdMerchantQuery, GetByIdMerchantQueryResponse>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;
        private readonly MerchantBusinessRules _merchantBusinessRules;

        public GetByIdMerchantQueryHandler(IMerchantRepository merchantRepository, IMapper mapper, MerchantBusinessRules merchantBusinessRules)
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;
            _merchantBusinessRules = merchantBusinessRules;
        }

        public async Task<GetByIdMerchantQueryResponse> Handle(GetByIdMerchantQuery request, CancellationToken cancellationToken)
        {
            await _merchantBusinessRules.GetMerchantExistsCheck(request.id);

            Merchant? merchant = await _merchantRepository.GetAsync(
                c => c.Id == request.id,
                cancellationToken:cancellationToken);

            var mappedMerchantListModel = _mapper.Map<GetByIdMerchantQueryResponse>(merchant);

            return mappedMerchantListModel;
        }
    }
}
