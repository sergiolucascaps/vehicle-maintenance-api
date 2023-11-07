using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Domain.Models.Grids;

namespace SL.VehicleMaintenance.Domain.Interfaces.Repositories
{
	public interface IBrandRepository : IRepository<Brand>
	{
		Task<ICollection<BrandGridList>> GridList();
		Task<Brand?> GetById(Guid id);
	}
}