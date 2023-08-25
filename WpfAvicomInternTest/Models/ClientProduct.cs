using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAvicomInternTest.Models
{
	public class ClientProduct
	{
		public int ClientId { get; set; }
		public Client Client{ get; set; } = null!;
		public int ProductId { get; set; }
		public Product Product { get; set; } = null!;
		public DateTime CreatedDate { get; set; }
	}
}
