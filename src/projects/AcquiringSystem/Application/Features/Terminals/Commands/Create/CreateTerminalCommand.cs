using MediatR;

namespace Application.Features.Terminals.Commands.Create
{
    public sealed record CreateTerminalCommand(
        string TerminalIdentification,
        string InformationMessage,
        string DeviceBrand,
        string DeviceModel,
        string MerchantId 
        ) :IRequest<CreateTerminalCommandResponse>;
}
