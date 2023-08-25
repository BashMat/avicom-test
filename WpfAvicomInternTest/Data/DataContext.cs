using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAvicomInternTest.Models;

namespace WpfAvicomInternTest.Data
{
	internal class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) {}

		public DbSet<Manager> Managers;
	}
}
