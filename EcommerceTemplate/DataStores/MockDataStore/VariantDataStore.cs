using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class VariantDataStore : BaseDataStore<Variant>, IVariantDataStore
    {
        protected override IList<Variant> items { get; }

        public VariantDataStore()
        {
            items = new List<Variant>()
            {
                new Variant { Id = "v001", Name = "Size", Value = "S", ProductId = "p006", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v002", Name = "Size", Value = "M", ProductId = "p006", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v003", Name = "Size", Value = "L", ProductId = "p006", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v004", Name = "Size", Value = "XL", ProductId = "p006", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v005", Name = "Size", Value = "XXL", ProductId = "p006", IsAvailable = true, IsDefault = false },

                new Variant { Id = "v006", Name = "Size", Value = "S", ProductId = "p007", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v007", Name = "Size", Value = "M", ProductId = "p007", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v008", Name = "Size", Value = "L", ProductId = "p007", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v009", Name = "Size", Value = "XL", ProductId = "p007", IsAvailable = false, IsDefault = false },
                new Variant { Id = "v010", Name = "Size", Value = "XXL", ProductId = "p007", IsAvailable = false, IsDefault = false },

                new Variant { Id = "v006", Name = "Size", Value = "S", ProductId = "p008", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v007", Name = "Size", Value = "M", ProductId = "p008", IsAvailable = false, IsDefault = false },
                new Variant { Id = "v008", Name = "Size", Value = "L", ProductId = "p008", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v009", Name = "Size", Value = "XL", ProductId = "p008", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v010", Name = "Size", Value = "XXL", ProductId = "p008", IsAvailable = true, IsDefault = false },

                new Variant { Id = "v006", Name = "Size", Value = "S", ProductId = "p010", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v007", Name = "Size", Value = "M", ProductId = "p010", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v008", Name = "Size", Value = "L", ProductId = "p010", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v009", Name = "Size", Value = "XL", ProductId = "p010", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v010", Name = "Size", Value = "XXL", ProductId = "p010", IsAvailable = false, IsDefault = false },

                new Variant { Id = "v006", Name = "Size", Value = "S", ProductId = "p011", IsAvailable = false, IsDefault = false },
                new Variant { Id = "v007", Name = "Size", Value = "M", ProductId = "p011", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v008", Name = "Size", Value = "L", ProductId = "p011", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v009", Name = "Size", Value = "XL", ProductId = "p011", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v010", Name = "Size", Value = "XXL", ProductId = "p011", IsAvailable = true, IsDefault = false },

                new Variant { Id = "v006", Name = "Size", Value = "S", ProductId = "p012", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v007", Name = "Size", Value = "M", ProductId = "p012", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v008", Name = "Size", Value = "L", ProductId = "p012", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v009", Name = "Size", Value = "XL", ProductId = "p012", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v010", Name = "Size", Value = "XXL", ProductId = "p012", IsAvailable = true, IsDefault = false },

                new Variant { Id = "v006", Name = "Size", Value = "S", ProductId = "p013", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v007", Name = "Size", Value = "M", ProductId = "p013", IsAvailable = true, IsDefault = true },
                new Variant { Id = "v008", Name = "Size", Value = "L", ProductId = "p013", IsAvailable = false, IsDefault = false },
                new Variant { Id = "v009", Name = "Size", Value = "XL", ProductId = "p013", IsAvailable = true, IsDefault = false },
                new Variant { Id = "v010", Name = "Size", Value = "XXL", ProductId = "p013", IsAvailable = true, IsDefault = false },

            };
        }
    }
}
