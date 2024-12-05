using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightExample
{
	internal class ProductRepository
	{
		public void SaveToDatabase(string data)  //SRP UYMAZ veritabanı ile ilgili ürün sınıfı ile değil veri katmanında yapılmalı
		{
			{
				Console.WriteLine("Data saved to database: " + data);
			}
		}
	}
}
