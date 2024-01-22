using MediatR;

namespace Application.Features.Merchants.Commands.Create
{
    public sealed record CreateMerchantCommand(
        string ChainId,
        string MerchantNumber,
        string MerchantName,
        string Province,
        string District,
        string Address,
        string Email,
        string TelephoneNumber
        ) :IRequest<CreateMerchantCommandResponse>;
}
