
using Microsoft.AspNetCore.Mvc;
using SL.VehicleMaintenance.Application.Interfaces;

namespace SL.VehicleMaintenance.Api.Controllers.V1
{
	[Route("api/v1/[controller]")]
    [ApiController]
	public class BrandController : ControllerBase
	{
		private readonly IBrandAppService _brandAppService;

		public BrandController(IBrandAppService brandAppService)
		{
			_brandAppService = brandAppService;
		}

		[HttpGet("get-all")]
		public async Task<IActionResult> GetAll()
			=> Ok(await _brandAppService.GetAllBrands());

		[HttpGet("get-by-id")]
		public async Task<IActionResult> GetById(Guid id)
			=> Ok(await _brandAppService.GetById(id));
	}
}