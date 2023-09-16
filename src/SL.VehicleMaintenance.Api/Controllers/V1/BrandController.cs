
using Microsoft.AspNetCore.Mvc;

namespace SL.VehicleMaintenance.Api.Controllers.V1
{
	[Route("api/v1/[controller]")]
    [ApiController]
	public class BrandController : ControllerBase
	{
		[HttpGet("get-all")]
		public async Task<IActionResult> GetAll()
		{
			throw new NotImplementedException();
		}

		[HttpGet("get-by-id")]
		public async Task<IActionResult> GetById()
		{
			throw new NotImplementedException();
		}
	}
}