using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Domain.Interfaces.Services;

namespace SL.VehicleMaintenance.Application.Services
{
	public class BrandAppService : IBrandAppService
	{
		private readonly IBrandService _brandService;

		public BrandAppService(IBrandService brandService)
		{
			_brandService = brandService;
		}
	}
}