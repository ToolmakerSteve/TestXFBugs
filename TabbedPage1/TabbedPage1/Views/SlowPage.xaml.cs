using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPage1.Views
{
	public partial class SlowPage : ContentPage
	{
		public SlowPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			if (!MyContents.IsVisible) {
				// Simulate a page that is slow to layout or load.
				await Task.Delay(3000);
				MyContents.IsVisible = true;
			}
		}

		protected override void OnDisappearing()
		{
			//MyContents.IsVisible = false;
			base.OnDisappearing();
		}
	}
}