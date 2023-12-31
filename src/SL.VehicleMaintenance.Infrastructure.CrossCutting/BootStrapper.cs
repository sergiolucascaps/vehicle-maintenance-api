﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Interfaces.Services;
using SL.VehicleMaintenance.Domain.Services;
using SL.VehicleMaintenance.Infrastructure.Data.Context;
using SL.VehicleMaintenance.Infrastructure.Data.Repositories;
using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Application.Services;

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
			services.AddScoped<IBrandAppService, BrandAppService>();
			services.AddScoped<IUserAppService, UserAppService>();
		}

		private static void RegisterDomainServices(IServiceCollection services)
		{
			services.AddScoped<IBrandService, BrandService>();
			services.AddScoped<IUserService, UserService>();
		}

		private static void RegisterRepositories(IServiceCollection services)
		{
			services.AddScoped<IBrandRepository, BrandRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
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
