using WbPortfolio.Domain.Interfaces.Base;

namespace WbPortfolio.Domain.Interfaces.IRepositories.Write;

public interface IWriteRepository<T> where T : class, IEntity
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IList<T> entities);
    Task<T> UpdateAsync(T entity);
    Task<T> RemoveAsync(T entity);
    Task<(bool isSuccess, T entity)> ChangeStatusAsync(T entity);
}
