using SL.VehicleMaintenance.Application.Enumerators;

namespace SL.VehicleMaintenance.Application.ViewModels
{
	public class PhoneViewModel : EntityViewModel
    {
        public required string Number { get; set; }
		public string? Description { get; set; }
		public PhoneTypeEnumViewModel PhoneType { get; set; }
		public bool IsMain { get; set; }

		public Guid UserId { get; set; }

		public PhoneViewModel()
		{ }
    }
}