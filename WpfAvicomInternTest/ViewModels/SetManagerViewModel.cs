using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAvicomInternTest.Commands;
using WpfAvicomInternTest.Models;

namespace WpfAvicomInternTest.ViewModels
{
	internal class SetManagerViewModel : BaseViewModel
	{
		public CloseDialogCommand CloseDialogCommand { get; set; }

		public string? Name { get; set; }

		public SetManagerViewModel()
		{
			CloseDialogCommand = new CloseDialogCommand();
		}
	}
}
