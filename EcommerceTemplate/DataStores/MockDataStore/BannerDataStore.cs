using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class BannerDataStore : BaseDataStore<Banner>, IBannerDataStore
    {
        protected override IList<Banner> items { get; }

        public BannerDataStore()
        {
            items = new List<Banner>
            {
                new Banner { Id = "ban004", Image = "banner1",
                            GoTo = "ProductsPage?ProductIds=p002,p003&Title=Christmas Sale" },

                new Banner { Id = "ban001", Image = "banner2",
                            GoTo = "ProductsPage?CategoryIdsc001&Title=Yet Another Sale Campaign" },

                new Banner { Id = "ban002", Image = "banner3",
                            GoTo = "ProductsPage?TagsTag1&Title=Black Friday Sale" },
            };
        }
        
    }
}
