using Application.Features.Terminals.Models;

namespace Application.Features.Terminals.Queries.GetListTerminalWithMerchant
{
    public sealed record GetListTerminalWithMerchantQueryResponse(
        string TerminalIdentification,
        string InformationMessage,
        string DeviceBrand,
        string DeviceModel,
        string MerchantId,
        MerchantDto Merchant
        );
}
