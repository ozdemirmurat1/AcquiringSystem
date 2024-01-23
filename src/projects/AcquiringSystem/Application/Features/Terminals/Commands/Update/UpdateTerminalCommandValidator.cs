using FluentValidation;

namespace Application.Features.Terminals.Commands.Update
{
    public sealed class UpdateTerminalCommandValidator:AbstractValidator<UpdateTerminalCommand>
    {
        public UpdateTerminalCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.TerminalIdentification).NotEmpty().WithMessage("Terminal Numarası boş olamaz!");
            RuleFor(p => p.TerminalIdentification).NotNull().WithMessage("Terminal Numarası boş olamaz!");
            RuleFor(p => p.InformationMessage).NotEmpty().WithMessage("Bilgilendirme Mesajı boş olamaz!");
            RuleFor(p => p.InformationMessage).NotNull().WithMessage("Bilgilendirme Mesajı boş olamaz!");
            RuleFor(p => p.DeviceBrand).NotEmpty().WithMessage("Cihaz markası boş olamaz!");
            RuleFor(p => p.DeviceBrand).NotNull().WithMessage("Cihaz markası boş olamaz!");
            RuleFor(p => p.DeviceModel).NotEmpty().WithMessage("Cihaz Modeli Numarası boş olamaz!");
            RuleFor(p => p.DeviceModel).NotNull().WithMessage("Cihaz Modeli boş olamaz!");
            RuleFor(p => p.MerchantId).NotEmpty().WithMessage("Üye İş Yeri Numarası boş olamaz!");
            RuleFor(p => p.MerchantId).NotNull().WithMessage("Üye İş Yeri Numarası boş olamaz!");
        }
    }
}
