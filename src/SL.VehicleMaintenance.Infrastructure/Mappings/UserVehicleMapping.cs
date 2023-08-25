using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.Data.Mappings
{
	public class UserVehicleMapping : IEntityTypeConfiguration<UserVehicle>
	{
		public void Configure(EntityTypeBuilder<UserVehicle> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.CreatedDate)
				.IsRequired(true);

			builder.Property(x => x.UpdatedDate)
				.IsRequired(false);

			builder.Property(x => x.IsActive)
				.IsRequired(true);

			builder.Property(x => x.IsDeleted)
				.IsRequired(true);

			builder.Property(x => x.LicensePlate)
				.IsRequired(true)
				.HasColumnType("VARCHAR(10)");

			builder.Property(x => x.Description)
				.IsRequired(false)
				.HasColumnType("VARCHAR(75)");

			builder.Property(x => x.CurrentMileage)
				.IsRequired(true)
				.HasColumnType("DECIMAL(16,2)");

			builder.Property(x => x.ModelId)
				.IsRequired(true);

			builder.Property(x => x.UserId)
				.IsRequired(true);

			builder.HasOne(x => x.User);
			builder.HasOne(x => x.Model);

			builder.ToTable("UserVehicles");
		}
	}
}
