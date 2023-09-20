using SL.VehicleMaintenance.Application.ViewModels;

namespace SL.VehicleMaintenance.Application.Interfaces
{
	public interface IBrandAppService
	{
		Task<ICollection<BrandViewModel>> GetAllBrands();
		Task<BrandViewModel?> GetById(Guid id);
		Task<BrandViewModel?> Create(BrandViewModel brand);
		Task<BrandViewModel?> Update(BrandViewModel brand);
		Task<bool> Any(Guid id);
		Task<bool> Delete(Guid id);
	}
}