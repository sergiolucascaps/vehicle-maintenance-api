using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SL.VehicleMaintenance.Infrastructure.Data.Context;

namespace SL.VehicleMaintenance.Infrastructure.CrossCutting
{
	public static class BootStrapper
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			RegisterAppServices(services);
			RegisterDomainServices(services);
			RegisterRepositories(services);
		}

		private static void RegisterAppServices(IServiceCollection services)
		{
			throw new NotImplementedException();
		}

		private static void RegisterDomainServices(IServiceCollection services)
		{
			throw new NotImplementedException();
		}

		private static void RegisterRepositories(IServiceCollection services)
		{
			throw new NotImplementedException();
		}

		public static void RegisterAppDbContext(this IServiceCollection services, string? connection)
		{
			if (!string.IsNullOrWhiteSpace(connection))
			{
				services.AddDbContext<VehicleMaintenanceSqlContext>(options =>
				{
					options.UseSqlServer(connection);
				});
			}
		}
	}
}
