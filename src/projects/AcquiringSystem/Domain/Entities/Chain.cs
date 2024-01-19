using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Chain : Entity<Guid>
    {
        public string ChainCode { get; set; }
        public string TaxAdministration { get; set; }
        public string ChamberOfCommerce { get; set; }
        public string IdType { get; set; }

        public ICollection<Merchant> Merchants { get; set; }

        public Chain()
        {
            
        }

        public Chain(Guid id,string chainCode,string taxAdministration,string chamberOfCommerce,string idType):base(id)
        {
            ChainCode = chainCode;
            TaxAdministration = taxAdministration;
            ChamberOfCommerce = chamberOfCommerce;
            IdType = idType;
            
        }
    }
}
