using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestBugs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NestedScrollGrid : ContentPage
	{
		public NestedScrollGrid()
		{
			InitializeComponent();
		}
	}
}