﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EcommerceTemplate.Models;
using Xamarin.Forms;
using EcommerceTemplate.Services;
using EcommerceTemplate.Views;

namespace EcommerceTemplate.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public ObservableCollection<ProductViewModel> NewItems { get; }
        public ObservableCollection<ProductViewModel> FeaturedItems { get; }
        public ObservableCollection<ProductViewModel> PopularItems { get; }
        public Dictionary<string, ProductViewModel> flyWeight { get; }

        public Command LoadPageCommand { get; }
        public Command<ProductViewModel> ItemCommand { get; }

        public HomeViewModel()
        {
            NewItems = new ObservableCollection<ProductViewModel>();
            FeaturedItems = new ObservableCollection<ProductViewModel>();
            PopularItems = new ObservableCollection<ProductViewModel>();
            flyWeight = new Dictionary<string, ProductViewModel>();

            LoadPageCommand = new Command(async () => await ExecuteLoadPageCommand());

            ItemCommand = new Command<ProductViewModel>(OnItemSelected);
        }

        async Task ExecuteLoadPageCommand()
        {
            ProductViewModel pvm;

            IsBusy = true;

            flyWeight.Clear();

            NewItems.Clear();
            var newItems = await service.GetProductsAsync(onlyNew: true);
            foreach (var item in newItems)
            {
                if (flyWeight.TryGetValue(item.Id, out pvm) == false)
                {
                    pvm = new ProductViewModel(item);
                    flyWeight.Add(item.Id, pvm);
                }
                    
                NewItems.Add(pvm);
            }

            FeaturedItems.Clear();
            var featuredItems = await service.GetProductsAsync(onlyFeatured: true);
            foreach (var item in featuredItems)
            {
                if (flyWeight.TryGetValue(item.Id, out pvm) == false)
                {
                    pvm = new ProductViewModel(item);
                    flyWeight.Add(item.Id, pvm);
                }

                FeaturedItems.Add(pvm);
            }

            PopularItems.Clear();
            var popularItems = await service.GetProductsAsync(onlyPopular: true);
            foreach (var item in popularItems)
            {
                if (flyWeight.TryGetValue(item.Id, out pvm) == false)
                {
                    pvm = new ProductViewModel(item);
                    flyWeight.Add(item.Id, pvm);
                }

                PopularItems.Add(pvm);
            }

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async void OnItemSelected(ProductViewModel item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(ProductDetailPage)}?{nameof(ProductDetailViewModel.ProductId)}={item.Id}");
        }

    }
}
