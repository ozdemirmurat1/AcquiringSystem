using FluentValidation;

namespace Application.Features.Merchants.Commands.Update
{
    public sealed class UpdateMerchantCommandValidator:AbstractValidator<UpdateMerchantCommand>
    {
        public UpdateMerchantCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.MerchantNumber).NotEmpty().WithMessage("Üye İş Yeri Numarası boş olamaz!");
            RuleFor(p => p.MerchantNumber).NotNull().WithMessage("Üye İş Yeri Numarası boş olamaz!");
            RuleFor(p => p.MerchantName).NotEmpty().WithMessage("Üye İş Yeri Adı boş olamaz!");
            RuleFor(p => p.MerchantName).NotNull().WithMessage("Üye İş Yeri Adı boş olamaz!");
            RuleFor(p => p.Province).NotEmpty().WithMessage("İl Alanı boş olamaz!");
            RuleFor(p => p.Province).NotNull().WithMessage("İl Alanı boş olamaz!");
            RuleFor(p => p.District).NotEmpty().WithMessage("İlçe Alanı boş olamaz!");
            RuleFor(p => p.District).NotNull().WithMessage("İlçe Alanı boş olamaz!");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Adres Alanı boş olamaz!");
            RuleFor(p => p.Address).NotNull().WithMessage("Adres Alanı boş olamaz!");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email Alanı boş olamaz!");
            RuleFor(p => p.Email).NotNull().WithMessage("Email Alanı boş olamaz!");
            RuleFor(p => p.TelephoneNumber).NotEmpty().WithMessage("Telefon Numarası boş olamaz!");
            RuleFor(p => p.TelephoneNumber).NotNull().WithMessage("Telefon Numarası olamaz!");
        }
    }
}
