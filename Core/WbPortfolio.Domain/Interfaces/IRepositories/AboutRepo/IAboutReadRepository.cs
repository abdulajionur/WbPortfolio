using System.Linq.Expressions;
using WbPortfolio.Domain.Entities;
using WbPortfolio.Domain.Interfaces.IRepositories.Read;

namespace WbPortfolio.Domain.Interfaces.IRepositories.AboutRepo;

public interface IAboutReadRepository : IReadRepository<About>
{
    Task<IList<About>> GetAllAsync(bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default);
    Task<About> GetByIdAsync(Guid id, bool trackChanges = false, bool isActive = true, CancellationToken cancellationToken = default);
}
