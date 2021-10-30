namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent favorite entity
    /// </summary>
    public class Favorite : Entity
    {
        /// <summary>
        /// The id of the associated customer
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// The id of the associated product
        /// </summary>
        public string ProductId { get; set; }
    }
}
