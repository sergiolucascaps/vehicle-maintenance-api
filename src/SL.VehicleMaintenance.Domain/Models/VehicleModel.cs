using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class VehicleModel : Entity
	{
		public required string LicensePlate { get; set; } // Placa
		public string? Description { get; set; }
		public int YearOfManufacture { get; set; } // Ano de fabricação
		public int ModelYear { get; set; } // Ano do modelo
		public decimal CurrentMileage { get; set; } // KM Atual

		// TODO: @sergiolucas - inserir brand(marca) e model (modelo)
		// TODO: @sergiolucas - se necessário isolar ano de fabricação e do modelo para dentro das modelos quando criadas

		protected VehicleModel() { }

		public VehicleModel(string licensePlate, string description, int yearOfManufacture, int modelYear, decimal currentMileage)
		{
			LicensePlate = licensePlate;
			Description = description;
			YearOfManufacture = yearOfManufacture;
			ModelYear = modelYear;
			CurrentMileage = currentMileage;

			Validate();
		}

		public void Validate()
		{
			Validations.Required(LicensePlate, ($"O campo {nameof(LicensePlate)} é obrigatório!"));
			Validations.MinMaxLength(LicensePlate, 6, 8, ($"Tamanho inválido para o campo {nameof(LicensePlate)}!"));
			Validations.MinMaxLength(Description, 2, 150, ($"Tamanho inválido para o campo {nameof(Description)}!"));
			Validations.LessThan(YearOfManufacture, DateTime.Now.Year + 1, ($"Valor inválido para o campo {nameof(YearOfManufacture)}!"));
			Validations.LessThan(ModelYear, DateTime.Now.Year + 1, ($"Valor inválido para o campo {nameof(ModelYear)}!"));
		}
	}
}
