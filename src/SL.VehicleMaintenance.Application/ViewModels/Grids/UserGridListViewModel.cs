namespace SL.VehicleMaintenance.Application.ViewModels.Grids
{
	public class UserGridListViewModel
    {
        public Guid Id { get; set; }
		public required string Name { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
    }
}