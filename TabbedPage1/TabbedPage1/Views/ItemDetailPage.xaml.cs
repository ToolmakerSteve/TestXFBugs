using System.ComponentModel;
using TabbedPage1.ViewModels;
using Xamarin.Forms;

namespace TabbedPage1.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}