namespace SL.VehicleMaintenance.Application.ViewModels
{
	public class BrandViewModel : EntityViewModel
	{
		public required string Name { get; set; }
		public string? Image { get; set; }

		public ICollection<VehicleViewModel> VehicleModels { get; set; }

		public BrandViewModel()
		{
			VehicleModels = new List<VehicleViewModel>();
		}
	}
}