using SchoolLibrary.Enums;
using SchoolLibrary.Models;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Class responsible for processing and managing data using various operations.
    /// Implements the IProcessor interface for School objects.
    /// </summary>
    public class DataProcessor : IProcessor<School>
    {
        private readonly CsvReader _reader = new CsvReader();
        private readonly CsvWriter _writer = new CsvWriter();
        private readonly DataFilter _filter = new DataFilter();
        private readonly DataSorter _sorter = new DataSorter();
        private readonly DataSelector _selector = new DataSelector();

        /// <summary>
        /// Loads data from a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>A list of School objects loaded from the CSV file.</returns>
        public List<School> LoadDataFromCsv(string filePath) => _reader.LoadDataFromCsv(filePath);

        /// <summary>
        /// Saves data to a CSV file.
        /// </summary>
        /// <param name="data">The list of School objects to be saved.</param>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <param name="mode">The save mode (Append or Overwrite).</param>
        public void SaveDataToCsv(List<School> data, string filePath, SaveMode mode) => _writer.SaveDataToCsv(data, filePath, mode);

        /// <summary>
        /// Filters data based on a specified field and keyword.
        /// </summary>
        /// <param name="data">The list of School objects to be filtered.</param>
        /// <param name="field">The field by which the data should be filtered.</param>
        /// <param name="keyword">The keyword used for filtering.</param>
        /// <returns>A filtered list of School objects.</returns>
        public List<School> FilterData(List<School> data, string field, string keyword) => _filter.FilterData(data, field, keyword);

        /// <summary>
        /// Sorts data based on a specified field and sort order.
        /// </summary>
        /// <param name="data">The list of School objects to be sorted.</param>
        /// <param name="field">The field by which the data should be sorted.</param>
        /// <param name="ascending">A flag indicating whether to sort in ascending order.</param>
        /// <returns>A sorted list of School objects.</returns>
        public List<School> SortData(List<School> data, string field, bool ascending) => _sorter.SortData(data, field, ascending);

        /// <summary>
        /// Retrieves a specified number of records from the data based on a specified position.
        /// </summary>
        /// <param name="data">The list of School objects.</param>
        /// <param name="N">The number of records to retrieve.</param>
        /// <param name="position">The position from which to start retrieving records.</param>
        /// <returns>A list of School objects based on the specified criteria.</returns>
        public List<School> GetRecords(List<School> data, int N, RecordPosition position) => _selector.GetRecords(data, N, position);
    }
}
