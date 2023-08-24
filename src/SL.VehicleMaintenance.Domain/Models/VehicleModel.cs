using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class VehicleModel : Entity
	{
		public required string Name { get; set; }
		public int YearOfManufacture { get; set; } // Ano de fabricação
		public int ModelYear { get; set; } // Ano do modelo
		public Guid BrandId { get; set; }

		public ICollection<UserVehicle> UserVehicles { get; set; }
		public required Brand Brand { get; set; }

		public VehicleModel()
		{
			UserVehicles = new List<UserVehicle>();
		}
	}
}
