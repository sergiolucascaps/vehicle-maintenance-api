namespace SL.VehicleMaintenance.Application.ViewModels.Grids
{
	public class BrandGridListViewModel
	{
		public Guid Id { get; set; }
		public required string Name { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
	}
}