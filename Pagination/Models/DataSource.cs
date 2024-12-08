namespace Pagination.Models
{
	public static class DataSource
	{
		public static List<Book> GetItems()
		{
			return Enumerable.Range(1, 100).Select(i => new Book
			{
				Id = i,
				Name = $"Item {i}"
			}).ToList();
		}
	}

}
