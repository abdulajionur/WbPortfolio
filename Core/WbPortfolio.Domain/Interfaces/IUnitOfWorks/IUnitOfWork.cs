using WbPortfolio.Domain.Interfaces.Base;
using WbPortfolio.Domain.Interfaces.IRepositories.AboutRepo;
using WbPortfolio.Domain.Interfaces.IRepositories.Read;
using WbPortfolio.Domain.Interfaces.IRepositories.Write;

namespace WbPortfolio.Domain.Interfaces.IUnitOfWorks;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class, IEntity;
    IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntity;
    Task<int> SaveAsync();
    IAboutReadRepository AboutReadRepository { get; }
    IAboutWriteRepository AboutWriteRepository { get; }
}
