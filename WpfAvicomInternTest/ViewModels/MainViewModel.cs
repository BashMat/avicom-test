using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAvicomInternTest.Commands;
using System.Windows.Input;

namespace WpfAvicomInternTest.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		private BaseViewModel selectedViewModel;
		public BaseViewModel SelectedViewModel
		{
			get
			{ 
				return selectedViewModel;
			}
			set
			{
				selectedViewModel = value;
				OnPropertyChanged(nameof(SelectedViewModel));
			}
		}

		public ICommand NavigateCommand { get; set; }

		public MainViewModel()
		{
			NavigateCommand = new NavigateCommand(this);
		}
	}
}
