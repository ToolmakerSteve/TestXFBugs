using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace TestXFUWP
{
	class VMWithQueryData : Xamarin.Forms.BindableObject
	{

		public VMWithQueryData()
		{
			// Start an async task to query.
			Xamarin.Forms.Device.BeginInvokeOnMainThread(async () => {
				await QueryItemsAsync();
			});

			// Alternative implementation: Start a background task to query.
			//QueryItemsInBackground();
		}

		public ObservableCollection<ItemModel> Items {
			get => _items;
			set {
				_items = value;
				OnPropertyChanged();
			}
		}
		private ObservableCollection<ItemModel> _items;


		private async Task QueryItemsAsync()
		{
			var names = new List<string> { "One", "Two", "Three" };
			bool queryOneAtATime = false;// true;
			if (queryOneAtATime) {
				// Show each item as it is available.
				Items = new ObservableCollection<ItemModel>();
				foreach (var name in names) {
					// Simulate slow query - replace with query that returns one item.
					await Task.Delay(1000);
					Items.Add(new ItemModel(name));
				}
			} else {
				// Load all the items, then show them.
				// Simulate slow query - replace with query that returns all data.
				await Task.Delay(3000);
				var items = new ObservableCollection<ItemModel>();
				foreach (var name in names) {
					items.Add(new ItemModel(name));
				}
				Items = items;
			}
		}

		// Alternative implementation, using a background thread.
		private void QueryItemsInBackground()
		{
			_ = Task.Run(() => {
				var names = new List<string> { "One", "Two", "Three" };
				bool queryOneAtATime = false;// true;
				if (queryOneAtATime) {
					// Show each item as it is available.
					Items = new ObservableCollection<ItemModel>();
					foreach (var name in names) {
						// Simulate slow query - replace with query that returns one item.
						System.Threading.Thread.Sleep(1000);
						Items.Add(new ItemModel(name));
					}
				} else {
					// Load all the items, then show them.
					// Simulate slow query - replace with query that returns all data.
					System.Threading.Thread.Sleep(3000);
					var items = new ObservableCollection<ItemModel>();
					foreach (var name in names) {
						items.Add(new ItemModel(name));
					}
					Items = items;
				}
			});


		}
	}
}
