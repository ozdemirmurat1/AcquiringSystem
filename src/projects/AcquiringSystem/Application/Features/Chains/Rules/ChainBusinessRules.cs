using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Application.Features.Chains.Rules
{
    public class ChainBusinessRules:BaseBusinessRules
    {
        private readonly IChainRepository _chainRepository;

        public ChainBusinessRules(IChainRepository chainRepository)
        {
            _chainRepository = chainRepository;
        }

        public async Task ChainCodeCanNotBeDuplicated(string chainCode)
        {
            var result=await _chainRepository.GetListAsync(b=>b.ChainCode == chainCode);

            if (result.Items.Any()) throw new BusinessException("Chain Code Already Exits");
        }
    }
}
