namespace SL.VehicleMaintenance.Application.ViewModels
{
	public class UserViewModel: EntityViewModel
    {
        public required string Name { get; set; }

		public ICollection<PhoneViewModel> Phones { get; set; }
		public ICollection<EmailViewModel> Emails { get; set; }
		public ICollection<UserVehicleViewModel> Vehicles { get; set; }

		public UserViewModel() 
		{
			Phones = new List<PhoneViewModel>();
			Emails = new List<EmailViewModel>();
			Vehicles = new List<UserVehicleViewModel>();
		}
    }
}