using Microsoft.AspNetCore.Mvc;
using NameAPI.Models;

namespace NameAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		private static List<Book> books = new List<Book>
		{
			new Book { Id = 1, Title = "Yaprak Dökümü", Author = "Reşat Nuri" },
			new Book { Id = 2, Title = "Aşk-ı Memnu", Author = "Halit Ziya" }
		};

		[HttpGet]
		public IActionResult GetBooks()
		{
			return Ok(books);
		}

		[HttpGet("{id}")]
		public IActionResult GetBookById(int id)
		{
			var book = books.FirstOrDefault(b => b.Id == id);
			if (book == null)
			{
				return NotFound("Book not found");
			}
			return Ok(book);
		}

		[HttpPost]
		public IActionResult AddBook([FromBody] Book newBook)
		{
			if (newBook == null)
			{
				return BadRequest("Invalid book data");
			}
			newBook.Id = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
			books.Add(newBook);
			return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
		}

		[HttpPut("{id}")]
		public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
		{
			var book = books.FirstOrDefault(b => b.Id == id);
			if (book == null)
			{
				return NotFound("Book not found");
			}
			if (updatedBook == null)
			{
				return BadRequest("Invalid book data");
			}
			book.Title = updatedBook.Title;
			book.Author = updatedBook.Author;
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteBook(int id)
		{
			var book = books.FirstOrDefault(b => b.Id == id);
			if (book == null)
			{
				return NotFound("Book not found");
			}
			books.Remove(book);
			return NoContent();
		}
	}


}
