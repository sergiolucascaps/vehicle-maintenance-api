namespace SL.VehicleMaintenance.Application.ViewModels
{
	public abstract class EntityViewModel
	{
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
	}
}