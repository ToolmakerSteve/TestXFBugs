using System.ComponentModel;
using Xamarin.Forms;
using XFShellApp.ViewModels;

namespace XFShellApp.Views
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