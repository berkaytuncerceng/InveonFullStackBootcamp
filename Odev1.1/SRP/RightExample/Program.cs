using RightExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongExample
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>
			{
				new Product { Id = 1, Name = "Product1", Price = 100.0m, Description = "Description of Product 1" },
				new Product { Id = 2, Name = "Product2", Price = 150.0m, Description = "Description of Product 2" }
			};

			ProductManager productManager = new ProductManager(products);

			productManager.AddProduct(new Product { Id = 3, Name = "Product3", Price = 200.0m, Description = "Description of Product 3" });

			var searched_product = productManager.GetProductById(3);
			if (searched_product != null)
			{
				Console.WriteLine($"Found product: {searched_product.Name}");
			}


		}
	}
}
