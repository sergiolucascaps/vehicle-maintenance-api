namespace SL.VehicleMaintenance.Application.ViewModels
{
    public class VehicleViewModel : EntityViewModel
    {
        public required string Name { get; set; }
		public int YearOfManufacture { get; set; } // Ano de fabricação
		public int ModelYear { get; set; } // Ano do modelo
		public Guid BrandId { get; set; }

		public VehicleViewModel()
		{ }
    }
}