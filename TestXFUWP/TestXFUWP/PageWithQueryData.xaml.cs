﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXFUWP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageWithQueryData : ContentPage
	{
		public PageWithQueryData()
		{
			InitializeComponent();

			var vm = new VMWithQueryData();

			MyCollection.SetBinding(ItemsView.ItemsSourceProperty, nameof(VMWithQueryData.Items));
			BindingContext = vm;
		}
	}
}