using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IChainRepository : IAsyncRepository<Chain,string>, IRepository<Chain, string>
    {
    }
}
