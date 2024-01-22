using Application.Features.Merchants.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Merchants.Queries.GetByIdChainAndTerminals
{
    public sealed class GetByIdMerchantQueryHandler : IRequestHandler<GetByIdMerchantQuery, GetByIdMerchantQueryResponse>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;
        private readonly MerchantBusinessRules _merchantsBusinessRules;

        public GetByIdMerchantQueryHandler(IMerchantRepository merchantRepository, IMapper mapper, MerchantBusinessRules merchantsBusinessRules)
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;
            _merchantsBusinessRules = merchantsBusinessRules;
        }

        public async Task<GetByIdMerchantQueryResponse> Handle(GetByIdMerchantQuery request, CancellationToken cancellationToken)
        {
            await _merchantsBusinessRules.GetMerchantExistsCheck(request.id);

            Merchant? merchant = await _merchantRepository.GetAsync(
                c => c.Id == request.id, 
                include: c => c.Include(c => c.Chain).Include(c => c.Terminals));

            var mappedMerchantListModel = _mapper.Map<GetByIdMerchantQueryResponse>(merchant);

            return mappedMerchantListModel;
        }
    }

}
