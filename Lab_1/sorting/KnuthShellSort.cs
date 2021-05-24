using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.sorting.Base;

namespace Lab_1.sorting
{
    class KnuthShellSort: BaseSort, ISortable
    {
        public void sortByNumber (List<Sportman> sportmens)
        {
            int n = sportmens.Count;

            int h = 1;
            while (h < n / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    for (int j = i; j >= h && sportmens[j].yearOfBorn < sportmens[j - h].yearOfBorn; j -= h)
                    {
                        Sportman temp;
                        temp = sportmens[j];
                        sportmens[j] = sportmens[j - h];
                        sportmens[j - h] = temp;
                    }
                }
                h /= 3;
            }
        }

        public void sortByString(List<Sportman> sportmens)
        {
            int n = sportmens.Count;

            int h = 1;
            while (h < n / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    for (int j = i; j >= h && needToReOrder(sportmens[j].firstName, sportmens[j - h].firstName) < 0; j -= h)
                    {
                        Sportman temp;
                        temp = sportmens[j];
                        sportmens[j] = sportmens[j - h];
                        sportmens[j - h] = temp;
                    }
                }
                h /= 3;
            }
        }
    }
}
