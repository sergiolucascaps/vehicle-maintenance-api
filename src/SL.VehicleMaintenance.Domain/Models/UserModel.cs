using SL.VehicleMaintenance.Domain.DomainObjects;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class UserModel : Entity
	{
		public required string Name { get; set; }

		public ICollection<PhoneModel> Phones { get; set; }
		public ICollection<EmailModel> Emails { get; set; }

		protected UserModel()
		{
			Phones = new List<PhoneModel>();
			Emails = new List<EmailModel>();
		}

		// TODO: @sergiolucascaps - Write Validations
	}
}
