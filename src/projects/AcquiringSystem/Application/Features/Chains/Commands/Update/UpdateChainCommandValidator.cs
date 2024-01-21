using FluentValidation;

namespace Application.Features.Chains.Commands.Update
{
    public sealed class UpdateChainCommandValidator:AbstractValidator<UpdateChainCommand>
    {
        public UpdateChainCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı boş olamaz!");
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
