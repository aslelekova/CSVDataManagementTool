namespace SchoolLibrary.Models
{
    /// <summary>
    /// Represents information about a school.
    /// </summary>
    public class School
    {
        /// <summary>
        /// Gets or sets the number of the record.
        /// </summary>
        public int ROWNUM { get; private set; }

        /// <summary>
        /// Gets or sets the name of the school.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the contact information for the school.
        /// </summary>
        public Contact Contact { get; private set; }

        /// <summary>
        /// Gets or sets the district of the school.
        /// </summary>
        public string Okrug { get; private set; }

        /// <summary>
        /// Gets or sets the district of the school.
        /// </summary>
        public string Rayon { get; private set; }

        /// <summary>
        /// Gets or sets the form of incorporation of the school.
        /// </summary>
        public string FormOfIncorporation { get; private set; }

        /// <summary>
        /// Gets or sets the type of representation of the school.
        /// </summary>
        public string Submission { get; private set; }

        /// <summary>
        /// Gets or sets the type of the institution.
        /// </summary>
        public string TipUchrezhdeniya { get; private set; }

        /// <summary>
        /// Gets or sets the type of the institution.
        /// </summary>
        public string VidUchrezhdeniya { get; private set; }

        /// <summary>
        /// Gets or sets the X coordinate.
        /// </summary>
        public string X { get; private set; }

        /// <summary>
        /// Gets or sets the Y coordinate.
        /// </summary>
        public string Y { get; private set; }

        /// <summary>
        /// Gets or sets the global identifier.
        /// </summary>
        public int GlobalId { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="School"/> class with specified school details.
        /// </summary>
        /// <param name="rownum">The number of the record.</param>
        /// <param name="name">The name of the school.</param>
        /// <param name="contact">The contact information for the school.</param>
        /// <param name="okrug">The district of the school.</param>
        /// <param name="rayon">The district of the school.</param>
        /// <param name="formOfIncorporation">The form of incorporation of the school.</param>
        /// <param name="submission">The type of representation of the school.</param>
        /// <param name="tipUchrezhdeniya">The type of the institution.</param>
        /// <param name="vidUchrezhdeniya">The type of the institution.</param>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="globalId">The global identifier.</param>
        public School(int rownum, string name, Contact contact, string okrug, string rayon, string formOfIncorporation, string submission, string tipUchrezhdeniya, string vidUchrezhdeniya, string x, string y, int globalId)
        {
            ROWNUM = rownum;
            Name = name;
            Contact = contact;
            Okrug = okrug;
            Rayon = rayon;
            FormOfIncorporation = formOfIncorporation;
            Submission = submission;
            TipUchrezhdeniya = tipUchrezhdeniya;
            VidUchrezhdeniya = vidUchrezhdeniya;
            X = x;
            Y = y;
            GlobalId = globalId;
        }

        /// <summary>
        /// Returns a string representation of the school.
        /// </summary>
        /// <returns>A string containing the school's information.</returns>
        public override string ToString()
        {
            return $"ROWNUM: {ROWNUM}\n" +
                   $"Name: {Name}\n" +
                   $"Address: {Contact.Address}\n" +
                   $"Telephone: {Contact.Telephone}\n" +
                   $"Email: {Contact.Email}\n" +
                   $"Website: {Contact.Website}\n" +
                   $"Okrug: {Okrug}\n" +
                   $"Rayon: {Rayon}\n" +
                   $"Form of Incorporation: {FormOfIncorporation}\n" +
                   $"Submission: {Submission}\n" +
                   $"Tip Uchrezhdeniya: {TipUchrezhdeniya}\n" +
                   $"Vid Uchrezhdeniya: {VidUchrezhdeniya}\n" +
                   $"X: {X}\n" +
                   $"Y: {Y}\n" +
                   $"Global ID: {GlobalId}\n\n\n";
        }
    }
}
