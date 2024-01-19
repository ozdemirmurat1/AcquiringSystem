using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class TerminalRepository : EfRepositoryBase<Terminal, Guid, BaseDbContext>, ITerminalRepository
    {
        public TerminalRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
