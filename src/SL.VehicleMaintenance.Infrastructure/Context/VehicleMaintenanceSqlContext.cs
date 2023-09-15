using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Infrastructure.Data.Mappings;

namespace SL.VehicleMaintenance.Infrastructure.Data.Context
{
	public class VehicleMaintenanceSqlContext : DbContext
	{
		public VehicleMaintenanceSqlContext(DbContextOptions<VehicleMaintenanceSqlContext> options)
		: base(options)
		{
				
		}

		public DbSet<Brand> Brands { get; set; }
    	public DbSet<Email> Emails { get; set; }
    	public DbSet<Phone> Phones { get; set; }
    	public DbSet<User> Users { get; set; }
    	public DbSet<UserVehicle> UserVehicles { get; set; }
    	public DbSet<VehicleModel> VehicleModels { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// The line down, will set all Mappings
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			// modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));

			base.OnModelCreating(modelBuilder);
		}
	}
}
