using SchoolLibrary.Models;
using System;

namespace SchoolLibrary.DataProcessing
{
    /// <summary>
    /// Class responsible for sorting data based on a specified field and sort order.
    /// </summary>
    public class DataSorter
    {
        /// <summary>
        /// Sorts data based on a specified field and sort order.
        /// </summary>
        /// <param name="data">The list of School objects to be sorted.</param>
        /// <param name="field">The field by which the data should be sorted.</param>
        /// <param name="ascending">A flag indicating whether to sort in ascending order.</param>
        /// <returns>A sorted list of School objects.</returns>
        public List<School> SortData(List<School> data, string field, bool ascending)
        {
            // Determine the key selector function based on the specified field.
            Func<School, IComparable> keySelector = field.ToLower() switch
            {
                "okrug" => s => s.Okrug,
                _ => throw new ArgumentException($"Unknown field: {field}")
            };

            // Perform quicksort on the data.
            QuickSort(data, 0, data.Count - 1, keySelector, ascending);

            return data;
        }

        /// <summary>
        /// Recursive method for quicksort.
        /// </summary>
        private void QuickSort(List<School> data, int low, int high, Func<School, IComparable> keySelector, bool ascending)
        {
            if (low < high)
            {
                int pi = Partition(data, low, high, keySelector, ascending);
                QuickSort(data, low, pi - 1, keySelector, ascending);
                QuickSort(data, pi + 1, high, keySelector, ascending);
            }
        }

        /// <summary>
        /// Partitioning method for quicksort.
        /// </summary>
        private int Partition(List<School> data, int low, int high, Func<School, IComparable> keySelector, bool ascending)
        {
            var pivot = keySelector(data[high]);
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                // Compare elements and swap if necessary based on the sort order.
                if ((ascending ? 1 : -1) * keySelector(data[j]).CompareTo(pivot) < 0)
                {
                    i++;
                    Swap(data, i, j);
                }
            }
            Swap(data, i + 1, high);
            return i + 1;
        }

        /// <summary>
        /// Method for swapping elements in the list.
        /// </summary>
        private void Swap(List<School> data, int i, int j)
        {
            (data[i], data[j]) = (data[j], data[i]);
        }
    }
}
