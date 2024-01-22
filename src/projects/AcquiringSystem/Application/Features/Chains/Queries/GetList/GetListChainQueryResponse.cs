using Core.Application.Responses;

namespace Application.Features.Chains.Queries.GetList
{
    public sealed class GetListChainQueryResponse : IResponse
    {
        public string ChainCode { get; set; }
        public string TaxAdministration { get; set; }
        public string ChamberOfCommerce { get; set; }
        public string IdType { get; set; }

        public GetListChainQueryResponse()
        {
            ChainCode=string.Empty;
            TaxAdministration=string.Empty;
            ChamberOfCommerce=string.Empty;
            IdType=string.Empty;
        }

        public GetListChainQueryResponse(string chainCode,string taxAdministration,string chamberOfCommerce,string idType)
        {
            ChainCode = chainCode;
            TaxAdministration = taxAdministration;
            ChamberOfCommerce = chamberOfCommerce;
            IdType = idType;
        }
    }
}