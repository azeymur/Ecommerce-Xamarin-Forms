using EcommerceTemplate.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using EcommerceTemplate.Services;
using System.Threading.Tasks;
using EcommerceTemplate.Views;
using EcommerceTemplate.Resources;

namespace EcommerceTemplate.ViewModels
{
    [QueryProperty(nameof(ProductId), nameof(ProductId))]
    public class ProductDetailViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<ProductViewModel> RelatedItems { get; }
        public ObservableCollection<VariantViewModel> SizeValues { get; }

        public Command ImageChangedCommand { get; }
        public Command RatingsCommand { get; }
        public Command FavoriteCommand { get; }
        public Command AddToCartCommand { get; }
        public Command<ProductViewModel> RelatedItemCommand { get; }
        public Command<VariantViewModel> SizeCommand { get; }

        private string productId;
        public string ProductId
        {
            get => productId;
            set
            {
                productId = value;
                LoadProduct(value);
            }
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string description;
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        private string[] images;
        public string[] Images
        {
            get => images;
            set
            {
                SetProperty(ref images, value);
            }
        }

        private double price;
        public double Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        private double regularPrice;
        public double RegularPrice
        {
            get => regularPrice;
            set => SetProperty(ref regularPrice, value);
        }

        private float averageRating;
        public float AverageRating
        {
            get => averageRating;
            set => SetProperty(ref averageRating, value);
        }

        private int ratingCount;
        public int RatingCount
        {
            get => ratingCount;
            set => SetProperty(ref ratingCount, value);
        }

        private bool onSale;
        public bool OnSale
        {
            get => onSale;
            set => SetProperty(ref onSale, value);
        }

        private int discountRate;
        public int DiscountRate
        {
            get => discountRate;
            set => SetProperty(ref discountRate, value);
        }

        private bool isFavorite;
        public bool IsFavorite
        {
            get => isFavorite;
            set => SetProperty(ref isFavorite, value);
        }

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

        private bool isSimple;
        public bool IsSimple
        {
            get => isSimple;
            set => SetProperty(ref isSimple, value);
        }

        public bool HasAddedCart
        {
            get => qtyInCart > 0 ? true : false;
        }

        private string currentImage;

        private Product product;

        public ProductDetailViewModel()
        {
            RelatedItems = new ObservableCollection<ProductViewModel>();
            SizeValues = new ObservableCollection<VariantViewModel>();

            ImageChangedCommand = new Command<string>((i) => currentImage = i);

            RatingsCommand = new Command(async () => {
                await Shell.Current.DisplayAlert(AppResources.Info, AppResources.ButtonTapped, AppResources.OK);
            });

            FavoriteCommand = new Command(OnFavoriteTapped);

            AddToCartCommand = new Command(OnAddToCartTapped);

            RelatedItemCommand = new Command<ProductViewModel>(OnRelatedItemTapped);

            SizeCommand = new Command<VariantViewModel>(OnSizeTapped);
        }

        public async void LoadProduct(string id)
        {
            product = await service.GetProductAsync(id);
            Name = product.Name;
            Description = product.Description;
            Images = product.Images;
            Price = product.Price;
            RegularPrice = product.RegularPrice;
            AverageRating = product.AverageRating;
            RatingCount = product.RatingCount;
            OnSale = product.OnSale;
            DiscountRate = product.DiscountRate;
            IsFavorite = product.IsFavorite;
            QtyInCart = product.QtyInCart;
            IsSimple = product.IsSimple;

            SizeValues.Clear();

            var sizeValues = await service.GetVariantsAsync("Size", id);

            foreach (var v in sizeValues)
                SizeValues.Add(new VariantViewModel(v));

            LoadRelatedItems();
        }

        public async void OnAppearing()
        {
            QtyInCart = await service.GetQuantityInCartAsync(productId);
            LoadRelatedItems();
        }

        async void LoadRelatedItems()
        {
            RelatedItems.Clear();

            var relatedItems = await service.GetProductsAsync(productIds: product.RelatedIds);

            foreach (var product in relatedItems)
                RelatedItems.Add(new ProductViewModel(product));
        }

        async void OnFavoriteTapped()
        {
            var fav = await service.GetFavoriteAsync(Globals.LoggedCustomerId, productId);

            if (fav != null)
            {
                await service.DeleteFavoriteAsync(fav.Id);

                await Task.Delay(300);
                IsFavorite = false;
            }
            else
            {
                await service.AddFavoriteAsync(new Favorite
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = Globals.LoggedCustomerId,
                    ProductId = productId
                });

                IsFavorite = true;
            }
        }

        async void OnAddToCartTapped()
        {
            await service.AddCartItemAsync(new CartItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductId = productId,
                UnitPrice = (float)Price,
                Quantity = 1,
                VariantId = SizeValues.Where(v => v.IsSelected).FirstOrDefault()?.Id
            });

            QtyInCart += 1;
        }

        async void OnRelatedItemTapped(ProductViewModel item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(ProductDetailPage)}?" +
                                          $"{nameof(ProductDetailViewModel.ProductId)}={item.Id}");
        }

        void OnSizeTapped(VariantViewModel item)
        {
            if (item == null) return;
            if (item.IsAvailable == false) return;

            foreach (var v in SizeValues)
                if (v.Id == item.Id)
                    v.IsSelected = true;
                else
                    v.IsSelected = false;
        }

    }
}
