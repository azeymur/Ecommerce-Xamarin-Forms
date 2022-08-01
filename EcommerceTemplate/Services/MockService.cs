using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceTemplate.DataStores;
using EcommerceTemplate.Models;
using Xamarin.Forms;

namespace EcommerceTemplate.Services
{
    /// <summary>
    /// Mock service that works with mock data stores for testing.
    /// </summary>
    public class MockService : IService
    {
        ICategoryDataStore dataCategory => DependencyService.Get<ICategoryDataStore>();
        ICustomerDataStore dataCustomer = DependencyService.Get<ICustomerDataStore>();
        ICartItemDataStore dataCartItem => DependencyService.Get<ICartItemDataStore>();
        IProductDataStore dataProduct => DependencyService.Get<IProductDataStore>();
        IRatingDataStore dataRating => DependencyService.Get<IRatingDataStore>();
        IFavoriteDataStore dataFavorite => DependencyService.Get<IFavoriteDataStore>();
        IVariantDataStore dataVariant => DependencyService.Get<IVariantDataStore>();
        IBannerDataStore dataBanner => DependencyService.Get<IBannerDataStore>();

        // Methods for Customer entity

        public async Task<Customer> GetCustomerAsync(string id)
        {
            return await dataCustomer.GetAsync(id);
        }

        // Methods for CartItem entity

        public async Task<CartItem> AddCartItemAsync(CartItem cartItem)
        {
            var oldItem = dataCartItem.GetByAsync(i => i.ProductId == cartItem.ProductId &&
                                                        i.VariantId == cartItem.VariantId &&
                                                        i.UnitPrice == cartItem.UnitPrice)
                            .Result.FirstOrDefault();

            if (oldItem == null)
                return await dataCartItem.AddAsync(cartItem);
            else
            {
                oldItem.Quantity += cartItem.Quantity;
                await dataCartItem.UpdateAsync(oldItem);
                return oldItem;
            }
        }

        public async Task<bool> UpdateCartItemAsync(CartItem cartItem)
        {
            return await dataCartItem.UpdateAsync(cartItem);
        }

        public async Task<bool> IsInCartAsync(string productId)
        {
            var result = (await dataCartItem.GetAllAsync())
                            .Any(i => i.ProductId == productId);

            return await Task.FromResult(result);
        }

        public async Task<int> GetQuantityInCartAsync(string productId)
        {
            var result = (await dataCartItem.GetAllAsync())
                            .Where(i => i.ProductId == productId).Sum(s => s.Quantity);

            return await Task.FromResult(result);
        }

        // Methods for Category entity

        public async Task<IEnumerable<Category>> GetCategoriesAsync(string name)
        {
            var result = await dataCategory.GetByAsync(i => name == null || i.Name.Contains(name));

            return await Task.FromResult(result);
        }

        // Methods for Product entity

        public async Task<Product> GetProductAsync(string id)
        {
            return await dataProduct.GetAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string[] productIds = null, string key = null,
                                                    bool onlyFavorite = false, bool onlyNew = false,
                                                    bool onlyFeatured = false, bool onlyPopular = false)
        {
            var result = (await dataProduct.GetByAsync(p => 
                                           (productIds == null || productIds.Contains(p.Id)) &&
                                           (key == null || p.Name.ToLower().Contains(key.ToLower())) &&
                                           (onlyNew == false || p.IsNew == true) &&
                                           (onlyFeatured == false || p.IsFeatured == true) &&
                                           (onlyPopular == false || p.IsPopular == true))).ToList()
                                .Select(i =>
                                {
                                    i.RatingCount = dataRating.GetByAsync(r => r.ProductId == i.Id).Result.Count();
                                    i.AverageRating = i.RatingCount > 0 ?
                                        (float)dataRating.GetByAsync(r =>
                                            r.ProductId == i.Id).Result.Sum(r => r.Star) / i.RatingCount : 0;
                                    i.IsFavorite = IsFavoriteAsync(Globals.LoggedCustomerId, i.Id).Result;
                                    i.QtyInCart = GetQuantityInCartAsync(i.Id).Result;
                                    i.IsSimple = IsSimpleItemAsync(i.Id).Result;
                                    return i;
                                }).Where(p => (onlyFavorite == false || p.IsFavorite == true));

            return await Task.FromResult(result);
        }

        // Methods for Banner entity

        public async Task<IEnumerable<Banner>> GetBannersAsync()
        {
            return await dataBanner.GetAllAsync();
        }

        // Methods for Favorite entity

        public async Task<Favorite> AddFavoriteAsync(Favorite favorite)
        {
            return await dataFavorite.AddAsync(favorite);
        }

        public async Task<bool> DeleteFavoriteAsync(string id)
        {
            return await dataFavorite.DeleteAsync(id);
        }

        public async Task<bool> IsFavoriteAsync(string customerId, string productId)
        {
            return await dataFavorite.IsExistAsync(f => f.CustomerId == customerId && f.ProductId == productId);
        }

        public async Task<Favorite> GetFavoriteAsync(string customerId, string productId)
        {
            return (await dataFavorite.GetByAsync(f => f.CustomerId == customerId && f.ProductId == productId))
                        .FirstOrDefault();
        }

        // Methods for Variant entity

        public async Task<IEnumerable<Variant>> GetVariantsAsync(string name, string productId)
        {
            return await dataVariant.GetByAsync(i => i.Name == name && i.ProductId == productId);
        }

        public async Task<bool> IsSimpleItemAsync(string productId)
        {
            return await dataVariant.IsExistAsync(i => i.ProductId == productId);
        }

    }
}
