using System.Linq.Expressions;

namespace SL.VehicleMaintenance.Domain.Interfaces.Repositories
{
	public interface IRepository<TEntity> : IDisposable
	{
		Task<TEntity> Create(TEntity obj);
		TEntity Update(TEntity obj);
		// Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
		Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
		// Task<TEntity?> GetById(Guid id);
		// Task<IEnumerable<TEntity>> ListAll();
		Task Remove(Guid id);
		int SaveChanges();
	}
}