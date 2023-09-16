using SL.VehicleMaintenance.Domain.Interfaces;
using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Infrastructure.Data.Context;


namespace SL.VehicleMaintenance.Infrastructure.Data.Repositories
{
	public class BrandRepository : Repository<Brand>, IBrandRepository
	{
		public BrandRepository(VehicleMaintenanceSqlContext context) : base(context)
		{ }
	}
}