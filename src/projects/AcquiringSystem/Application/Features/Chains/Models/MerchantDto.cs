using Core.Application.Dtos;

namespace Application.Features.Chains.Models
{
    public class MerchantDto:IDto
    {
        public string MerchantNumber { get; set; }
        public string MerchantName { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }

        public string ChainId { get; set; }
    }
}
