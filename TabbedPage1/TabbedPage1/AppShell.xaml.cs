using System;
using System.Collections.Generic;
using TabbedPage1.ViewModels;
using TabbedPage1.Views;
using Xamarin.Forms;

namespace TabbedPage1
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
