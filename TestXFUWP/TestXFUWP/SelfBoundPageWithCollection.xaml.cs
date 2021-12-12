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
	public partial class SelfBoundPageWithCollection : ContentPage
	{
		public SelfBoundPageWithCollection()
		{
			InitializeComponent();
			BindingContext = this;
		}

		public ObservableCollection<ItemModel> Items {
			get => _items;
			set {
				_items = value;
				OnPropertyChanged();
			}
		}
		private ObservableCollection<ItemModel> _items;


		public static SelfBoundPageWithCollection Create(List<string> names)
		{
			var it = new SelfBoundPageWithCollection();

			it.FillItems(names);

			return it;
		}

		// Can call this directly later, to replace Items collection.
		public void FillItems(List<string> names)
		{
			var items = new ObservableCollection<ItemModel>();
			foreach (var name in names) {
				items.Add(new ItemModel(name));
			}
			Items = items;
		}
	}
}