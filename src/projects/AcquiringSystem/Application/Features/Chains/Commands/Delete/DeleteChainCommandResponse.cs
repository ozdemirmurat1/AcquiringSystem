using Core.Application.Responses;

namespace Application.Features.Chains.Commands.Delete
{
    public sealed record DeleteChainCommandResponse(
        string Message="İş Yeri Başarıyla Silindi!") : IResponse;
}
