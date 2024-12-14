using LibraryManagementWebApp.Context;
using LibraryManagementWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementWebApp.Context
{
	public static class DbInitializer
	{
		public static void Initialize(ApplicationDbContext context)
		{
			if (context.Books.Any()) return; 

			var books = new List<Book>
			{
				new Book { Title = "Kitap 1", Author = "Yazar 1", ISBN = "1234567890", PublicationYear = 2021, Genre = "Roman", Publisher = "Yayıncı 1", PageCount = 200, Language = "Türkçe", Summary = "Özet 1", AvailableCopies = 5 },
				new Book { Title = "Kitap 2", Author = "Yazar 2", ISBN = "0987654321", PublicationYear = 2022, Genre = "Bilim Kurgu", Publisher = "Yayıncı 2", PageCount = 300, Language = "İngilizce", Summary = "Özet 2", AvailableCopies = 3 }
			};

			context.Books.AddRange(books);
			context.SaveChanges();
		}
	}
}
