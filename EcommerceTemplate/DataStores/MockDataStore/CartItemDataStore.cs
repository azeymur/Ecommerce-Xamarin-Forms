using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class CartItemDataStore : BaseDataStore<CartItem>, ICartItemDataStore
    {
        protected override IList<CartItem> items { get; }

        public CartItemDataStore()
        {
            items = new List<CartItem>
            {
                new CartItem { Id = "cl001", ProductId = "p001", UnitPrice = 18f, Quantity = 2 },

                new CartItem { Id = "cl002", ProductId = "p010", VariantId = "v008", UnitPrice = 42, Quantity = 1 }
            };
        }
    }
}
