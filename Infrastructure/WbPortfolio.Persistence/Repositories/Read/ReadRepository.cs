﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using WbPortfolio.Domain.Interfaces.Base;
using WbPortfolio.Domain.Interfaces.IRepositories.Read;
using WbPortfolio.Persistence.Context.Data;

namespace WbPortfolio.Persistence.Repositories.Read;

public class ReadRepository<T> : IReadRepository<T> where T : class, IEntity
{
    protected readonly AppDbContext _context;

    public ReadRepository(AppDbContext context)
    {
        _context = context;
    }
    protected DbSet<T> Table { get => _context.Set<T>(); }
    public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
    {
        IQueryable<T> queryable = Table;
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (include is not null) queryable = include(queryable);
        if (predicate is not null) queryable = queryable.Where(predicate);
        if (orderBy is not null)
            return await orderBy(queryable).ToListAsync();

        return await queryable.ToListAsync();
    }
    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
    {
        IQueryable<T> queryable = Table;
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (include is not null) queryable = include(queryable);

        return await queryable.FirstOrDefaultAsync(predicate);
    }
    public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
    {
        Table.AsNoTracking();
        if (predicate is not null) Table.Where(predicate);

        return await Table.CountAsync();
    }
    public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
    {
        if (!enableTracking) Table.AsNoTracking();
        return Table.Where(predicate);
    }

    

    
}
