using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Interfaces.Services;
using SL.VehicleMaintenance.Application.ViewModels;
using AutoMapper;

namespace SL.VehicleMaintenance.Application.Services
{
	public class BrandAppService : BaseAppService, IBrandAppService
	{
		private readonly IBrandService _brandService;
		private readonly IBrandRepository _brandRepository;

		public BrandAppService(
			IBrandService brandService,
			IBrandRepository brandRepository,
			IMapper mapper) : base(mapper)
		{
			_brandService = brandService;
			_brandRepository = brandRepository;
		}

		public async Task<ICollection<BrandViewModel>> GetAllBrands()
		{
			var brands = await _brandRepository.ListAll();

			return brands.Any()
				? _mapper.Map<ICollection<BrandViewModel>>(brands)
				: new List<BrandViewModel>();
		}

		public async Task<BrandViewModel> GetById(Guid id)
			=> _mapper.Map<BrandViewModel>(await _brandRepository.GetById(id));
	}
}