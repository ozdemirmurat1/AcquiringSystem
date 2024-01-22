using Core.Application.Dtos;

namespace Application.Features.Merchants.Models
{
    public class ChainDto:IDto
    {
        public string ChainCode { get; set; }
        public string TaxAdministration { get; set; }
        public string ChamberOfCommerce { get; set; }
        public string IdType { get; set; }
    }
}
