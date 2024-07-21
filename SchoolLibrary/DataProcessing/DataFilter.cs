using SchoolLibrary.Models;
using System;
using System.Collections.Generic;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Class responsible for filtering data based on a specified field and keyword.
    /// </summary>
    public class DataFilter
    {
        /// <summary>
        /// Filters data based on a specified field and keyword.
        /// </summary>
        /// <param name="data">The list of School objects to be filtered.</param>
        /// <param name="field">The field by which the data should be filtered (e.g., "form_of_incorporation").</param>
        /// <param name="keyword">The keyword used for filtering.</param>
        /// <returns>A filtered list of School objects.</returns>
        public List<School> FilterData(List<School> data, string field, string keyword)
        {
            var result = new List<School>();

            foreach (var item in data)
            {
                // Retrieve the value of the specified field.
                string value = field.ToLower() switch
                {
                    "form_of_incorporation" => item.FormOfIncorporation,
                    "submission" => item.Submission,
                    _ => throw new ArgumentException($"Unknown field: {field}")
                };

                // Check if the value contains the specified keyword.
                if (value.Contains(keyword))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}