using Lab_1.sorting.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.sorting
{
    class QuickSort: BaseSort
    {
        public List<Sportman> sortByNumber(List<Sportman> array)
        {
            return quickSort(array, 0, array.Count - 1);
        }

        //швидке сортування
        List<Sportman> quickSort(List<Sportman> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            quickSort(array, minIndex, pivotIndex - 1);
            quickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        //метод повертає індекс опорного елементу
        int Partition(List<Sportman> array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i].yearOfBorn < array[maxIndex].yearOfBorn)
                {
                    pivot++;
                    Swap(array, pivot, i);
                }
            }

            pivot++;
            Swap(array, pivot, maxIndex);
            return pivot;
        }

        

        public List<Sportman> sortByString(List<Sportman> array)
        {
            return strQuickSort(array, 0, array.Count - 1);
        }

        int StrPartition(List<Sportman> array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (needToReOrder(array[i].firstName, array[maxIndex].firstName) < 0)
                {
                    pivot++;
                    Swap(array, pivot, i);
                }
            }

            pivot++;
            Swap(array, pivot, maxIndex);
            return pivot;
        }

        List<Sportman> strQuickSort(List<Sportman> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = StrPartition(array, minIndex, maxIndex);
            strQuickSort(array, minIndex, pivotIndex - 1);
            strQuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
    }
}
