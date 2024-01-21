using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Chains.Rules
{
    public class ChainBusinessRules:BaseBusinessRules
    {
        private readonly IChainRepository _chainRepository;

        public ChainBusinessRules(IChainRepository chainRepository)
        {
            _chainRepository = chainRepository;
        }

        public async Task CreateChainCodeCanNotBeDuplicated(string chainCode)
        {
            var result=await _chainRepository.AnyAsync(b=>b.ChainCode == chainCode);

            if (result) throw new BusinessException("Chain Code Already Exits");
        }

        public async Task GetChainExistsCheck(string id)
        {
            var result=await _chainRepository.GetAsync(b=>b.Id == id);

            if (result == null) throw new BusinessException("Bu İşyeri Bulunamadı!");
        }

        public async Task UpdateChainCodeCanNotBeDuplicated(string chainCode,string id)
        {
            var result = await _chainRepository.AnyAsync(b => b.ChainCode == chainCode && b.Id!=id);

            if (result) throw new BusinessException("Chain Code Already Exits");
        }

        public Task TaskChainShouldExistWhenSelected(Chain? chain)
        {
            if (chain == null)
                throw new BusinessException("İş Yeri Bulunamadı!");

            return Task.CompletedTask;
        }
    }
}
