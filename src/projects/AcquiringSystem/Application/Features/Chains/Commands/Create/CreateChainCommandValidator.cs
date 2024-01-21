using FluentValidation;

namespace Application.Features.Chains.Commands.Create
{
    public sealed class CreateChainCommandValidator:AbstractValidator<CreateChainCommand>
    {
        public CreateChainCommandValidator()
        {
            RuleFor(p => p.ChainCode).NotEmpty().WithMessage("İş Yeri Kodu boş olamaz!");
            RuleFor(p => p.ChainCode).NotNull().WithMessage("İş Yeri Kodu boş olamaz!");
            RuleFor(p => p.TaxAdministration).NotEmpty().WithMessage("Vergi Dairesi boş olamaz!");
            RuleFor(p => p.TaxAdministration).NotNull().WithMessage("Vergi Dairesi boş olamaz!");
            RuleFor(p => p.ChamberOfCommerce).NotEmpty().WithMessage("Ticaret Odası boş olamaz!");
            RuleFor(p => p.ChamberOfCommerce).NotNull().WithMessage("Ticaret Odası boş olamaz!");
            RuleFor(p => p.IdType).NotNull().WithMessage("Kimlik Tipi boş olamaz!");
            RuleFor(p => p.IdType).NotEmpty().WithMessage("Kimlik Tipi boş olamaz!");
        }
    }
}
