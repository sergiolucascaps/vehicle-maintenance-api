using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Interfaces.Services;
using SL.VehicleMaintenance.Application.ViewModels;
using AutoMapper;
using SL.VehicleMaintenance.Domain.Models;
using SL.VehicleMaintenance.Application.ViewModels.Grids;

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

		public async Task<bool> Any(Guid id)
			=> await _brandRepository.AnyAsync(x => x.Id == id);

		public async Task<BrandViewModel?> Create(BrandViewModel brand)
		{
			var created = await _brandService.Create(_mapper.Map<Brand>(brand));

			if(created is not null) return _mapper.Map<BrandViewModel>(created);

			return null;
		}
		
		public async Task<BrandViewModel?> Update(BrandViewModel brand)
		{
			var updated = await _brandService.Update(_mapper.Map<Brand>(brand));

			if(updated is not null) return _mapper.Map<BrandViewModel>(updated);

			return null;
		}

		public async Task<ICollection<BrandGridListViewModel>> GridList()
		{
			var brands = await _brandRepository.GridList();

			return brands.Any()
				? _mapper.Map<ICollection<BrandGridListViewModel>>(brands)
				: new List<BrandGridListViewModel>();
		}

		public async Task<BrandViewModel?> GetById(Guid id)
			=> _mapper.Map<BrandViewModel>(await _brandRepository.GetById(id));

		public async Task<bool> Delete(Guid id)
			=> await _brandService.Delete(id);
	}
}