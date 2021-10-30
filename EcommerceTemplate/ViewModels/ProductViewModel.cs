using System;
using EcommerceTemplate.Models;
using Xamarin.Forms;
using EcommerceTemplate.Services;
using EcommerceTemplate.Views;
using System.Collections.Generic;

namespace EcommerceTemplate.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command<ProductViewModel> AddToCartCommand { get; }

        public Command<ProductViewModel> ItemTappedCommand { get; }

        public string Id { get; }

        public string Name { get; }

        public float AverageRating { get; }

        public float Price { get; }

        public bool IsFavorite { get; }

        public bool OnSale { get; }

        public string FirstImage { get; }

        public bool IsSimple { get; }

        public bool IsComplex { get; }

        public IList<ProductImageViewModel> ProductImages { get; }

        private int qtyInCart;
        public int QtyInCart
        {
            get => qtyInCart;
            set
            {
                SetProperty(ref qtyInCart, value);
                OnPropertyChanged(nameof(HasAddedCart));
            }
        }

        public bool HasAddedCart
        {
            get { return qtyInCart > 0 ? true : false; }
        }

        public ProductViewModel(Product product)
        {
            ProductImages = new List<ProductImageViewModel>();

            AddToCartCommand = new Command<ProductViewModel>(OnAddToCartTapped);
            ItemTappedCommand = new Command<ProductViewModel>(OnItemTapped);

            Id = product.Id;
            Name = product.Name;
            AverageRating = product.AverageRating;
            Price = product.Price;
            IsFavorite = product.IsFavorite;
            OnSale = product.OnSale;
            FirstImage = product.FirstImage;
            QtyInCart = product.QtyInCart;
            IsSimple = product.IsSimple;
            IsComplex = product.IsComplex;

            foreach (var i in product.Images)
                ProductImages.Add(new ProductImageViewModel(i, this));
        }

        async void OnAddToCartTapped(ProductViewModel item)
        {
            await service.AddCartItemAsync(new CartItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = item.Id,
                UnitPrice = item.Price,
                Quantity = 1
            });

            item.QtyInCart += 1;
        }

        async void OnItemTapped(ProductViewModel item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(ProductDetailPage)}" +
                                          $"?{nameof(ProductDetailViewModel.ProductId)}={item.Id}");
        }

    }
}
