using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class BinarySearch
    {
        private List<int> result = new List<int>();

        public List<int> Search (int[] array, int searchedValue, int first, int last)
        {
            result = new List<int>();
            return BSearch(array, searchedValue, first, last);
        }

        public List<int> BSearch(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return result;
            }

            var middle = (first + last) / 2;
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                result.Add(middle);
            }

            if (middleValue > searchedValue)
            {
                return BSearch(array, searchedValue, first, middle - 1);
            }
            else
            {
                return BSearch(array, searchedValue, middle + 1, last);
            }
        }
    }
}
