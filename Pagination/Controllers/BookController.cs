using Microsoft.AspNetCore.Mvc;
using Pagination.Models;

namespace Pagination.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BookController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetItems([FromQuery] PaginationParameters pagination)
		{
			var books = DataSource.GetItems();

			var pagedItems = books
				.Skip(pagination.Skip)
				.Take(pagination.Take)
				.ToList();

			var response = new
			{
				TotalCount = books.Count,
				PageNumber = pagination.PageNumber,
				PageSize = pagination.PageSize,
				Data = pagedItems
			};

			return Ok(response);
		}
	}
}
