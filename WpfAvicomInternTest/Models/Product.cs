using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAvicomInternTest.Models;

namespace WpfAvicomInternTest.Models
{
	/// <summary>
	/// Есть Товар (Product) с атрибутами: Название, Цена, Тип(подписка или постоянная лицензия),
	/// Срок подписки(месяц / квартал / год)
	/// </summary>
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public ProductType Type { get; set; }
		public ProductDuration Duration { get; set; }
		List<Client> clients { get; set; } = new();
		List<ClientProduct> clientProducts { get; set; } = new();
	}
}
