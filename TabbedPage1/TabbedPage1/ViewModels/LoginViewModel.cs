using System;
using System.Collections.Generic;
using System.Text;
using TabbedPage1.Views;
using Xamarin.Forms;

namespace TabbedPage1.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		public Command LoginCommand { get; }

		public LoginViewModel()
		{
			LoginCommand = new Command(OnLoginClicked);
		}

		private async void OnLoginClicked(object obj)
		{
			//await Shell.Current.GoToAsync($"{nameof(HelpPage)}");
			// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
			//await Shell.Current.GoToAsync($"//{nameof(HelpPage)}");

			await Shell.Current.GoToAsync($"//BrowsePage");
			// Now can I push another page, have back arrow?
			await Shell.Current.GoToAsync($"{nameof(StartPage)}");
		}
	}
}
