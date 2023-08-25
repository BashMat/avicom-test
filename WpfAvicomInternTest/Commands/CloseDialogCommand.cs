using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAvicomInternTest.Commands
{
	public class CloseDialogCommand : BaseCommand
	{
		public Window Window { get; set; }

		public bool? Success { get; set; }

		public override void Execute(object parameter)
		{
			if (parameter != null)
				Success = Convert.ToBoolean(parameter);

			Window.DialogResult = Success;
			Window.Close();
		}
	}
}
