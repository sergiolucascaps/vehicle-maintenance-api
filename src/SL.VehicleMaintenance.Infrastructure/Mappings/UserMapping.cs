using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.Mappings
{
	public class UserMapping : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(c => c.Id);

			builder.Property(c => c.CreatedDate)
				.IsRequired(true);

			builder.Property(c => c.UpdatedDate)
				.IsRequired(false);

			builder.Property(c => c.IsActive)
				.IsRequired(true);

			builder.Property(c => c.IsDeleted)
				.IsRequired(true);

			// 1 : N => User : Phones
			builder.HasMany(c => c.Phones)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			// 1 : N => User : Emails
			builder.HasMany(c => c.Emails)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			// 1 : N => User : Vehicles
			builder.HasMany(c => c.Vehicles)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			builder.ToTable("Users");
		}
	}
}
