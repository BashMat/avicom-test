using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAvicomInternTest.ViewModels;

namespace WpfAvicomInternTest.Commands
{
	public abstract class BaseCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public virtual bool CanExecute(object parameter)
		{
			return true;
		}
		public abstract void Execute(object parameter);

		protected void OnCanExecutedChanged()
		{
			CanExecuteChanged?.Invoke(this, new EventArgs());
		}
	}
}