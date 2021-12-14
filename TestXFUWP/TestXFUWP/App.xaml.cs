using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXFUWP
{
	public partial class App : Application
	{
		public App()
		{
			Test();
			InitializeComponent();

			//MainPage = new MainPage();
			//MainPage = new TestBugs.AbsoluteLayoutPage();
			//MainPage = new CollectionWithEmptyViewPage();
			MainPage = new PageWithQueryData();

			//var names = new List<string> { "One", "Two", "Three", "Four" };
			//MainPage = SelfBoundPageWithCollection.Create(names);
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}

		private void Test()
		{
			//ColorX.MakeMe();
		}
	}
}
