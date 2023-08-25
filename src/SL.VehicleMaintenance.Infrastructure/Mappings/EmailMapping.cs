using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Infrastructure.Data.Mappings
{
	public class EmailMapping : IEntityTypeConfiguration<Email>
	{
		public void Configure(EntityTypeBuilder<Email> builder)
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

			builder.Property(x => x.EmailAddress)
				.IsRequired(true)
				.HasColumnType("VARCHAR(250)");

			builder.Property(x => x.Description)
				.IsRequired(false)
				.HasColumnType("VARCHAR(75)");

			builder.Property(x => x.EmailType)
				.IsRequired(true)
				.HasColumnType("TINYINT"); // 0-255 CHARACTERS

			builder.Property(x => x.IsMain)
				.IsRequired(true);

			builder.Property(x => x.UserId)
				.IsRequired(true);

			builder.HasOne(x => x.User);

			builder.ToTable("Emails");
		}
	}
}
