using Application.Services.Repositories;
using Core.Application.Rules;

namespace Application.Features.Chains.Rules
{
    public class ChainBusinessRules:BaseBusinessRules
    {
        private readonly IChainRepository _chainRepository;

        public ChainBusinessRules(IChainRepository chainRepository)
        {
            _chainRepository = chainRepository;
        }
    }
}
