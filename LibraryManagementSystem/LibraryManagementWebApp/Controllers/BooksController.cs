using LibraryManagementWebApp.Context;
using LibraryManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LibraryManagementWebApp.Controllers
{
	public class BooksController : Controller
	{
		private readonly ApplicationDbContext _context;

		public BooksController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Books
		[HttpGet]
		public IActionResult Index()
		{
			// Tüm kitapları al ve View'a gönder
			var books = _context.Books.ToList();
			return View(books); // Modeli View'a gönderiyoruz
		}

		// GET: Books/Details/5
		[HttpGet]
		public IActionResult Details(int id)
		{
			// İlgili kitabı ID'ye göre bul
			var book = _context.Books.FirstOrDefault(b => b.Id == id);
			if (book == null)
			{
				// Kitap bulunamazsa 404 NotFound döndür
				return NotFound();
			}
			return View(book); // Modeli View'a gönderiyoruz
		}
	}
}
