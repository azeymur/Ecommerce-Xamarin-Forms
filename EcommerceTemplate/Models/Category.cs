namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent category entity
    /// </summary>
    public class Category : Entity
    {
        /// <summary>
        /// Name for the category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Image for the category
        /// </summary>
        public string Image { get; set; }
    }
}
