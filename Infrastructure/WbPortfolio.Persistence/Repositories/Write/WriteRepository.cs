using Microsoft.EntityFrameworkCore;
using WbPortfolio.Domain.Interfaces.Base;
using WbPortfolio.Domain.Interfaces.IRepositories.Write;
using WbPortfolio.Persistence.Context.Data;

namespace WbPortfolio.Persistence.Repositories.Write;

public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntity
{
    protected readonly AppDbContext _context;
    public WriteRepository(AppDbContext context)
    {
        _context = context;
    }
    private DbSet<T> Table { get => _context.Set<T>(); }

    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task AddRangeAsync(IList<T> entities)
    {
        await Table.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    public async Task<(bool isSuccess, T entity)> ChangeStatusAsync(T entity)
    {
        entity.IsActive = !entity.IsActive;
        Table.Update(entity);
        var result = await _context.SaveChangesAsync();
        return (result > 0, entity);
    }

    public async Task<T> RemoveAsync(T entity)
    {
        Table.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        Table.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
