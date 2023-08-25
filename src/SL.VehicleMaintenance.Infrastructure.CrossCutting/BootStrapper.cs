using Microsoft.Extensions.DependencyInjection;

namespace SL.VehicleMaintenance.Infrastructure.CrossCutting
{
	public static class BootStrapper
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			RegisterAppServices(services);
			RegisterDomainServices(services);
			RegisterRepositories(services);
			RegisterSqlServerContext(services);
		}

		private static void RegisterAppServices(IServiceCollection container)
		{
			throw new NotImplementedException();
		}

		private static void RegisterDomainServices(IServiceCollection container)
		{
			throw new NotImplementedException();
		}

		private static void RegisterRepositories(IServiceCollection container)
		{
			throw new NotImplementedException();
		}

		private static void RegisterSqlServerContext(IServiceCollection container)
		{
			throw new NotImplementedException();
		}
	}
}
