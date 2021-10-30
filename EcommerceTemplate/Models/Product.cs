using System;

namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent product entity
    /// </summary>
    public class Product : Entity
    {
        /// <summary>
        /// Name for the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description for the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Current price of the product
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Regular price of the product
        /// </summary>
        public float RegularPrice { get; set; }

        /// <summary>
        /// Average rating of the product
        /// </summary>
        public float AverageRating { get; set; }

        /// <summary>
        /// Number of the ratings
        /// </summary>
        public int RatingCount { get; set; }

        /// <summary>
        /// True if it is foverite item for the logged customer 
        /// </summary>
        public bool IsFavorite { get; set; }

        /// <summary>
        ///True, if prouct is featured
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// True, if product is new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// True, if product is popular
        /// </summary>
        public bool IsPopular { get; set; }

        /// <summary>
        /// True, if product has no variants
        /// </summary>
        public bool IsSimple { get; set; }

        /// <summary>
        /// Number of items in shopping cart
        /// </summary>
        public int QtyInCart { get; set; }

        /// <summary>
        /// List of ids of associated categories
        /// </summary>
        public string[] CategoryIds { get; set; }

        /// <summary>
        /// List of associated tags
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// List of associated images
        /// </summary>
        public string[] Images { get; set; }

        /// <summary>
        /// List of ids of related products
        /// </summary>
        public string[] RelatedIds { get; set; }

        /// <summary>
        /// Color for the product
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Material for the product
        /// </summary>
        public string Material { get; set; }

        public string FirstImage {
            get
            {
                return Images[0];
            }
        }

        /// <summary>
        /// Calculated field: True, if it's on sale
        /// </summary>
        public bool OnSale
        {
            get => Price != RegularPrice;
        }

        /// <summary>
        /// Calculated field: True, if the product has variants
        /// </summary>
        public bool IsComplex
        {
            get => !IsSimple;
        }

        /// <summary>
        /// Calculated field: True, if the product has added to cart
        /// </summary>
        public bool HasAddedCart
        {
            get { return QtyInCart > 0 ? true : false; }
        }

        /// <summary>
        /// Calculated field: Discount rate as e percentage
        /// </summary>
        public int DiscountRate
        {
            get
            {
                if (Price == RegularPrice) return 0;

                return (int)Math.Round((RegularPrice - Price) * 100.0 / RegularPrice);
            }
        }
    }
}