using System;
using System.Linq;
using System.Threading.Tasks;
using EcommerceTemplate.Models;
using Xamarin.Forms;
using EcommerceTemplate.Services;
using EcommerceTemplate.ViewModels;
using EcommerceTemplate.Views;

namespace EcommerceTemplate.Controls
{
    /// <summary>
    /// The SearchHandler class for Xamarin.Forms Shell's integrated search functionality.
    /// <see href="https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell/search"/>
    /// </summary>
    public class ProductSearchHandler : SearchHandler
    {
        public IService service = DependencyService.Get<IService>();
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = service.GetProductsAsync(key: newValue.ToLower()).Result.ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            await Task.Delay(1000);

            await Shell.Current.GoToAsync($"{nameof(ProductDetailPage)}" +
                                          $"?{nameof(ProductDetailViewModel.ProductId)}={((Product)item).Id}");
        }

    }
}
