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
	internal class EditManagerCommand : BaseCommand
	{
		private ObservableCollection<Manager> managers;

		public EditManagerCommand(ObservableCollection<Manager> managers)
		{
			this.managers = managers;
		}

		public override void Execute(object parameter)
		{
			var managersViewModel = (ManagersViewModel)parameter;
			var manager = new Manager();

			if (managersViewModel.SelectedManager == null)
			{
				return;
			}
			manager.Id = managersViewModel.SelectedManager.Id;
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

			// Does not update GridView for some reason
			//managers.FirstOrDefault(m => m.Id == manager.Id).Name = setManagerViewModel.Name;

			manager.Name = setManagerViewModel.Name;
			managers.Remove(managersViewModel.SelectedManager);
			managers.Add(manager);

		}
	}
}