using MediatR;

namespace Application.Features.Merchants.Commands.Update
{
    public sealed record UpdateMerchantCommand(
        string id,
        string ChainId,
        string MerchantNumber,
        string MerchantName,
        string Province,
        string District,
        string Address,
        string Email,
        string TelephoneNumber
        ) :IRequest<UpdateMerchantCommandResponse>;
}
