using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IMerchantRepository : IAsyncRepository<Merchant, Guid>, IRepository<Merchant, Guid>
    {
    }
}
