using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class CategoryDataStore : BaseDataStore<Category>, ICategoryDataStore
    {
        protected override IList<Category> items { get; }

        public CategoryDataStore()
        {
            items = new List<Category>()
            {
                new Category { Id = "c001", Name = "Accesories", Image = "cat_accessories" },
                new Category { Id = "c002", Name = "Hoodies", Image = "cat_hoodies" },
                new Category { Id = "c003", Name = "Sweaters", Image = "cat_sweaters" },
                new Category { Id = "c004", Name = "Pants", Image = "cat_pants" },
                new Category { Id = "c005", Name = "Others", Image = "cat_others" },
            };
        }
    }
}
