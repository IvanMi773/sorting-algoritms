using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.sorting.Base;

namespace Lab_1.sorting
{
    class SedgwickShellSort: BaseSort, ISortable
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
                        Swap(sportmans[j], sportmans[j - d]);
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
                        Swap(sportmans[j], sportmans[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }

        private static void Swap(Sportman a, Sportman b)
        {
            var t = a;
            a = b;
            b = t;
        }
    }
}
