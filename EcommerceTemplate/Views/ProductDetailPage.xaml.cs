using System;
using EcommerceTemplate.ViewModels;
using Xamarin.Forms;

namespace EcommerceTemplate.Views
{
    public partial class ProductDetailPage : ContentPage
    {
        ProductDetailViewModel viewModel;

        public ProductDetailPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ProductDetailViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }

        async void FavoriteChanged(Object sender, EventArgs e)
        {
            await lbFavorite.ScaleTo(1.25, 150);
            await lbFavorite.ScaleTo(1.0, 150);
        }

        async void QuantityChanged(Object sender, EventArgs e)
        {
            await pvQuantity.ScaleTo(1.25, 150);
            await pvQuantity.ScaleTo(1.0, 150);
        }
    }
}
