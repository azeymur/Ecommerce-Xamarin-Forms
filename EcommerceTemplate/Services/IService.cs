using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceTemplate.DataStores;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.Services
{
    /// <summary>
    /// Interface with common tasks
    /// </summary>
    public interface IService
    {

        /// <summary>
        /// Get customer by id
        /// </summary>
        /// <param name="id">Customer Id</param>
        /// <returns>Customer object or null</returns>
        Task<Customer> GetCustomerAsync(string id);

        /// <summary>
        /// Add the cart item
        /// </summary>
        /// <param name="cartItem">CartItem object</param>
        /// <returns>Added cart item</returns>
        Task<CartItem> AddCartItemAsync(CartItem cartItem);

        /// <summary>
        /// Update the CartItem
        /// </summary>
        /// <param name="cartItem">CartItem object</param>
        /// <returns>True, if successful</returns>
        Task<bool> UpdateCartItemAsync(CartItem cartItem);

        /// <summary>
        /// Determine that the product is in the cart.
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>True, if the product has been added to the cart</returns>
        Task<bool> IsInCartAsync(string productId);

        /// <summary>
        /// Determine how many items are in the basket.
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>Number of the items in the cart</returns>
        Task<int> GetQuantityInCartAsync(string productId);

        /// <summary>
        /// Get categories by name
        /// </summary>
        /// <param name="name">Keyword for category name</param>
        /// <returns>List of categories filtered by name</returns>
        Task<IEnumerable<Category>> GetCategoriesAsync(string name);

        /// <summary>
        /// Get the product by id
        /// </summary>
        /// <param name="id">product id</param>
        /// <returns>Product object or null</returns>
        Task<Product> GetProductAsync(string id);

        /// <summary>
        /// Get products by parameters
        /// </summary>
        /// <param name="productIds">Array of the product ids. Default is null.</param>
        /// <param name="key">Keyword for product name. Default is null.</param>
        /// <param name="onlyFavorite">Get only favorited items. Default is false.</param>
        /// <param name="onlyNew">Get only new items. Default is false.</param>
        /// <param name="onlyFeatured">Get only featured items. Default is false.</param>
        /// <param name="onlyPopular">Get only popular items. Default is false.</param>
        /// <returns>List of product filtered by parameters</returns>
        Task<IEnumerable<Product>> GetProductsAsync(string[] productIds = null, string key = null,
                                              bool onlyFavorite = false, bool onlyNew = false,
                                              bool onlyFeatured = false, bool onlyPopular = false);

        /// <summary>
        /// Get list of all banners
        /// </summary>
        /// <returns>List of banner objects</returns>
        Task<IEnumerable<Banner>> GetBannersAsync();

        /// <summary>
        /// Add the favorite
        /// </summary>
        /// <param name="favorite">Favorite object</param>
        /// <returns>Added favorite object</returns>
        Task<Favorite> AddFavoriteAsync(Favorite favorite);

        /// <summary>
        /// Delete the Favorite
        /// </summary>
        /// <param name="id">Favorite id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteFavoriteAsync(string id);

        /// <summary>
        /// Determine the product is favorite 
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <param name="productId">Product id</param>
        /// <returns>True, if product has been addes to favorites for customer</returns>
        Task<bool> IsFavoriteAsync(string customerId, string productId);

        /// <summary>
        /// Get the Favorite object by parameters
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <param name="productId">Favorite id</param>
        /// <returns>Favorite object or null</returns>
        Task<Favorite> GetFavoriteAsync(string customerId, string productId);

        /// <summary>
        /// Get list of variants by parameters
        /// </summary>
        /// <param name="name">Name of variant</param>
        /// <param name="productId">Product id</param>
        /// <returns>List of variant objects</returns>
        Task<IEnumerable<Variant>> GetVariantsAsync(string name, string productId);

        /// <summary>
        /// Determine if the product has variants
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>True, if product has no variants</returns>
        Task<bool> IsSimpleItemAsync(string productId);

    }
}
