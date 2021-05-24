using Lab_1.sorting.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.sorting
{
    class PiramidalSort: BaseSort
    {
        public List<Sportman> sortByNumber(List<Sportman> arr)
        {
            for (int i = arr.Count / 2 - 1; i >= 0; i--)
            {
                piramidalSort(arr, arr.Count, i);
            }

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                piramidalSort(arr, i, 0);
            }
            return arr;
        }

        private void piramidalSort(List<Sportman> arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l].yearOfBorn > arr[largest].yearOfBorn)
            {
                largest = l;
            }

            if (r < n && arr[r].yearOfBorn > arr[largest].yearOfBorn)
            {
                largest = r;
            }

            if (largest != i)
            {
                Swap(arr, i, largest);
                piramidalSort(arr, n, largest);
            }
        }



        public List<Sportman> sortByString(List<Sportman> arr)
        {
            for (int i = arr.Count / 2 - 1; i >= 0; i--)
            {
                piramidalSortStr(arr, arr.Count, i);
            }

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                piramidalSortStr(arr, i, 0);
            }
            return arr;
        }

        private void piramidalSortStr(List<Sportman> arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && needToReOrder(arr[l].firstName, arr[largest].firstName) > 0)
            {
                largest = l;
            }

            if (r < n && needToReOrder(arr[r].firstName, arr[largest].firstName) > 0)
            {
                largest = r;
            }

            if (largest != i)
            {
                Swap(arr, i, largest);
                piramidalSortStr(arr, n, largest);
            }
        }
    }
}
