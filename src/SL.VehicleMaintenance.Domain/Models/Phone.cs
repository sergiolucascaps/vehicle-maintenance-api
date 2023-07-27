using SL.VehicleMaintenance.Domain.DomainObjects;
using SL.VehicleMaintenance.Domain.DomainObjects.Enumerators;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class Phone : Entity
	{
		public required string Number { get; set; }
		public string? Description { get; set; }
		public PhoneTypeEnumModel PhoneType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }
		public required User User { get; set; }

		protected Phone() { }

		public Phone(string number, string description, PhoneTypeEnumModel phoneType, bool isMain, Guid userId, User user)
		{
			Number = number;
			Description = description;
			PhoneType = phoneType;
			IsMain = isMain;
			UserId = userId;
			User = user;

			Validate();
		}

		public void Validate()
		{
			Validations.Required(Number, ($"O campo {nameof(Number)} é obrigatório!"));
			Validations.MinMaxLength(Number, 8, 15, ($"Tamanho inválido para o campo {nameof(Number)}!"));
			Validations.MinMaxLength(Description, 2, 150, ($"Tamanho inválido para o campo {nameof(Description)}!"));
			Validations.IsEquals(UserId, Guid.NewGuid(), ($"Valor inválido para o campo {nameof(UserId)}!"));
		}
	}
}
