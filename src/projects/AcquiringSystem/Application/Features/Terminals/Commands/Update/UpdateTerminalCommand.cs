using MediatR;

namespace Application.Features.Terminals.Commands.Update
{
    public sealed record UpdateTerminalCommand(
        string id,
        string TerminalIdentification,
        string InformationMessage,
        string DeviceBrand,
        string DeviceModel,
        string MerchantId
        ) :IRequest<UpdateTerminalCommandResponse>;
}
