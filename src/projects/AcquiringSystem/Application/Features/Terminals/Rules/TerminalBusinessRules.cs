using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Terminals.Rules
{
    public class TerminalBusinessRules:BaseBusinessRules
    {
        private readonly ITerminalRepository _terminalRepository;
        private readonly IMerchantRepository _merchantRepository;

        public TerminalBusinessRules(ITerminalRepository terminalRepository, IMerchantRepository merchantRepository)
        {
            _terminalRepository = terminalRepository;
            _merchantRepository = merchantRepository;
        }

        public Task TerminalShouldBeExistWhenSelected(Terminal? terminal)
        {
            if (terminal == null)
                throw new BusinessException("Terminal Bulunamadı!");

            return Task.CompletedTask;
        }
        public async Task CreateTerminalIdentificationCanNotBeDuplicated(string terminalIdentification)
        {
            var result = await _terminalRepository.AnyAsync(b => b.TerminalIdentification == terminalIdentification);

            if (result) throw new BusinessException("Bu Terminal Numarası zaten mevcut!");
        }

        public async Task UpdateTerminalIdentificationCanNotBeDuplicated(string terminalIdentification, string id)
        {
            var result = await _terminalRepository.AnyAsync(b => b.TerminalIdentification == terminalIdentification && b.Id != id);

            if (result) throw new BusinessException("Bu Terminal Numarası Numarası zaten mevcut!");
        }

        public async Task GetTerminalExistsCheck(string id)
        {
            var result = await _terminalRepository.AnyAsync(b => b.Id == id);

            if (!result) throw new BusinessException("Terminal Bulunamadı!");
        }

        public async Task GetMerchantControlExist(string id)
        {
            var result = await _merchantRepository.AnyAsync(b => b.Id == id);

            if (!result) throw new BusinessException("Üye İş Yeri Bulunamadı");
        }
    }
}

