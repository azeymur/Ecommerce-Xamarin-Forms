using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class FavoriteDataStore : BaseDataStore<Favorite>, IFavoriteDataStore
    {
        protected override IList<Favorite> items { get; }

        public FavoriteDataStore()
        {
            items = new List<Favorite>
            {
                new Favorite { Id = "fav001", CustomerId = "cu001", ProductId = "p001" },

                new Favorite { Id = "fav002", CustomerId = "cu001", ProductId = "p007" },

                new Favorite { Id = "fav002", CustomerId = "cu001", ProductId = "p008" }
            };
        }
    }
}
