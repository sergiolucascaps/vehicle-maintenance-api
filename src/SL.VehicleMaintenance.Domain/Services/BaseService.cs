using SL.VehicleMaintenance.Domain.Interfaces.Services;

namespace SL.VehicleMaintenance.Domain.Services
{
	public abstract class BaseService<TEntity> : IBaseService<TEntity>
	{
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}