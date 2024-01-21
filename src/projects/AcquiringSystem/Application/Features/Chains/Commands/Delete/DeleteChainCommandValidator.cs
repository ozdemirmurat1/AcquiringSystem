using FluentValidation;

namespace Application.Features.Chains.Commands.Delete
{
    public sealed class DeleteChainCommandValidator:AbstractValidator<DeleteChainCommand>
    {
        public DeleteChainCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        }
    }
}
