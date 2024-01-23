using Application.Features.Terminals.Models;
using Core.Application.Responses;

namespace Application.Features.Terminals.Queries.GetByIdTerminalWithMerchant
{
    public sealed record GetByIdTerminalWithMerchantQueryResponse(
        string TerminalIdentification,
        string InformationMessage,
        string DeviceBrand,
        string DeviceModel,
        string MerchantId,
        MerchantDto Merchant
        ) :IResponse;
}
