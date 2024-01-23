using Core.Application.Responses;

namespace Application.Features.Terminals.Queries.GetById
{
    public sealed record GetByIdTerminalQueryResponse(
        string TerminalIdentification,
        string InformationMessage,
        string DeviceBrand,
        string DeviceModel,
        string MerchantId):IResponse;
}

