using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestBugs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TapFramePage : ContentPage
	{
		public TapFramePage()
		{
			InitializeComponent();
		}

		protected void Search_Tapped(object sender, EventArgs args)
		{
			// Do something here.
		}
	}
}