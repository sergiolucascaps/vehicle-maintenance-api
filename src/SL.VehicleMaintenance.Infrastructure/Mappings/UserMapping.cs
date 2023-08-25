using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.Data.Mappings
{
	public class UserMapping : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
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

			// 1 : N => User : Phones
			builder.HasMany(x => x.Phones)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			// 1 : N => User : Emails
			builder.HasMany(x => x.Emails)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			// 1 : N => User : Vehicles
			builder.HasMany(x => x.Vehicles)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			builder.ToTable("Users");
		}
	}
}
