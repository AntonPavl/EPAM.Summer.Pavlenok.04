using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_JaggedArraySorter
{
    public static class JaggedArraySorter
    {
        /// <summary>
        /// Sort arrays in array by the Comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="sortFun">Comparator</param>
        /// <param name="inverse">DES - Descending, ASC - Ascending</param>
        public static void Sorter(double[][] array, Func<double[], double[], int> sortFun)
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(sortFun, null)) throw new ArgumentNullException();
            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (ReferenceEquals(array[i], null)) throw new ArgumentNullException();
            }

            Sort(array, sortFun);
        }
        private static void Sort(double[][] array, Func<double[], double[], int> compare)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }   
            }
        }

        private static void Swap(ref double[] a, ref double[] b)
        {
            double[] temp = a;
            a = b;
            b = temp;
        }

    }
}
