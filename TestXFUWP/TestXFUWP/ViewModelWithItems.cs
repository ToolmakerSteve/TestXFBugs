using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TestXFUWP
{
	public class ViewModelWithItems : Xamarin.Forms.BindableObject
	{
		public ViewModelWithItems()
		{
		}


		public ObservableCollection<ItemModel> Items {
			get => _items;
			set {
				_items = value;
				OnPropertyChanged();
			}
		}
		private ObservableCollection<ItemModel> _items;


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
