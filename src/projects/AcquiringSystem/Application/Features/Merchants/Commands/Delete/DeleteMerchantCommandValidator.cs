using FluentValidation;

namespace Application.Features.Merchants.Commands.Delete
{
    public sealed class DeleteMerchantCommandValidator:AbstractValidator<DeleteMerchantCommand>
    {
        public DeleteMerchantCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        }
    }
}
