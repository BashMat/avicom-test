using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using WpfAvicomInternTest.Models;
using WpfAvicomInternTest.Views;
using WpfAvicomInternTest.Commands;

namespace WpfAvicomInternTest.ViewModels
{
	public class ManagersViewModel : BaseViewModel
	{
		public MainViewModel mainViewModel;
		private ObservableCollection<Manager> _managers;

		public ObservableCollection<Manager> Managers
		{
			get => _managers;
			set
			{
				_managers = value;
				OnPropertyChanged(nameof(ManagersView));
			}
		}

		private Manager selectedManager;

		public Manager SelectedManager
		{
			get => selectedManager;
			set
			{
				selectedManager = value;
				OnPropertyChanged(nameof(ManagersView));
			}
		}

		public ICommand AddManagerCommand { get; set; }
		public ICommand EditManagerCommand { get; set; }
		public ICommand DeleteManagerCommand { get; set; }

		public ManagersViewModel(MainViewModel mainViewModel)
		{
			_managers = new ObservableCollection<Manager>()
			{
				new Manager()
				{
					Id = 1,
					Name = "A"
				},
				new Manager()
				{
					Id = 2,
					Name = "B"
				},
				new Manager()
				{
					Id = 3,
					Name = "C"
				},
				new Manager()
				{
					Id = 4,
					Name = "D"
				},
				new Manager()
				{
					Id = 5,
					Name = "E"
				},
				new Manager()
				{
					Id = 6,
					Name = "F"
				},
				new Manager()
				{
					Id = 7,
					Name = "G"
				},
				new Manager()
				{
					Id = 8,
					Name = "H"
				},
				new Manager()
				{
					Id = 9,
					Name = "I"
				}
			};

			this.mainViewModel = mainViewModel;
			AddManagerCommand = new AddManagerCommand(Managers);
			EditManagerCommand = new EditManagerCommand(Managers);
			DeleteManagerCommand = new DeleteManagerCommand(Managers);
		}
	}
}
