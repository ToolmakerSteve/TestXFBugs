using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellApp.Services;
using XFShellApp.Views;

namespace XFShellApp
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
			if (HelpPage.FakePageVisible) {
				HelpPage.FakePageVisible = false;
				var shell = MainPage as AppShell;
				if (shell != null) {
					shell.Navigation.PopAsync();
				}
			}
		}
	}
}
