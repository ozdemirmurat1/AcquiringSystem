using Core.Application.Responses;

namespace Application.Features.Terminals.Queries.GetList
{
    public sealed record GetListTerminalQueryResponse(
        string TerminalIdentification,
        string InformationMessage,
        string DeviceBrand,
        string DeviceModel,
        string MerchantId
        ) :IResponse;
}
