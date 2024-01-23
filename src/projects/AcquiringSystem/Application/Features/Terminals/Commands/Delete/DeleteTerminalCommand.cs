using MediatR;

namespace Application.Features.Terminals.Commands.Delete
{
    public sealed record DeleteTerminalCommand(
        string id):IRequest<DeleteTerminalCommandResponse>;
}
