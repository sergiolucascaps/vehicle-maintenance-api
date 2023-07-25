using SL.VehicleMaintenance.Domain.DomainObjects.Enumerators;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class EmailModel
	{
		public required string Email { get; set; }
		public string? Description { get; set; }
		public EmailTypeEnumModel EmailType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }
		public required UserModel User { get; set; }
	}
}
