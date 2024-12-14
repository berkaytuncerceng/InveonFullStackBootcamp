using LibraryManagementWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementWebApp.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> _userManager;

		public UserController(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		
		[HttpPost("add")]
		public async Task<IActionResult> CreateUser([FromBody] ApplicationUser user)
		{
			var result = await _userManager.CreateAsync(user);
			if (result.Succeeded)
			{
				return Ok("Kullanıcı oluşturuldu.");
			}
			return BadRequest(result.Errors);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetUser(string id)
		{
			var user = await _userManager.FindByIdAsync(id);
			if (user == null) return NotFound("Kullanıcı bulunamadı.");
			return Ok(user);
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateUser(string id, [FromBody] ApplicationUser updatedUser)
		{
			var user = await _userManager.FindByIdAsync(id);
			if (user == null) return NotFound("Kullanıcı bulunamadı.");

			user.UserName = updatedUser.UserName;
			user.Email = updatedUser.Email;

			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return Ok("Kullanıcı güncellendi.");
			}
			return BadRequest(result.Errors);
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(string id)
		{
			var user = await _userManager.FindByIdAsync(id);
			if (user == null) return NotFound("Kullanıcı bulunamadı.");

			var result = await _userManager.DeleteAsync(user);
			if (result.Succeeded)
			{
				return Ok("Kullanıcı silindi.");
			}
			return BadRequest(result.Errors);
		}
	}
}
