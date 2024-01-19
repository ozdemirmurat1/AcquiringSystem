using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class MerchantRepository : EfRepositoryBase<Merchant, Guid, BaseDbContext>, IMerchantRepository
    {
        public MerchantRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
