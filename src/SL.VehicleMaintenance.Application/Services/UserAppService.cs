using AutoMapper;
using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Application.ViewModels;
using SL.VehicleMaintenance.Application.ViewModels.Grids;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Interfaces.Services;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Application.Services
{
	public class UserAppService : BaseAppService, IUserAppService
    {
        private readonly IUserService _userService;
		private readonly IUserRepository _userRepository;

		public UserAppService(
			IUserService userService,
			IUserRepository userRepository,
			IMapper mapper) : base(mapper)
		{
			_userService = userService;
			_userRepository = userRepository;
		}

		public async Task<bool> Any(Guid id)
			=> await _userRepository.AnyAsync(x => x.Id == id);

		public async Task<UserViewModel?> Create(UserViewModel user)
		{
			var created = await _userService.Create(_mapper.Map<User>(user));

			if(created is not null) return _mapper.Map<UserViewModel>(created);

			return null;
		}
		
		public async Task<UserViewModel?> Update(UserViewModel user)
		{
			var updated = await _userService.Update(_mapper.Map<User>(user));

			if(updated is not null) return _mapper.Map<UserViewModel>(updated);

			return null;
		}

		public async Task<ICollection<UserGridListViewModel>> GridList()
		{
			var user = await _userRepository.GridList();

			return user.Any()
				? _mapper.Map<ICollection<UserGridListViewModel>>(user)
				: new List<UserGridListViewModel>();
		}

		public async Task<UserViewModel?> GetById(Guid id)
			=> _mapper.Map<UserViewModel>(await _userRepository.GetById(id));

		public async Task<bool> Delete(Guid id)
			=> await _userService.Delete(id);
    }
}