using SchoolLibrary.Enums;
using System.Collections.Generic;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Interface for data processing operations.
    /// </summary>
    /// <typeparam name="T">Type of data to be processed.</typeparam>
    public interface IProcessor<T>
    {
        /// <summary>
        /// Loads data from a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>A list of objects of type T loaded from the CSV file.</returns>
        List<T> LoadDataFromCsv(string filePath);

        /// <summary>
        /// Sorts data based on a specified field and sort order.
        /// </summary>
        /// <param name="data">The list of objects to be sorted.</param>
        /// <param name="field">The field by which the data should be sorted.</param>
        /// <param name="ascending">A flag indicating whether to sort in ascending order.</param>
        /// <returns>A sorted list of objects of type T.</returns>
        List<T> SortData(List<T> data, string field, bool ascending);

        /// <summary>
        /// Saves data to a CSV file.
        /// </summary>
        /// <param name="data">The list of objects to be saved.</param>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <param name="mode">The save mode (Append or Overwrite).</param>
        void SaveDataToCsv(List<T> data, string filePath, SaveMode mode);
    }
}