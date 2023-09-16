using SL.VehicleMaintenance.Application.Interfaces;

namespace SL.VehicleMaintenance.Application.Services
{
	public abstract class BaseAppService : IBaseAppService
	{
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}