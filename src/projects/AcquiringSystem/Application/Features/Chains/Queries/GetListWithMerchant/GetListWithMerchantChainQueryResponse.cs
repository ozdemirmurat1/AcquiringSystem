using Application.Features.Chains.Models;
using Core.Application.Responses;

namespace Application.Features.Chains.Queries.GetListWithMerchant
{
    public sealed class GetListWithMerchantChainQueryResponse:IResponse
    {
        public string ChainCode { get; set; }
        public string TaxAdministration { get; set; }
        public string ChamberOfCommerce { get; set; }
        public string IdType { get; set; }

        public ICollection<MerchantDto> Merchants { get; set; }
    }
}
