using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class Brand : Entity
	{
		public required string Name { get; set; }
		public string? Image { get; set; }

		public ICollection<VehicleModel> VehicleModels { get; set; }

		protected Brand()
		{
			VehicleModels = new List<VehicleModel>();
		}
	}
}
