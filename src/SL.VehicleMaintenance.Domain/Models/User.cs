using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class User : Entity
	{
		public required string Name { get; set; }

		public ICollection<Phone> Phones { get; set; }
		public ICollection<Email> Emails { get; set; }
		public ICollection<UserVehicle> Vehicles { get; set; }

		protected User() 
		{
			Phones = new List<Phone>();
			Emails = new List<Email>();
			Vehicles = new List<UserVehicle>();
		}

		public User(string name, ICollection<Phone> phones, ICollection<Email> emails, ICollection<UserVehicle> vehicles)
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
