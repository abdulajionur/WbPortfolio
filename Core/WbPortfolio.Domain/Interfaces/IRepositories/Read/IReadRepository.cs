﻿using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using WbPortfolio.Domain.Interfaces.Base;

namespace WbPortfolio.Domain.Interfaces.IRepositories.Read;

public interface IReadRepository<T> where T : class, IEntity
{
    Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);

    Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);
    Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);
}
