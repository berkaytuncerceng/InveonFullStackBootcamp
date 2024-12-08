using Microsoft.AspNetCore.Mvc;

namespace Caching.Controllers
{
	using Caching.Models;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.Extensions.Caching.Distributed;
	using System.Text.Json;

	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IDistributedCache _cache;

		public UserController(IDistributedCache cache)
		{
			_cache = cache;
		}

		[HttpGet("{userId}")]
		public async Task<IActionResult> GetUser(int userId)
		{
			string cacheKey = $"user:{userId}"; 

			var cachedUser = await _cache.GetStringAsync(cacheKey);

			if (cachedUser != null)
			{
				return Ok(JsonSerializer.Deserialize<User>(cachedUser));
			}

			var user = await GetUserFromApi(userId);

			if (user == null)
			{
				return NotFound();
			}

			var serializedUser = JsonSerializer.Serialize(user);
			var options = new DistributedCacheEntryOptions()
				.SetSlidingExpiration(TimeSpan.FromMinutes(10))  // 10 dakika boyunca cache'te sakla
				.SetAbsoluteExpiration(TimeSpan.FromHours(1)); // 1 saat sonra cache sona ersin

			await _cache.SetStringAsync(cacheKey, serializedUser, options);

			return Ok(user);
		}

		private async Task<User> GetUserFromApi(int userId)
		{
			
			return new User { Id = userId, Name = "John Doe" };
		}
	}



}
