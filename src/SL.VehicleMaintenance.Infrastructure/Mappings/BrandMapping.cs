using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.Mappings
{
	public class BrandMapping : IEntityTypeConfiguration<Brand>
	{
		public void Configure(EntityTypeBuilder<Brand> builder)
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

			builder.Property(x => x.Image)
				.IsRequired(false);

			builder
				.HasMany(x => x.VehicleModels)
				.WithOne(x => x.Brand);

			builder.ToTable("Brands");
		}
	}
}
