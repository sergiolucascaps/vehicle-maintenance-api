
using Microsoft.AspNetCore.Mvc;
using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Application.ViewModels;

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

		[HttpPost("create")]
		public async Task<IActionResult> Create([FromBody] BrandViewModel brand)
		{
			if(brand is null) return BadRequest();
			
			var created = await _brandAppService.Create(brand);

			if(created is null)
				return BadRequest(brand);
			
			return CreatedAtAction(nameof(Create), created, created.Id);
		}
	}
}