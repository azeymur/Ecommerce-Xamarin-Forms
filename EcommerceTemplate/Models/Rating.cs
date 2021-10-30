using System;

namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent rating entity
    /// </summary>
    public class Rating : Entity
    {
        /// <summary>
        /// Count of the stars
        /// </summary>
        public byte Star { get; set; }

        /// <summary>
        /// Customer's review
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The id of the associated product
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// The id of the associated customer
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// The name of the associated customer
        /// </summary>
        public string CustomerFullName { get; set; }

        /// <summary>
        /// The date of the rating was given.
        /// </summary>
        public DateTime DateGmt { get; set; }
    }
}
