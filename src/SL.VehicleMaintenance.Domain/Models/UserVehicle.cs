using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class UserVehicle : Entity
	{
		public required string LicensePlate { get; set; } // Placa
		public string? Description { get; set; }
		public decimal CurrentMileage { get; set; } // KM Atual
		public Guid ModelId { get; set; }
		public Guid UserId { get; set; }
		public required User User { get; set; }
		public required VehicleModel Model { get; set; }

		protected UserVehicle() { }

		public UserVehicle(string licensePlate, string description, decimal currentMileage)
		{
			LicensePlate = licensePlate;
			Description = description;
			CurrentMileage = currentMileage;

			Validate();
		}

		public void Validate()
		{
			Validations.Required(LicensePlate, ($"O campo {nameof(LicensePlate)} é obrigatório!"));
			Validations.MinMaxLength(LicensePlate, 6, 8, ($"Tamanho inválido para o campo {nameof(LicensePlate)}!"));
			Validations.MinMaxLength(Description, 2, 150, ($"Tamanho inválido para o campo {nameof(Description)}!"));
		}
	}
}
