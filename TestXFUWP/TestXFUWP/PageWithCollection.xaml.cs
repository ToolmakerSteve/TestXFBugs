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
	public partial class PageWithCollection : ContentPage
	{
		public PageWithCollection()
		{
			InitializeComponent();
			BindingContext = new ViewModelWithItems();
		}


		public static PageWithCollection Create(List<string> names)
		{
			var it = new PageWithCollection();

			it.FillItems(names);

			return it;
		}

		// Can call this directly later, to replace Items collection.
		public void FillItems(List<string> names)
		{
			var vm = (ViewModelWithItems)BindingContext;
			vm.FillItems(names);
		}
	}
}