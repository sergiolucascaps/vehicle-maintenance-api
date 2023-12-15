using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Interfaces.Services;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Domain.Services
{
	public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task<User?> Create(User brand)
		{
			// TODO: @sergiolucascaps - Implement Domain Validations
			var created = await _userRepository.Create(brand);

			return _userRepository.SaveChanges() > 0 ? created : null;
		}

		public async Task<bool> Delete(Guid id)
		{
			var toDelete = await _userRepository.GetById(id);

			if(toDelete is null) return false;

			toDelete.Delete();

			return await Update(toDelete) is not null;
		}

		public async Task<User?> Update(User brand)
		{
			// TODO: @sergiolucascaps - Implement Domain Validations
			var updated = _userRepository.Update(brand);

			return _userRepository.SaveChanges() > 0 ? updated : null;
		}
    }
}