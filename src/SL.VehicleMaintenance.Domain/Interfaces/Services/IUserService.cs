using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Domain.Interfaces.Services
{
	public interface IUserService
    {
        Task<User?> Create(User brand);
		Task<User?> Update(User brand);
		Task<bool> Delete(Guid id);
    }
}