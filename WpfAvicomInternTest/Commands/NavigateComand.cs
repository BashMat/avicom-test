using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAvicomInternTest.ViewModels;

namespace WpfAvicomInternTest.Commands
{
	public class NavigateCommand : BaseCommand
	{
		private readonly MainViewModel _viewModel;

		public NavigateCommand(MainViewModel viewModel)
		{
			_viewModel = viewModel;
		}

		public override void Execute(object parameter)
		{
			// Enum or DI would be better
			if (parameter.ToString() == "Clients")
			{
				_viewModel.SelectedViewModel = new ClientsViewModel();
			}
			else if (parameter.ToString() == "Managers")
			{
				_viewModel.SelectedViewModel = new ManagersViewModel(_viewModel);
			}
			else if (parameter.ToString() == "Products")
			{
				_viewModel.SelectedViewModel = new ProductsViewModel();
			}
		}
	}
}
