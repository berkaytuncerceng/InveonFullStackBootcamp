using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
	[HttpGet("{id}")]
	public IActionResult GetItem(int id)
	{
		var items = new List<string> { "Item1", "Item2", "Item3" };

		if (id <= 0)
			throw new ArgumentException(ErrorMessages.BadRequest);

		var item = items.FirstOrDefault(i => i == $"Item{id}");

		if (item == null)
			throw new KeyNotFoundException();

		return Ok(item);
	}
}
