using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestBugs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EvenlySpaceItemsScrolling : ContentPage
	{
		public EvenlySpaceItemsScrolling()
		{
			InitializeComponent();

			BindingContext = this;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			const int NItemsToShow = 5;
			const int ItemWidth = 30;
			// If the amount of space to left and right of scrolling area is known,
			// we can handle it before the page is laid out.
			// See xaml: the width of left column is 44, right column is 44.
			const int SubtractThisWidth = 44 + 44;
			Solution1(NItemsToShow, ItemWidth, SubtractThisWidth);
		}


		/// <summary>
		/// If the amount of space to left and right of scrolling area is known,
		/// we can handle it before the page is laid out.
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private void Solution1(int nItemsToShow, int itemWidth, int subtractThisWidth)
		{
			int collectionWidth = (int)ScreenLogicalWidth() - subtractThisWidth;
			int widthPerItem = collectionWidth / nItemsToShow;
			int spacing = Math.Max(0, widthPerItem - itemWidth);
			int leftMargin = spacing / 2;

			this.MyItemsLayout.ItemSpacing = spacing;
			this.clv.Margin = new Thickness(leftMargin, 0, 0, 0);

			// --- Manually test values that work well at a specific screen width. ---
			//this.MyItemsLayout.ItemSpacing = 30;
			//this.clv.Margin = new Thickness(15, 0, 0, 0);
		}

		public static double ScreenLogicalWidth()
		{
			return DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;
		}

		// For demo, this is only used to get a count of items.
		// Replace with your actual source.
		public ObservableCollection<Model> ImagesArray { get; set; } = new ObservableCollection<Model> {
			new Model(),
			new Model(),
			new Model(),
			new Model(),
			new Model(),
		};
	}
}