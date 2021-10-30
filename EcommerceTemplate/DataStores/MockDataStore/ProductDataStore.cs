using System.Collections.Generic;
using EcommerceTemplate.Models;

namespace EcommerceTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class ProductDataStore : BaseDataStore<Product>, IProductDataStore
    {
        protected override IList<Product> items { get; }

        public ProductDataStore()
        {
            items = new List<Product>()
            {
                // Accessories

                new Product { Id = "p001", Name = "Beanie",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 18f, RegularPrice = 20f,
                            CategoryIds = new string[] { "c001" },
                            Tags = new string[] { "Hood", "Cotton", "Woman" },
                            Color = "Black",
                            Material = "Cotton",
                            Images = new string[] { "beanie1", "beanie2" },
                            IsFeatured = true, IsNew = false, IsPopular = false,
                            RelatedIds = new string[] { "p003", "p002", "p004", "p005" } },
                
                new Product { Id = "p002", Name = "Belt",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 55f, RegularPrice = 65f,
                            CategoryIds = new string[] { "c001" },
                            Tags = new string[] { "Leather", "Man" },
                            Color = "Brown",
                            Material = "Leather",
                            Images = new string[] { "belt1" },
                            IsFeatured = false, IsNew = false, IsPopular = false,
                            RelatedIds = new string[] { "p001", "p003", "p004" } },
                
                new Product { Id = "p003", Name = "Cap",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 16f, RegularPrice = 16f,
                            CategoryIds = new string[] { "c001"},
                            Tags = new string[] { "Hood", "Polyester" },
                            Color = "Blue",
                            Material = "Polyester",
                            Images = new string[] { "cap1" },
                            IsFeatured = false, IsNew = false, IsPopular = false,
                            RelatedIds = new string[] { "p001", "p002", "p004", "p005" } },

                new Product { Id = "p004", Name = "Sunglasses",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 35f, RegularPrice = 35f,
                            CategoryIds = new string[] { "c001"},
                            Tags = new string[] { "Titanium" },
                            Color = "Green",
                            Material = "Titanium",
                            Images = new string[] { "sunglasses1", "sunglasses2" },
                            IsFeatured = false, IsNew = false, IsPopular = false,
                            RelatedIds = new string[] { "p005", "p003", "p002", "p001" } },

                new Product { Id = "p005", Name = "Sunglasses Orange",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 30f, RegularPrice = 40f,
                            CategoryIds = new string[] { "c001"},
                            Tags = new string[] { "Metal" },
                            Color = "Orange",
                            Material = "Metal",
                            Images = new string[] { "sunglasses_orange1", "sunglasses_orange2" },
                            IsFeatured = false, IsNew = true, IsPopular = false,
                            RelatedIds = new string[] { "p004", "p003", "p001", "p002" } },

                // Sweaters

                new Product { Id = "p006", Name = "Corduroy Sweater",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 32f, RegularPrice = 32f,
                            CategoryIds = new string [] { "c003" },
                            Tags = new string[] { "Corduroy", "Woman" },
                            Color = "Dark Gray",
                            Material = "Corduroy",
                            Images = new string[] { "corduroy_sweater1" },
                            IsFeatured = false, IsNew = false, IsPopular = false,
                            RelatedIds = new string[] { "p007", "p008", "p009" } },

                new Product { Id = "p007", Name = "Long Sleeve Sweater",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 25f, RegularPrice = 25f,
                            CategoryIds = new string [] { "c003" },
                            Tags = new string[] { "Wool", "Woman" },
                            Color = "Smoke White",
                            Material = "Wool",
                            Images = new string[] { "long_sleeve_sweater1", "long_sleeve_sweater2", "long_sleeve_sweater3" },
                            IsFeatured = false, IsNew = false, IsPopular = true,
                            RelatedIds = new string[] { "p007", "p008", "p009" } },

                new Product { Id = "p008", Name = "V-neck Knit Shirt",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 20f, RegularPrice = 20f,
                            CategoryIds = new string [] { "c003" },
                            Tags = new string[] { "Wool", "V-neck", "Woman" },
                            Color = "Brown",
                            Material = "Wool",
                            Images = new string[] { "vneck_knit_shirt1" },
                            IsFeatured = true, IsNew = true, IsPopular = false,
                            RelatedIds = new string[] { "p009", "p007", "p006" } },

                // Others

                new Product { Id = "p009", Name = "Woollen Pancho",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 40f, RegularPrice = 50f,
                            CategoryIds = new string [] { "c005" },
                            Tags = new string[] { "Wool", "Pancho", "Woman" },
                            Color = "Black&White",
                            Material = "Wool",
                            Images = new string[] { "woollen_pancho1", "woollen_pancho2", "woollen_pancho3" },
                            IsFeatured = false, IsNew = false, IsPopular = true,
                            RelatedIds = new string[] { "p008", "p007", "p006" } },

                // Hoodies

                new Product { Id = "p010", Name = "Hoodie",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 42f, RegularPrice = 45f,
                            CategoryIds = new string[] { "c002" },
                            Tags = new string[] { "Cotton", "Man" },
                            Color = "Orange",
                            Material = "Cotton",
                            Images = new string[] { "hoodie1" },
                            IsFeatured = true, IsNew = true, IsPopular = false,
                            RelatedIds = new string[] { "p011", "p012", "p013" } },
                
                
                new Product { Id = "p011", Name = "Hoodie with Pocket",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 35f, RegularPrice = 45f,
                            CategoryIds = new string [] { "c002" },
                            Tags = new string[] { "Linen", "Woman" },
                            Color = "Lime",
                            Material = "Linen",
                            Images = new string[] { "hoodie_pocket1", "hoodie_pocket2", "hoodie_pocket3" },
                            IsFeatured = true, IsNew = true, IsPopular = false,
                            RelatedIds = new string[] { "p013", "p012", "p010" } },

                new Product { Id = "p012", Name = "Hoodie with Zipper",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 45f, RegularPrice = 45f,
                            CategoryIds = new string [] { "c002" },
                            Tags = new string[] { "Cotton", "Woman" },
                            Color = "Black",
                            Material = "Cotton",
                            Images = new string[] { "hoodie_zipper1" },
                            IsFeatured = false, IsNew = false, IsPopular = true,
                            RelatedIds = new string[] { "p013", "p010", "p011" } },

                new Product { Id = "p013", Name = "Hoodie with Logo",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.\n\nVestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.\n\nAliquam porttitor magna eget mauris lobortis gravida. Integer volutpat ligula sed semper vulputate. Donec tincidunt lobortis leo, at lacinia lectus semper non. In laoreet fringilla felis in posuere. Maecenas a turpis tincidunt, aliquet justo vel, tristique diam. Duis sit amet tristique tellus. Maecenas vel lectus justo. Curabitur tellus augue, ultrices nec dignissim maximus, bibendum accumsan lacus.\n\nInteger elementum pulvinar semper. Fusce a metus semper, suscipit erat in, aliquet mauris.",
                            Price = 45f, RegularPrice = 45f,
                            CategoryIds = new string[] { "c002" },
                            Tags = new string[] { "Wool", "Man" },
                            Color = "White",
                            Material = "Wool",
                            Images = new string[] { "hoodie_logo1" },
                            IsFeatured = false, IsNew = false, IsPopular = true,
                            RelatedIds = new string[] { "p012", "p011", "p010" } },

            };
        }
    }
}