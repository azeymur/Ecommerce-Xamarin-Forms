using System;
using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class RatingDataStore : BaseDataStore<Rating>, IRatingDataStore
    {
        protected override IList<Rating> items { get; }

        public RatingDataStore()
        {

            items = new List<Rating>()
            {
                new Rating { Id = "ra001", Star = 3, ProductId = "p001", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 1, 1), Text = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas." },

                new Rating { Id = "ra002", Star = 5, ProductId = "p002", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 1, 6), Text = "Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Nam a efficitur neque." },

                new Rating { Id = "ra003", Star = 5, ProductId = "p003", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 2, 4), Text = "Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo. " },

                new Rating { Id = "ra004", Star = 5, ProductId = "p004", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 2, 14), Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." },

                new Rating { Id = "ra005", Star = 4, ProductId = "p005", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 3, 3), Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },

                new Rating { Id = "ra006", Star = 4, ProductId = "p006", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 3, 9), Text = "Donec vitae purus porttitor, viverra turpis ac, viverra lectus. Cras dapibus volutpat quam, sed pellentesque nisl ultrices eget. Vivamus malesuada iaculis mauris nec finibus. Pellentesque arcu mauris, interdum quis luctus nec, viverra quis eros." },

                new Rating { Id = "ra007", Star = 5, ProductId = "p007", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 3, 22), Text = "Sed maximus cursus ultricies." },

                new Rating { Id = "ra008", Star = 3, ProductId = "p008", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 4, 8), Text = "Nam eget accumsan libero." },

                new Rating { Id = "ra009", Star = 3, ProductId = "p009", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 4, 11), Text = "Phasellus tellus velit, sollicitudin quis ultrices eget, pellentesque eget ipsum." },

                new Rating { Id = "ra010", Star = 5, ProductId = "p010", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 5, 8), Text = "Donec ac turpis facilisis, consequat mi varius, sodales diam. Curabitur ac metus consequat, hendrerit turpis in, facilisis purus. Cras tincidunt, ex id venenatis sollicitudin, est quam egestas neque, quis ullamcorper tellus erat vel urna." },

                new Rating { Id = "ra011", Star = 2, ProductId = "p011", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 6, 17), Text = "Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere." },

                new Rating { Id = "ra012", Star = 1, ProductId = "p012", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 7, 9), Text = "Fusce molestie felis vel bibendum volutpat. Maecenas ac dapibus neque. Maecenas at erat a odio imperdiet euismod." },

                new Rating { Id = "ra013", Star = 3, ProductId = "p013", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 8, 18), Text = "Aenean euismod dui vel pretium consequat." },

                new Rating { Id = "ra014", Star = 4, ProductId = "p001", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 9, 21), Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum commodo aliquam nibh et condimentum." },

                new Rating { Id = "ra015", Star = 3, ProductId = "p002", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 9, 29), Text = "Nullam maximus quis eros sed ultricies." },

                new Rating { Id = "ra016", Star = 5, ProductId = "p003", CustomerId = "cu002",
                        DateGmt = new DateTime(2020, 10, 7), Text = "Fusce a metus semper, suscipit erat in, aliquet mauris." },

                new Rating { Id = "ra017", Star = 3, ProductId = "p004", CustomerId = "cu001",
                        DateGmt = new DateTime(2020, 12, 9), Text = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas." },

                new Rating { Id = "ra018", Star = 5, ProductId = "p005", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 1, 2), Text = "Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Nam a efficitur neque." },

                new Rating { Id = "ra019", Star = 4, ProductId = "p006", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 2, 6), Text = "Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo. " },

                new Rating { Id = "ra020", Star = 5, ProductId = "p007", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 2, 18), Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." },

                new Rating { Id = "ra021", Star = 4, ProductId = "p008", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 3, 4), Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },

                new Rating { Id = "ra022", Star = 4, ProductId = "p009", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 3, 2), Text = "Donec vitae purus porttitor, viverra turpis ac, viverra lectus. Cras dapibus volutpat quam, sed pellentesque nisl ultrices eget. Vivamus malesuada iaculis mauris nec finibus. Pellentesque arcu mauris, interdum quis luctus nec, viverra quis eros." },

                new Rating { Id = "ra023", Star = 5, ProductId = "p010", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 3, 20), Text = "Sed maximus cursus ultricies." },

                new Rating { Id = "ra024", Star = 3, ProductId = "p011", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 4, 9), Text = "Nam eget accumsan libero." },

                new Rating { Id = "ra025", Star = 3, ProductId = "p012", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 4, 13), Text = "Phasellus tellus velit, sollicitudin quis ultrices eget, pellentesque eget ipsum." },

                new Rating { Id = "ra026", Star = 5, ProductId = "p013", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 5, 11), Text = "Donec ac turpis facilisis, consequat mi varius, sodales diam. Curabitur ac metus consequat, hendrerit turpis in, facilisis purus. Cras tincidunt, ex id venenatis sollicitudin, est quam egestas neque, quis ullamcorper tellus erat vel urna." },

                new Rating { Id = "ra027", Star = 2, ProductId = "p001", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 6, 4), Text = "Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere." },

                new Rating { Id = "ra028", Star = 1, ProductId = "p005", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 7, 30), Text = "Fusce molestie felis vel bibendum volutpat. Maecenas ac dapibus neque. Maecenas at erat a odio imperdiet euismod." },

                new Rating { Id = "ra029", Star = 3, ProductId = "p009", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 8, 28), Text = "Aenean euismod dui vel pretium consequat." },

                new Rating { Id = "ra030", Star = 4, ProductId = "p006", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 9, 6), Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum commodo aliquam nibh et condimentum." },

                new Rating { Id = "ra031", Star = 3, ProductId = "p010", CustomerId = "cu001",
                        DateGmt = new DateTime(2021, 9, 19), Text = "Nullam maximus quis eros sed ultricies." },

                new Rating { Id = "ra032", Star = 5, ProductId = "p012", CustomerId = "cu002",
                        DateGmt = new DateTime(2021, 10, 7), Text = "Fusce a metus semper, suscipit erat in, aliquet mauris." }
            };
        }
    }
}
