using Microsoft.AspNetCore.Mvc;
using SL.VehicleMaintenance.Application.Interfaces;
using SL.VehicleMaintenance.Application.ViewModels;

namespace SL.VehicleMaintenance.Api.Controllers.V1
{
	[Route("api/v1/[controller]")]
    [ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserAppService _userAppService;

		public UserController(IUserAppService userAppService)
		{
			_userAppService = userAppService;
		}

		[HttpGet("grid-list")]
		public async Task<IActionResult> GridList()
			=> Ok(await _userAppService.GridList());

		[HttpGet("get-by-id")]
		public async Task<IActionResult> GetById(Guid id)
			=> Ok(await _userAppService.GetById(id));

		[HttpPost("create")]
		public async Task<IActionResult> Create([FromBody] UserViewModel user)
		{
			if(user is null) return BadRequest();

			var created = await _userAppService.Create(user);

			if(created is null)
				return BadRequest(user);
			
			return CreatedAtAction(nameof(Create), created, created.Id);
		}

		[HttpPut("update")]
		public async Task<IActionResult> Update([FromBody] UserViewModel user)
		{
			if(user is null) return BadRequest();

			if(!await _userAppService.Any(user.Id))
				return NotFound();
			
			var updated = await _userAppService.Update(user);

			if(updated is null)
				return BadRequest(user);
			
			return Ok(updated);
		}

		[HttpDelete("delete")]
		public async Task<IActionResult> Delete([FromQuery] Guid id)
		{
			if(!await _userAppService.Any(id))
				return NotFound();
			
			var deleted = await _userAppService.Delete(id);

			if(!deleted)
				return BadRequest(id);
			
			return Ok(id);
		}
	}
}