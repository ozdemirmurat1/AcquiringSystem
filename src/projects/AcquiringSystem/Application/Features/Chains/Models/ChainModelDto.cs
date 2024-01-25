using Core.Application.Dtos;

namespace Application.Features.Chains.Models
{
    public sealed record ChainModelDto(
        string ChainCode,
        string TaxAdministration,
        string ChamberOfCommerce,
        string IdType
        ) : IDto;
}

