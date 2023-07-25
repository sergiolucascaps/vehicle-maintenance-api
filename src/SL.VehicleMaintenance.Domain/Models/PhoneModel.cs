using SL.VehicleMaintenance.Domain.DomainObjects;
using SL.VehicleMaintenance.Domain.DomainObjects.Enumerators;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class PhoneModel : Entity
	{
		public required string Number { get; set; }
		public string? Description { get; set; }
		public PhoneTypeEnumModel PhoneType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }
		public required UserModel User { get; set; }
	}
}
