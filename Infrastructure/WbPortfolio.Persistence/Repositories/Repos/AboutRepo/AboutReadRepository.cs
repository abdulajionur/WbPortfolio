using Microsoft.EntityFrameworkCore;
using WbPortfolio.Domain.Entities;
using WbPortfolio.Domain.Interfaces.IRepositories.AboutRepo;
using WbPortfolio.Persistence.Context.Data;
using WbPortfolio.Persistence.Repositories.Read;

namespace WbPortfolio.Persistence.Repositories.Repos.AboutRepo;

public class AboutReadRepository : ReadRepository<About>, IAboutReadRepository
{
    public AboutReadRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IList<About>> GetAllAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (isActive) { query = query.Where(a => a.IsActive); }
        if (!trackChanges) { query = query.AsNoTracking(); }
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<About> GetByIdAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default)
    {
        IQueryable<About> query = Table;

        if (isActive)  { query = query.Where(a => a.IsActive); }
        if (!trackChanges)  { query = query.AsNoTracking(); }

        return await query.FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }
}
