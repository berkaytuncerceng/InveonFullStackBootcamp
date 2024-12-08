using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightExample
{
	internal class Logger
	{
		public void Log(string message) //SRP UYMAZ veritabanı ile ilgili ürün sınıfı ile değil veri katmanında yapılmalı
		{
			Console.WriteLine("Log: " + message);
		}
	}
}
