using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Domain.Interfaces.Services
{
	public interface IBrandService : IBaseService<Brand>
	{
		Task<Brand?> Create(Brand brand);
		Task<Brand?> Update(Brand brand);
		Task<bool> Delete(Guid id);
	}
}