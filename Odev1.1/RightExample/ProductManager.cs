using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrongExample;

namespace RightExample
{
	internal class ProductManager
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

	}
}
