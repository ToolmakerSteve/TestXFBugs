using System;
using TabbedPage1.Services;
using TabbedPage1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage1
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			//MainPage = new AppShell();
			MainPage = new TabbedPage1();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
