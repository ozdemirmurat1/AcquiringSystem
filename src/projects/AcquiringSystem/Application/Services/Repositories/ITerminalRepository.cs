using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface ITerminalRepository : IAsyncRepository<Terminal, string>, IRepository<Terminal, string>
    {
    }
}
