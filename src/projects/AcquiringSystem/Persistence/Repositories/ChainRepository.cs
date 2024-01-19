using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ChainRepository : EfRepositoryBase<Chain, Guid, BaseDbContext>, IChainRepository
    {
        public ChainRepository(BaseDbContext context):base(context) 
        {
        }
    }
}
