
namespace WrongExample
{
	public class ProductManager
	{
		private List<Product> _products;

		public ProductManager(List<Product> products)
		{
			_products = products;
		}
		public void AddProduct(Product product)
		{
			if (product != null)
			{
				_products.Add(product);
				Console.WriteLine($"Product {product.Name} added successfully.");
			}
			else
			{
				Console.WriteLine("Invalid product.");
			}
		}

		public void DeleteProduct(int id)
		{
			var product = _products.Find(p => p.Id == id);
			if (product != null)
			{
				_products.Remove(product);
				Console.WriteLine($"Product {id} deleted successfully.");
			}
			else
			{
				Console.WriteLine("Product not found.");
			}
		}
		public Product GetProductById(int id)
		{
			return _products.SingleOrDefault(p => p.Id == id);
		}

		public void Log(string message) //SRP UYMAZ veritabanı ile ilgili ürün sınıfı ile değil veri katmanında yapılmalı
		{
			Console.WriteLine("Log: " + message);
		}

		public void SaveToDatabase(string data)  //SRP UYMAZ veritabanı ile ilgili ürün sınıfı ile değil veri katmanında yapılmalı
		{
			{
				Console.WriteLine("Data saved to database: " + data);
			}
		}
	}
}
