using FluentValidation;

namespace Application.Features.Terminals.Commands.Delete
{
    public sealed class DeleteTerminalCommandValidator:AbstractValidator<DeleteTerminalCommand>
    {
        public DeleteTerminalCommandValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        }
    }
}
