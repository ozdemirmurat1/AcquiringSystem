using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Merchants.Rules
{
    public class MerchantBusinessRules:BaseBusinessRules
    {
        private readonly IMerchantRepository _merchantRepository;

        public MerchantBusinessRules(IMerchantRepository merchantRepository)
        {
            _merchantRepository = merchantRepository;
        }

        public Task MerchantShouldBeExistWhenSelected(Merchant? merchant)
        {
            if (merchant == null)
                throw new BusinessException("Üye İş Yeri Bulunamadı!");

            return Task.CompletedTask;
        }
        public async Task CreateMerchantNumberCanNotBeDuplicated(string merchantNumber)
        {
            var result = await _merchantRepository.AnyAsync(b => b.MerchantNumber == merchantNumber);

            if (result) throw new BusinessException("Bu Üye İş Yeri Numarası zaten mevcut!");
        }

        public async Task UpdateMerchantNumberCanNotBeDuplicated(string merchantNumber, string id)
        {
            var result = await _merchantRepository.AnyAsync(b => b.MerchantNumber == merchantNumber && b.Id != id);

            if (result) throw new BusinessException("Bu Üye İş Yeri Numarası zaten mevcut!");
        }

        public async Task GetMerchantExistsCheck(string id)
        {
            var result = await _merchantRepository.AnyAsync(b => b.Id == id);

            if (!result) throw new BusinessException("Üye İşyeri Bulunamadı!");
        }
    }
}
