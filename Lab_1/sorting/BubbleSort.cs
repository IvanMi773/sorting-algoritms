using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.sorting.Base;

namespace Lab_1.sorting
{
    class BubbleSort: BaseSort, ISortable
    {
        public void sortByNumber (List<Sportman> sportmans)
        {
            Sportman temp;

            for (int i = 0; i < sportmans.Count; i++)
            {
                for (int j = 0; j < sportmans.Count - 1; j++)
                {
                    if (sportmans[j].yearOfBorn > sportmans[j + 1].yearOfBorn)
                    {
                        temp = sportmans[j];
                        sportmans[j] = sportmans[j + 1];
                        sportmans[j + 1] = temp;
                    }
                }
            }
        }

        public void sortByString(List<Sportman> sportmans)
        {
            Sportman temp;

            for (int i = 0; i < sportmans.Count; i++)
            {
                for (int j = 0; j < sportmans.Count - 1; j++)
                {
                    if (needToReOrder(sportmans[j].firstName, sportmans[j + 1].firstName) > 0)
                    {
                        temp = sportmans[j];
                        sportmans[j] = sportmans[j + 1];
                        sportmans[j + 1] = temp;
                    }
                }
            }
        }
    }
}
