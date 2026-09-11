using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace SabzMarket.Application.Interfaces.Persistence;

public interface IRepository<TEntity, in TKey> where TEntity : class
{
    Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool tracking = false);

    Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken,
        Expression<Func<TEntity, bool>>? where = null,
        Expression<Func<TEntity, bool>>? orderBy = null,
        Expression<Func<TEntity, bool>>? include = null, bool tracking = false);

    Task<(IReadOnlyList<TEntity> Items, int TotalCount)> GetWithPaginationAsync<TFilter>(
        CancellationToken cancellationToken,
        Expression<Func<TEntity, bool>>? where = null,
        TFilter? filter = default,
        int skip = 0,
        int take = 10,
        Expression<Func<TEntity, object>>? orderBy = null,
        Expression<Func<TEntity, object>>? include = null,
        bool tracking = false,
        bool ignoreQueryFilter = false
    );

    void Add(TEntity entity);
    void Update(TEntity entity);

    public void UpdateProperties(
        TEntity entity,
        params Expression<Func<TEntity, object>>[] properties);

    void Remove(TEntity entity);
}