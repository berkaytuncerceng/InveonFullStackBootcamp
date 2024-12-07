using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
	static async Task Main(string[] args)
	{
		try
		{
			Console.WriteLine("Alışveriş sepeti yükleniyor...");

			var shoppingCart = await LoadShoppingCartAsync();

			Console.WriteLine("Sepet yüklendi:");
			foreach (var item in shoppingCart)
			{
				Console.WriteLine($"- {item.Name}: {item.Quantity} adet");
			}

			Console.WriteLine("\nSipariş oluşturuluyor...");
			var orderResponse = await PlaceOrderAsync(shoppingCart);

			if (orderResponse.IsSuccess)
			{
				Console.WriteLine($"Sipariş başarıyla oluşturuldu! Sipariş ID: {orderResponse.OrderId}");
			}
			else
			{
				Console.WriteLine("Sipariş oluşturulurken bir hata oluştu.");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Genel hata: {ex.Message}");
		}
	}
	static async Task<List<Product>> LoadShoppingCartAsync()
	{
		try
		{
			Console.WriteLine("API'den alışveriş sepeti yükleniyor...");
			await Task.Delay(1000); 

			var cart = new List<Product>
			{
				new Product { Name = "Telefon", Quantity = 1 },
				new Product { Name = "Kamera", Quantity = 2 },
				new Product { Name = "Kulaklık", Quantity = 3 }
			};

			if (cart == null)
			{
				throw new InvalidOperationException("Sepet yüklenemedi!");
			}

			return cart;
		}
		catch (HttpRequestException ex)
		{
			Console.WriteLine("Ağ hatası oluştu. Lütfen internet bağlantınızı kontrol edin.");
			throw new Exception("API'ye bağlanırken bir sorun oluştu", ex); 
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Hata: {ex.Message}");
			throw;
		}
	}
	static async Task<OrderResponse> PlaceOrderAsync(List<Product> shoppingCart)
	{
		try
		{
			Console.WriteLine("API'ye sipariş gönderiliyor...");
			await Task.Delay(2000); 
			var response = new OrderResponse
			{
				IsSuccess = true,
				OrderId = "1"
			};

			if (!response.IsSuccess)
			{
				throw new InvalidOperationException("Sipariş API tarafından reddedildi.");
			}

			return response;
		}
		catch (InvalidOperationException ex)
		{
			Console.WriteLine($"Sipariş işlemi hatası: {ex.Message}");
			return new OrderResponse { IsSuccess = false };
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Hata: {ex.Message}");
			throw;
		}
	}
}

class Product
{
	public required string Name { get; set; }
	public int Quantity { get; set; }
}

class OrderResponse
{
	public bool IsSuccess { get; set; }
	public string? OrderId { get; set; }
}
