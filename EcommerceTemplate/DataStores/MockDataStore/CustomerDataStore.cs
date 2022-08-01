using EcommerceTemplate.Models;
using System.Collections.Generic;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class CustomerDataStore : BaseDataStore<Customer>, ICustomerDataStore
    {
        protected override IList<Customer> items { get; }

        public CustomerDataStore()
        {
            items = new List<Customer>
            {
                new Customer { Id = "cu001", Username = "janedoe", FullName = "Jane Doe",
                        Email = "janedoe@gmail.com", Image = "jane_doe" },

                new Customer { Id = "cu002", Username = "johndoe", FullName = "John Doe",
                        Email = "johndoe@gmail.com", Image = "john_doe" },
            };
        }
    }
}
