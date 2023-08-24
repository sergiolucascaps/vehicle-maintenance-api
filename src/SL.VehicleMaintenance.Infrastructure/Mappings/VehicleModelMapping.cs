using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.Mappings
{
	public class VehicleModelMapping : IEntityTypeConfiguration<VehicleModel>
	{
		public void Configure(EntityTypeBuilder<VehicleModel> builder)
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

			builder.Property(x => x.Name)
				.IsRequired(true)
				.HasColumnType("VARCHAR(75)");

			builder.Property(x => x.YearOfManufacture)
				.IsRequired(true);

			builder.Property(x => x.ModelYear)
				.IsRequired(true);

			builder.Property(x => x.BrandId)
				.IsRequired(true);

			builder.HasOne(x => x.Brand);

			builder
				.HasMany(x => x.UserVehicles)
				.WithOne(x => x.Model);

			builder.ToTable("VehicleModels");
		}
	}
}
