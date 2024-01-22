using Core.Application.Responses;

namespace Application.Features.Chains.Commands.Update
{
    public sealed record UpdateChainCommandResponse(
        string Message="İş Yeri Başarıyla Güncellendi!") : IResponse;
}
