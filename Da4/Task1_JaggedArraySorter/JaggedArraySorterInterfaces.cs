using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_JaggedArraySorter
{
    public static class JaggedArraySorterInterfaces
    {

        /// <summary>
        /// Sort arrays in array by the Comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="sortFun">Comparator</param>
        /// <param name="inverse">DES - Descending, ASC - Ascending</param>
        public static void Sorter(double[][] array, IComparer<double[]> comparator)
        {
            if (array == null) throw new ArgumentNullException();
            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) throw new ArgumentNullException();
            }

            Sort(array, comparator);
        }

        private static void Sort(double[][] array, IComparer<double[]> comparator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparator.Compare(array[j], array[j + 1]) > 0)
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
