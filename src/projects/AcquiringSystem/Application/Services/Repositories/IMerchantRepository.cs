using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IMerchantRepository : IAsyncRepository<Merchant, string>, IRepository<Merchant, string>
    {
    }
}
