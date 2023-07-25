using SL.VehicleMaintenance.Domain.DomainObjects;
using SL.VehicleMaintenance.Domain.DomainObjects.Enumerators;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class EmailModel : Entity
	{
		public required string Email { get; set; }
		public string? Description { get; set; }
		public EmailTypeEnumModel EmailType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }
		public required UserModel User { get; set; }

		protected EmailModel() { }

		public EmailModel(string email, string description, EmailTypeEnumModel emailType, bool isMain, Guid userId, UserModel user)
		{
			Email = email;
			Description = description;
			EmailType = emailType;
			IsMain = isMain;
			UserId = userId;
			User = user;

			Validate();
		}

		public void Validate()
		{
			Validations.Required(Email, ($"O campo {nameof(Email)} é obrigatório!"));
			Validations.MinMaxLength(Email, 8, 150, ($"Tamanho inválido para o campo {nameof(Email)}!"));
			Validations.MinMaxLength(Description, 2, 150, ($"Tamanho inválido para o campo {nameof(Description)}!"));
			Validations.IsEquals(UserId, Guid.NewGuid(), ($"Valor inválido para o campo {nameof(UserId)}!"));
		}
	}
}
