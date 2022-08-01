namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent banner entity
    /// </summary>
    public class Banner : Entity
    {
        /// <summary>
        /// Image of the banner
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Parameter to pass to the Shell's GoTo method when the banner is touched.
        /// </summary>
        public string GoTo { get; set; }
    }
}
