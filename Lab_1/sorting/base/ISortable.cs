using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.sorting.Base
{
    interface ISortable
    {
        void sortByNumber(List<Sportman> sportmans);
        void sortByString(List<Sportman> sportmans);
    }
}
