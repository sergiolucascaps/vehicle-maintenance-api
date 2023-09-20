using Microsoft.EntityFrameworkCore;
using SL.VehicleMaintenance.Domain.DomainObjects;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Infrastructure.Data.Context;
using System.Linq.Expressions;

namespace SL.VehicleMaintenance.Infrastructure.Data.Repositories
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected VehicleMaintenanceSqlContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(VehicleMaintenanceSqlContext context)
        {
            Db      =   context;
            DbSet   =   Db.Set<TEntity>();
        }

        public virtual async Task<TEntity> Create(TEntity obj)
        {
            _ = await DbSet.AddAsync(obj);
            return obj;
        }

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            _ = DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
		=> await DbSet.AsNoTracking().Where(predicate).ToListAsync();

        // public async Task<IEnumerable<TEntity>> Find(ISpecificationFilter<IDictionary<string, object>> predicate, params Expression<Func<TEntity, object>>[] includes) =>
        //     await DbSet
        //         .AsNoTracking()
        //         .Where(predicate)
        //         .Skip((predicate.Pagina - 1) * predicate.QuantidadeItems)
        //         .Take(predicate.QuantidadeItems)
        //         .Includes(includes)
        //         .OrderBy(predicate.Descending, predicate.Ordenacao)
        //         .ToListAsync();

        public virtual async Task<TEntity?> GetById(Guid id) => await DbSet.FindAsync(id);

        public virtual async Task<IEnumerable<TEntity>> ListAll()
		=> await DbSet.ToListAsync();

        public virtual async Task Remove(Guid id)
        {
			var entity = await GetById(id);
			
			if(entity is not null)
			{
				_ = DbSet.Remove(entity);
			}
        }

        public int SaveChanges() => Db.SaveChanges();

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}