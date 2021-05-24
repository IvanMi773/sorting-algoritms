using Lab_1.sorting.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.sorting
{
    class StandartShellSort : BaseSort, ISortable
    {
        public void sortByNumber(List<Sportman> sportmans)
        {
            var d = sportmans.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < sportmans.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (sportmans[j - d].yearOfBorn > sportmans[j].yearOfBorn))
                    {
                        Sportman temp;
                        temp = sportmans[j];
                        sportmans[j] = sportmans[j - d];
                        sportmans[j - d] = temp;
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }

        public void sortByString(List<Sportman> sportmans)
        {
            var d = sportmans.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < sportmans.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && needToReOrder(sportmans[j - d].firstName, sportmans[j].firstName) > 0)
                    {
                        Sportman temp;
                        temp = sportmans[j];
                        sportmans[j] = sportmans[j - d];
                        sportmans[j - d] = temp;
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
    }
}
