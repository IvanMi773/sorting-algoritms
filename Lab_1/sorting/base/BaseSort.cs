using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.sorting.Base
{
    class BaseSort
    {
        public int needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i].CompareTo(s2.ToCharArray()[i]) < 0) return -1;
                if (s1.ToCharArray()[i].CompareTo(s2.ToCharArray()[i]) > 0) return 1;
            }
            return 0;
        }

        public void Swap(List<Sportman> arr, int x, int y)
        {
            Sportman temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
