
using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Merchant :Entity<Guid>
    {
        public string MerchantNumber { get; set; }
        public string MerchantName { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }

        public Guid ChainId { get; set; }
        public Chain Chain { get; set; }

        public Merchant()
        {
            
        }

        public Merchant(Guid id,string merchantNumber,string merchantName,string province,string district,string address,string email,string telephoneNumber):base(id)
        {
            MerchantNumber = merchantNumber;
            MerchantName = merchantName;
            Province = province;
            District = district;
            Address = address;
            Email = email;
            TelephoneNumber = telephoneNumber;
        }
    }
}
