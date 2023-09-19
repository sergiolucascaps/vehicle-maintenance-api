using SL.VehicleMaintenance.Application.ViewModels;

namespace SL.VehicleMaintenance.Application.Interfaces
{
	public interface IBrandAppService
	{
		Task<ICollection<BrandViewModel>> GetAllBrands();
		Task<BrandViewModel> GetById(Guid id);
	}
}