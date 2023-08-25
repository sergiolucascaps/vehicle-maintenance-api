using Microsoft.EntityFrameworkCore;

namespace SL.VehicleMaintenance.Infrastructure.Data.Context
{
	public class VehicleMaintenanceSqlContext : DbContext
	{
		public VehicleMaintenanceSqlContext(DbContextOptions<VehicleMaintenanceSqlContext> options)
		: base(options)
		{
				
		}
	}
}
