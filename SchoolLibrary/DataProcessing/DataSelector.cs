using SchoolLibrary.Enums;
using SchoolLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Class responsible for selecting records from a list based on a specified position.
    /// </summary>
    public class DataSelector
    {
        /// <summary>
        /// Retrieves a specified number of records from the data based on a specified position.
        /// </summary>
        /// <param name="data">The list of School objects.</param>
        /// <param name="N">The number of records to retrieve.</param>
        /// <param name="position">The position from which to start retrieving records (Top or Bottom).</param>
        /// <returns>A list of School objects based on the specified criteria.</returns>
        public List<School> GetRecords(List<School> data, int N, RecordPosition position)
        {
            var result = new List<School>();

            switch (position)
            {
                case RecordPosition.Top:
                    // Take the top N records.
                    result.AddRange(data.Take(N));
                    break;
                case RecordPosition.Bottom:
                    // Skip the first max(0, count - N) records to get the bottom N records.
                    result.AddRange(data.Skip(Math.Max(0, data.Count - N)));
                    break;
                default:
                    throw new ArgumentException($"Unknown position: {position}");
            }

            return result;
        }
    }
}