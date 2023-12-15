using SL.VehicleMaintenance.Application.ViewModels;
using SL.VehicleMaintenance.Application.ViewModels.Grids;

namespace SL.VehicleMaintenance.Application.Interfaces
{
	public interface IUserAppService
    {
        Task<ICollection<UserGridListViewModel>> GridList();
		Task<UserViewModel?> GetById(Guid id);
		Task<UserViewModel?> Create(UserViewModel user);
		Task<UserViewModel?> Update(UserViewModel user);
		Task<bool> Any(Guid id);
		Task<bool> Delete(Guid id);
    }
}