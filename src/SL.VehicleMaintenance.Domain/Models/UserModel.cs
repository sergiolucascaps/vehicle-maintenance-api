using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class UserModel : Entity
	{
		public required string Name { get; set; }

		public ICollection<PhoneModel> Phones { get; set; }
		public ICollection<EmailModel> Emails { get; set; }
		public ICollection<VehicleModel> Vehicles { get; set; }

		protected UserModel() 
		{
			Phones = new List<PhoneModel>();
			Emails = new List<EmailModel>();
			Vehicles = new List<VehicleModel>();
		}

		public UserModel(string name, ICollection<PhoneModel> phones, ICollection<EmailModel> emails, ICollection<VehicleModel> vehicles)
		{
			Name = name;
			Phones = phones;
			Emails = emails;
			Vehicles = vehicles;

			Validate();
		}

		public void Validate()
		{
			Validations.Required(Name, ($"O campo {nameof(Name)} é obrigatório!"));
			Validations.MinMaxLength(Name, 3, 150, ($"Tamanho inválido para o campo {nameof(Name)}!"));
		}
	}
}
