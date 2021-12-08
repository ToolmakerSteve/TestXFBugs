using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestXFUWP
{
	public partial class MainPage : ContentPage
	{
		public static readonly BindableProperty MyStringProperty =
			BindableProperty.Create(nameof(MyString), typeof(string), typeof(MainPage), "");

		public double MyString
		{
			get { return (double)GetValue(MyStringProperty); }
			set { SetValue(MyStringProperty, value); }
		}


		public MainPage()
		{
			InitializeComponent();
		}
	}
}
