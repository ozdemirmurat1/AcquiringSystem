using Application.Features.Merchants.Rules;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Merchants.Commands.Delete
{
    public sealed class DeleteMerchantCommandHandler : IRequestHandler<DeleteMerchantCommand, DeleteMerchantCommandResponse>
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly MerchantBusinessRules _merchantBusinessRules;

        public DeleteMerchantCommandHandler(IMerchantRepository merchantRepository, MerchantBusinessRules merchantBusinessRules)
        {
            _merchantRepository = merchantRepository;
            _merchantBusinessRules = merchantBusinessRules;
        }

        public async Task<DeleteMerchantCommandResponse> Handle(DeleteMerchantCommand request, CancellationToken cancellationToken)
        {
            await _merchantBusinessRules.GetMerchantExistsCheck(request.id);

            Merchant? merchant = await _merchantRepository.GetAsync(predicate: uoc => uoc.Id == request.id,
            cancellationToken: cancellationToken);

            await _merchantRepository.DeleteAsync(merchant!);

            return new();
        }
    }
}
