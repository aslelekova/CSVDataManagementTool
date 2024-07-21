using System.Text;
using SchoolLibrary.Models;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Class responsible for reading data from a CSV file.
    /// </summary>
    public class CsvReader
    {
        /// <summary>
        /// Loads data from a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>A list of School objects loaded from the CSV file.</returns>
        public List<School> LoadDataFromCsv(string filePath)
        {
            var data = new List<School>();

            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string line;
                // Skip the header line.
                reader.ReadLine(); 

                // Read lines from the file.
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace("; (", ", (");
                    
                    // Split the line into values.
                    var values = line.Split(';');
                    int.TryParse(values[0], out var rownum);
                    int.TryParse(values[14], out var globalId);

                    // Create a Contact object for contact information.
                    var contact = new Contact(values[2], values[9], values[11], values[10]);

                    // Create a School object with the retrieved data.
                    var school = new School(rownum, values[1], contact, values[3], values[4], values[5], values[6], values[7], values[8], values[12], values[13], globalId);

                    // Add the school to the data list.
                    data.Add(school);
                }
            }

            return data;
        }
    }
}
