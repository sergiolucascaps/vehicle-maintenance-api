using SL.VehicleMaintenance.Domain.DomainObjects;
using SL.VehicleMaintenance.Domain.DomainObjects.Enumerators;

namespace SL.VehicleMaintenance.Domain.Models
{
	public class Email : Entity
	{
		public required string EmailAddress { get; set; }
		public string? Description { get; set; }
		public EmailTypeEnumModel EmailType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }
		public required User User { get; set; }

		protected Email() { }

		public Email(string emailAddress, string description, EmailTypeEnumModel emailType, bool isMain, Guid userId, User user)
		{
			EmailAddress = emailAddress;
			Description = description;
			EmailType = emailType;
			IsMain = isMain;
			UserId = userId;
			User = user;

			Validate();
		}

		public void Validate()
		{
			Validations.Required(EmailAddress, ($"O campo {nameof(EmailAddress)} é obrigatório!"));
			Validations.MinMaxLength(EmailAddress, 8, 150, ($"Tamanho inválido para o campo {nameof(EmailAddress)}!"));
			Validations.MinMaxLength(Description, 2, 150, ($"Tamanho inválido para o campo {nameof(Description)}!"));
			Validations.IsEquals(UserId, Guid.NewGuid(), ($"Valor inválido para o campo {nameof(UserId)}!"));
		}
	}
}
