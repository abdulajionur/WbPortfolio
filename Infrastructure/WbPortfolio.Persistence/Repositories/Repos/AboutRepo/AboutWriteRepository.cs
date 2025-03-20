using WbPortfolio.Domain.Entities;
using WbPortfolio.Domain.Interfaces.IRepositories.AboutRepo;
using WbPortfolio.Persistence.Context.Data;
using WbPortfolio.Persistence.Repositories.Write;

namespace WbPortfolio.Persistence.Repositories.Repos.AboutRepo;

public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
{
    public AboutWriteRepository(AppDbContext context) : base(context)
    {
    }
}