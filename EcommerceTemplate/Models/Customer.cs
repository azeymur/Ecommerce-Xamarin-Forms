namespace EcommerceTemplate.Models
{
    /// <summary>
    /// Type represent customer entity
    /// </summary>
    public class Customer : Entity
    {
        /// <summary>
        /// First and last name for the customer
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// User name for the customer
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The email address for the customer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number for the customer
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Image for the customer
        /// </summary>
        public string Image { get; set; }

    }
}
