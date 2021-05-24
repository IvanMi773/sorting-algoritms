using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.sorting.Base;

namespace Lab_1.sorting
{
    class SelectionSort: BaseSort, ISortable
    {
        public void sortByNumber(List<Sportman> sportmens)
        {
            int n = sportmens.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (sportmens[j].yearOfBorn < sportmens[min_idx].yearOfBorn)
                    {
                        min_idx = j;
                    }
                }

                Sportman temp = sportmens[min_idx];
                sportmens[min_idx] = sportmens[i];
                sportmens[i] = temp;
            }
        }

        public void sortByString(List<Sportman> sportmens)
        {
            int n = sportmens.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (needToReOrder(sportmens[j].firstName, sportmens[min_idx].firstName) <= 0)
                    {
                        min_idx = j;
                    }
                }

                Sportman temp = sportmens[min_idx];
                sportmens[min_idx] = sportmens[i];
                sportmens[i] = temp;
            }
        }
    }
}
