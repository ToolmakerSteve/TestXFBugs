using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXFUWP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CollectionWithEmptyViewPage : ContentPage
	{
		public CollectionWithEmptyViewPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		public ObservableCollection<Model> Items { get; set; }

		// Start "true", so InitializeComponent will begin with it there.
		private bool _showContent = true;
		public bool ShowContent {
			get => _showContent;
			set {
				_showContent = value;
				OnPropertyChanged();
			}
		}
	}



	public class Model
	{

	}
}