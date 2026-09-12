using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SabzMarket.Application.Common.Attributes;
using SabzMarket.Application.Common.Enums;
using SabzMarket.Application.Interfaces.Persistence;
using SabzMarket.Domain.Entities.Base;
using System.Reflection;

namespace SabzMarket.Infrastructure.Persistence.Postgresql.EfCore.Repositories;

public abstract class RepositoryBase<TEntity, TKey>(SabzMarketDbContext context)
    : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    protected readonly SabzMarketDbContext Context = context;
    private readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

    public virtual async Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken,
        Expression<Func<TEntity, object>>? include = null, bool tracking = false
    )
    {
        IQueryable<TEntity> query = _dbSet;

        if (include != null)
        {
            query.Include(include);
        }

        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(
            x => x.Id!.Equals(id),
            cancellationToken);
    }

    public virtual async Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken,
        Expression<Func<TEntity, bool>>? where = null,
        Expression<Func<TEntity, object>>? orderBy = null,
        Expression<Func<TEntity, object>>? include = null, bool tracking = false
    )
    {
        IQueryable<TEntity> query = _dbSet;

        if (include is not null)
        {
            query = query.Include(include);
        }

        if (where is not null)
        {
            query = query.Where(where);
        }

        if (orderBy is not null)
            query = query.OrderBy(orderBy);

        if (!tracking)
            query = query.AsNoTracking();

        return await query.ToListAsync(cancellationToken);
    }

    public async Task<TEntity?> GetLocalAsync(CancellationToken cancellationToken,
        Expression<Func<TEntity, bool>>? where = null,
        bool tracking = false
    )
    {
        IQueryable<TEntity> query = _dbSet;

        if (where is not null)
            query = query.Where(where);

        if (!tracking)
            query = query.AsNoTracking();

        return await query.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<(IReadOnlyList<TEntity> Items, int TotalCount)> GetWithPaginationAsync<TFilter>(
        CancellationToken cancellationToken,
        Expression<Func<TEntity, bool>>? where = null,
        TFilter? filter = default,
        int skip = 0,
        int take = 10,
        Expression<Func<TEntity, object>>? orderBy = null,
        Expression<Func<TEntity, object>>? include = null,
        bool tracking = false,
        bool ignoreQueryFilter = false
    )
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter != null)
        {
            query = GetSearchQuery<TFilter>(query, filter);
        }

        if (ignoreQueryFilter)
            query = query.IgnoreQueryFilters();

        if (include != null)
            query = query.Include(include);

        if (where != null)
            query = query.Where(where);


        int count = await query.CountAsync(cancellationToken);

        if (orderBy != null)
        {
            query = query.OrderBy(orderBy);
        }

        if (!tracking)
            query = query.AsNoTracking();

        var items = await query
            .Skip(skip)
            .Take(take)
            .ToListAsync(cancellationToken);

        return (items, count);
    }

    public virtual void Add(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public virtual void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }

    public void UpdateProperties(
        TEntity entity,
        params Expression<Func<TEntity, object>>[] properties)
    {
        Context.Attach(entity);

        foreach (var property in properties)
        {
            Context.Entry(entity)
                .Property(property)
                .IsModified = true;
        }
    }

    public virtual void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    private IQueryable<TEntity> GetSearchQuery<TFilter>(IQueryable<TEntity> query, TFilter filter)
    {
        var properties = typeof(TFilter).GetProperties();

        foreach (var filterProperty in properties)
        {
            var value = filterProperty.GetValue(filter);

            if (value is null)
                continue;

            var attribute = filterProperty.GetCustomAttribute<FilterAttribute>();

            if (attribute is null)
                continue;

            var entityProperty = typeof(TEntity)
                .GetProperty(attribute.EntityProperty);

            if (entityProperty is null)
                continue;

            var parameter = Expression.Parameter(typeof(TEntity), "x");

            var property = Expression.Property(parameter, entityProperty);

            var constant = Expression.Constant(value);

            Expression condition;

            if (attribute.Operator == FilterOperator.Equal)
            {
                condition = Expression.Equal(property, constant);
            }
            else if (attribute.Operator == FilterOperator.GreaterThanOrEqual)
            {
                condition = Expression.GreaterThanOrEqual(property, constant);
            }
            else if (attribute.Operator == FilterOperator.LessThanOrEqual)
            {
                condition = Expression.LessThanOrEqual(property, constant);
            }
            else
            {
                throw new NotSupportedException();
            }

            var expression =
                Expression.Lambda<Func<TEntity, bool>>(
                    condition,
                    parameter);

            query = query.Where(expression);
        }

        return query;
    }
}