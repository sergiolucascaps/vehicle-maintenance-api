using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class VehicleModel : Entity
	{
		public required string Name { get; set; }
		public int YearOfManufacture { get; set; } // Ano de fabricação
		public int ModelYear { get; set; } // Ano do modelo
		public Guid BrandId { get; set; }

		public required Brand Brand { get; set; }
	}
}
