using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAvicomInternTest.Models
{
	/// <summary>
	/// Есть менеджер (Manager) с атрибутами: Имя
	/// Один менеджер ведет нескольких клиентов
	/// </summary>
	internal class Manager
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public List<Client> Clients { get; set; } = null; 
	}
}
