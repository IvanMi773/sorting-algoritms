using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.sorting.Base;

namespace Lab_1.sorting
{
    class ShakerSort: BaseSort, ISortable
    {
        public void sortByNumber(List<Sportman> sportmans)
        {
            int size = sportmans.Count;
            bool swapped = false;

            for (int k = size - 1; k > 0; k--)
            {
                swapped = false;
                for (int i = k; i > size - 1 - k; i--)
                {
                    if (sportmans[i].yearOfBorn < sportmans[i - 1].yearOfBorn)
                    {
                        Sportman temp = sportmans[i];
                        sportmans[i] = sportmans[i - 1];
                        sportmans[i - 1] = temp;
                        swapped = true;
                    }
                }

                for (int i = size - k; i < k; i++)
                {
                    if (sportmans[i].yearOfBorn > sportmans[i + 1].yearOfBorn)
                    {
                        Sportman temp = sportmans[i];
                        sportmans[i] = sportmans[i + 1];
                        sportmans[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        public void sortByString(List<Sportman> sportmans)
        {
            int size = sportmans.Count;
            bool swapped = false;

            for (int k = size - 1; k > 0; k--)
            {
                swapped = false;
                for (int i = k; i > size - 1 - k; i--)
                {
                    if (needToReOrder(sportmans[i].firstName, sportmans[i - 1].firstName) <= 0)
                    {
                        Sportman temp = sportmans[i];
                        sportmans[i] = sportmans[i - 1];
                        sportmans[i - 1] = temp;
                        swapped = true;
                    }
                }

                for (int i = size - k; i < k; i++)
                {
                    if (needToReOrder(sportmans[i].firstName, sportmans[i + 1].firstName) > 0)
                    {
                        Sportman temp = sportmans[i];
                        sportmans[i] = sportmans[i + 1];
                        sportmans[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
