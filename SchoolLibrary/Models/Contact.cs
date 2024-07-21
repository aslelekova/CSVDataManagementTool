namespace SchoolLibrary.Models
{
    /// <summary>
    /// Represents contact information including address, telephone, email, and website.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets or sets the telephone number.
        /// </summary>
        public string Telephone { get; private set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets or sets the website URL.
        /// </summary>
        public string Website { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class with specified contact details.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="telephone">The telephone number.</param>
        /// <param name="email">The email address.</param>
        /// <param name="website">The website URL.</param>
        public Contact(string address, string telephone, string email, string website)
        {
            Address = address;
            Telephone = telephone;
            Email = email;
            Website = website;
        }
    }
}