namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent variant entity
    /// </summary>
    public class Variant : Entity
    {
        /// <summary>
        /// Name for the variant 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value for the variant
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Id of the associated product
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// True if the variant is available
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// True if the variant is default
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Shortcut to display the variant
        /// </summary>
        /// <returns>String ready to be displayed</returns>
        public override string ToString()
        {
            return $"{Name} : {Value}";
        }
    }
}
