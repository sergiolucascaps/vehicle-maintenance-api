using SL.VehicleMaintenance.Domain.Interfaces.Repositories;
using SL.VehicleMaintenance.Domain.Interfaces.Services;
using SL.VehicleMaintenance.Domain.Models;

namespace SL.VehicleMaintenance.Domain.Services
{
	public class BrandService : BaseService<Brand>, IBrandService
	{
		private readonly IBrandRepository _brandRepository;

		public BrandService(IBrandRepository brandRepository)
		{
			_brandRepository = brandRepository;
		}

		public async Task<Brand?> Create(Brand brand)
		{
			// TODO: @sergiolucascaps - Implement Domain Validations
			var created = await _brandRepository.Create(brand);

			return _brandRepository.SaveChanges() > 0 ? created : null;
		}

		public async Task<bool> Delete(Guid id)
		{
			var toDelete = await _brandRepository.GetById(id);

			if(toDelete is null) return false;

			toDelete.Delete();

			return await Update(toDelete) is not null;
		}

		public async Task<Brand?> Update(Brand brand)
		{
			// TODO: @sergiolucascaps - Implement Domain Validations
			var updated = _brandRepository.Update(brand);

			return _brandRepository.SaveChanges() > 0 ? updated : null;
		}
	}
}