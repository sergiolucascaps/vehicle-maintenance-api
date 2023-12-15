using SL.VehicleMaintenance.Application.Enumerators;

namespace SL.VehicleMaintenance.Application.ViewModels
{
	public class EmailViewModel: EntityViewModel
    {
        public required string EmailAddress { get; set; }
		public string? Description { get; set; }
		public EmailTypeEnumViewModel EmailType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }
    }
}