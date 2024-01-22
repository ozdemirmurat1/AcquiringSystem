using Application.Features.Merchants.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Merchants.Commands.Update
{
    public sealed class UpdateMerchantCommandHandler : IRequestHandler<UpdateMerchantCommand, UpdateMerchantCommandResponse>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly MerchantBusinessRules _merchantBusinessRules;
        private readonly IMapper _mapper;

        public UpdateMerchantCommandHandler(IMerchantRepository merchantRepository, MerchantBusinessRules merchantBusinessRules, IMapper mapper)
        {
            _merchantRepository = merchantRepository;
            _merchantBusinessRules = merchantBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdateMerchantCommandResponse> Handle(UpdateMerchantCommand request, CancellationToken cancellationToken)
        {
            await _merchantBusinessRules.GetMerchantExistsCheck(request!.id);

            Merchant? merchant = await _merchantRepository.GetAsync(predicate: u => u.Id == request.id, cancellationToken: cancellationToken);

            await _merchantBusinessRules.GetChainControlExist(request.ChainId);
            await _merchantBusinessRules.UpdateMerchantNumberCanNotBeDuplicated(merchant!.MerchantNumber, merchant.Id);

            merchant=_mapper.Map(request,merchant);

            await _merchantRepository.UpdateAsync(merchant);

            return new();
        }
    }
}
