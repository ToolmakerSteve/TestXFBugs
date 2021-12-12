using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFShellApp.Views
{
	public partial class HelpPage : ContentPage
	{
		public static bool Entering;
		public static bool FakePageVisible;

		public HelpPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			// Make sure this only happens once (just in case).
			if (Entering) {
				Entering = false;
				FakePageVisible = true;
				Xamarin.Essentials.Browser.OpenAsync("https://aka.ms/xamarin-quickstart");
			}

		}
	}
}