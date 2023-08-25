using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAvicomInternTest.Models;
using WpfAvicomInternTest.ViewModels;
using WpfAvicomInternTest.Views;

namespace WpfAvicomInternTest.Commands
{
	internal class DeleteManagerCommand : BaseCommand
	{
		private ObservableCollection<Manager> managers;

		public DeleteManagerCommand(ObservableCollection<Manager> managers)
		{
			this.managers = managers;
		}


		public override void Execute(object parameter)
		{
			var managersViewModel = (ManagersViewModel)parameter;
			if (managersViewModel.SelectedManager == null)
			{
				return;
			}
			var manager = managersViewModel.SelectedManager;
			managers.Remove(manager);
		}
	}
}
