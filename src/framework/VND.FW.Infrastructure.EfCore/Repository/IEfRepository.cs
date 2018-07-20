using Microsoft.EntityFrameworkCore;
using VND.Fw.Domain;
using VND.FW.Infrastructure.EfCore.Db;

namespace VND.FW.Infrastructure.EfCore.Repository
{
  public interface IEfRepositoryAsync<TEntity> : IEfRepositoryAsync<ApplicationDbContext, TEntity>
        where TEntity : IEntity
  {
  }

  public interface IEfQueryRepository<TEntity> : IEfQueryRepository<ApplicationDbContext, TEntity>
      where TEntity : IEntity
  {
  }

  public interface IEfRepositoryAsync<TDbContext, TEntity> : IRepositoryAsync<TEntity>
      where TDbContext : DbContext
      where TEntity : IEntity
  {
  }

  public interface IEfQueryRepository<TDbContext, TEntity> : IQueryRepository<TEntity>
      where TDbContext : DbContext
      where TEntity : IEntity
  {
  }
}
