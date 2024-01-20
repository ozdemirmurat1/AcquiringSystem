using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class TerminalRepository : EfRepositoryBase<Terminal, string, BaseDbContext>, ITerminalRepository
    {
        public TerminalRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
