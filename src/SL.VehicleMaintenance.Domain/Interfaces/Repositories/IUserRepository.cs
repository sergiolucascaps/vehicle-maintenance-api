using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Domain.Models.Grids;

namespace SL.VehicleMaintenance.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<ICollection<UserGridList>> GridList();
		Task<User?> GetById(Guid id);
    }
}