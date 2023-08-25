using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAvicomInternTest.Models
{
	/// <summary>
	/// Есть клиент (Client) – физическое либо юридическое лицо с атрибутами: Имя, Статус, Менеджер, Купленные товары
	/// Один менеджер ведет нескольких клиентов
	/// Кроме того, у каждого клиента – юридического лица есть контакт (человек, с которым идет взаимодействие)
	/// </summary>
	public class Client
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Contact { get; set; } = string.Empty;
		public ClientType Type { get; set; }
		public ClientStatus Status { get; set; } = ClientStatus.OrdinaryClient;
		public int ManagerId { get; set; }
		public Manager Manager { get; set; } = null!;
		public List<Product> Products { get; set; } = new();
		public List<ClientProduct> clientProducts { get; set; } = new();
	}
}
