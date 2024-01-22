namespace Application.Features.Chains.Queries.GetById
{
    public sealed record GetByIdChainQueryResponse(
         string ChainCode, 
         string TaxAdministration, 
         string ChamberOfCommerce, 
         string IdType);

}
