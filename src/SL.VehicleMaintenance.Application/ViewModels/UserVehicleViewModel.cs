namespace SL.VehicleMaintenance.Application.ViewModels
{
	public class UserVehicleViewModel: EntityViewModel
    {
        public required string LicensePlate { get; set; } // Placa
		public string? Description { get; set; }
		public decimal CurrentMileage { get; set; } // KM Atual
		public Guid ModelId { get; set; }
		public Guid UserId { get; set; }
		public required VehicleModelViewModel Model { get; set; }
    }
}