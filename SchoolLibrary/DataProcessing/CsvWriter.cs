using System.Text;
using SchoolLibrary.Enums;
using SchoolLibrary.Models;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Class responsible for writing data to a CSV file.
    /// </summary>
    public class CsvWriter
    {
        /// <summary>
        /// Saves data to a CSV file.
        /// </summary>
        /// <param name="data">The list of School objects to be saved.</param>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <param name="mode">The save mode (Append or Overwrite).</param>
        public void SaveDataToCsv(List<School> data, string filePath, SaveMode mode)
        {
            // Determine whether to write headers based on the save mode and existing file length.
            bool writeHeaders = mode != SaveMode.Append || new FileInfo(filePath).Length == 0;

            // Open the StreamWriter using the specified file path, append mode, and UTF-8 encoding.
            using (var writer = new StreamWriter(filePath, mode == SaveMode.Append, Encoding.UTF8))
            {
                // Write headers if required.
                if (writeHeaders)
                {
                    // Header line format.
                    writer.WriteLine("ROWNUM;name;address;okrug;rayon;form_of_incorporation;submission;tip_uchrezhdeniya;vid_uchrezhdeniya;telephone;web_site;e_mail;X;Y;global_id");
                }

                // Iterate through each School object and write its data as a CSV line.
                foreach (var model in data)
                {
                    var line = string.Join(";", new string[] {
                        model.ROWNUM.ToString(),
                        model.Name,
                        model.Contact.Address,
                        model.Okrug,
                        model.Rayon,
                        model.FormOfIncorporation,
                        model.Submission,
                        model.TipUchrezhdeniya,
                        model.VidUchrezhdeniya,
                        model.Contact.Telephone,
                        model.Contact.Website,
                        model.Contact.Email,
                        model.X,
                        model.Y,
                        model.GlobalId.ToString()
                    });

                    // Write the CSV line to the file.
                    writer.WriteLine(line);
                }
            }
        }
    }
}
