using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFShellApp.ViewModels;
using XFShellApp.Views;

namespace XFShellApp
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
			// Define a route that isn't a child of Shell.
			Routing.RegisterRoute("Help2", typeof(HelpPage));

			//if (true) {
			//	// Start on login page.
			//	Device.BeginInvokeOnMainThread(async () => {
			//		await System.Threading.Tasks.Task.Delay(100);
			//		await Shell.Current.GoToAsync("//LoginPage");
			//	});
			//}
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}

		protected override void OnNavigating(ShellNavigatingEventArgs args)
		{
			base.OnNavigating(args);

			if (args.Current != null) {
				if (args.Source == ShellNavigationSource.ShellItemChanged) {
					if (args.Target.Location.OriginalString == "//HelpPage") {
						// Cancel the original route.
						args.Cancel();
						Device.BeginInvokeOnMainThread(() => {
							// Used by the next OnAppearing.
							HelpPage.Entering = true;
							// Go there by a route that isn't a child of Shell.
							Shell.Current.GoToAsync("Help2");
						});
					}
				}
			}
		}
	}
}
