using MediatR;

namespace Application.Features.Merchants.Commands.Delete
{
    public sealed record DeleteMerchantCommand(
        string id) : IRequest<DeleteMerchantCommandResponse>;
}
