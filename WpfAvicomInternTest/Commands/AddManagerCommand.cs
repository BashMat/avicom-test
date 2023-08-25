using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAvicomInternTest.Models;
using WpfAvicomInternTest.ViewModels;
using WpfAvicomInternTest.Views;

namespace WpfAvicomInternTest.Commands
{
	internal class AddManagerCommand : BaseCommand
	{
		private ObservableCollection<Manager> managers;

		public AddManagerCommand(ObservableCollection<Manager> managers)
		{
			this.managers = managers;
		}

		//public event EventHandler CanExecuteChanged;

		public override bool CanExecute(object parameter)
		{
			return true;
		}

		public override void Execute(object parameter)
		{
			var manager = new Manager();
			var setManagerViewModel = new SetManagerViewModel();
			var setManagerView = new SetManagerView()
			{ 
				DataContext = setManagerViewModel
			};
			setManagerViewModel.CloseDialogCommand.Window = setManagerView;

			// null Name should be error checked to show warning in View
			if (setManagerView.ShowDialog() != true || setManagerViewModel.Name == null)
			{
				return;
			}

			manager.Name = setManagerViewModel.Name;
			// Id would be auto with DB
			manager.Id = managers.Count > 0 ? managers.Max(m => m.Id) + 1 : 1;
			managers.Add(manager);
		}
	}
}
