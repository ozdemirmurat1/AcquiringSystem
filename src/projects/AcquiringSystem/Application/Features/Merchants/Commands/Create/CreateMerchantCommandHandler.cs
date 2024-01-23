using Application.Features.Merchants.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Merchants.Commands.Create
{
    public sealed class CreateMerchantCommandHandler : IRequestHandler<CreateMerchantCommand, CreateMerchantCommandResponse>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly MerchantBusinessRules _merchantBusinessRules;
        private readonly IMapper _mapper;

        public CreateMerchantCommandHandler(IMerchantRepository merchantRepository, MerchantBusinessRules merchantBusinessRules, IMapper mapper)
        {
            _merchantRepository = merchantRepository;
            _merchantBusinessRules = merchantBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreateMerchantCommandResponse> Handle(CreateMerchantCommand request, CancellationToken cancellationToken)
        {
            await _merchantBusinessRules.CreateMerchantNumberCanNotBeDuplicated(request.MerchantNumber);
            await _merchantBusinessRules.GetChainControlExist(request.ChainId);

            Merchant merchant = _mapper.Map<Merchant>(request);

            merchant.Id=Guid.NewGuid().ToString();

            await _merchantRepository.AddAsync(merchant);

            return new();
        }
    }
}
