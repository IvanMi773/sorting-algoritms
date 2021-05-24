using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.sorting.Base;

namespace Lab_1.sorting
{
    class InsertSort : BaseSort, ISortable
    {
        public void sortByNumberShilded(List<Sportman> sportmens)
        {
            for (int i = 2; i < sportmens.Count; i++)
            {
                if (sportmens[i - 1].yearOfBorn > sportmens[i].yearOfBorn)
                {
                    sportmens[0] = sportmens[i];
                    int j = i - 1;

                    while (sportmens[i - 1].yearOfBorn > sportmens[i].yearOfBorn)
                    {
                        sportmens[j + 1] = sportmens[j];
                        j--;
                    }

                    sportmens[j + 1] = sportmens[0];
                }
            }
        }

        public void sortByStringShilded(List<Sportman> sportmens)
        {
            for (int i = 2; i < sportmens.Count; i++)
            {
                if (needToReOrder(sportmens[i - 1].firstName, sportmens[i].firstName) > 0)
                {
                    sportmens[0] = sportmens[i];
                    int j = i - 1;

                    while (needToReOrder(sportmens[j].firstName, sportmens[0].firstName) > 0)
                    {
                        sportmens[j + 1] = sportmens[j];
                        j--;
                    }

                    sportmens[j + 1] = sportmens[0];
                }
            }
        }

        public void sortByNumber(List<Sportman> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; ++i)
            {
                Sportman key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].yearOfBorn > key.yearOfBorn)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public void sortByString(List<Sportman> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; ++i)
            {
                Sportman key = arr[i];
                int j = i - 1;

                while (j >= 0 && needToReOrder(arr[j].firstName, key.firstName) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
