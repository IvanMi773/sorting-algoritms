using Lab_1.sorting.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class RadixSort : BaseSort, ISortable
    {
        public void sortByNumber(List<Sportman> sportmans)
        {
            var array = new int[sportmans.Count];
            for (int i = 0; i < sportmans.Count; i++)
            {
                array[i] = sportmans[i].yearOfBorn;
            }

            array = SortL(array);
            for (int i = 0; i < sportmans.Count; i++)
            {
                sportmans[i].yearOfBorn = Convert.ToInt32(array[i]);
            }

            //int i, j;
            //var tmp = new List<Sportman>(sportmans.Count);
            //for (int shift = sizeof(int) * 8 - 1; shift > -1; --shift)
            //{
            //    j = 0;
            //    for (i = 0; i < sportmans.Count; ++i)
            //    {
            //        var move = (sportmans[i].yearOfBorn << shift) >= 0;
            //        if (shift == 0 ? !move : move)
            //            sportmans[i - j].yearOfBorn = sportmans[i].yearOfBorn;
            //        else
            //            tmp[j++] = sportmans[i];
            //    }
            //    //var t = sportmans.ToArray();
            //    //tmp.CopyTo(0, t, sportmans.Count - j, j);
            //    //sportmans = t.ToList();
            //    Array.Copy(tmp.ToArray(), 0, sportmans.ToArray(), sportmans.Count - j, j);
            //}
        }

        public void sortByString(List<Sportman> sportmans)
        {
            throw new NotImplementedException();
        }

        public static int[] SortL(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return arr;

            int i, j;
            var tmp = new int[arr.Length];
            for (int shift = sizeof(int) * 8 - 1; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    var move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }

            return arr;
        }

    }
}
