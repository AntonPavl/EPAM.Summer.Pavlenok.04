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
        /// SUMSSORT = sort by the sum of the elements in array[]
        /// MAXELEMENTSSORT = sort by the maximum element in array[]
        /// MINELEMENTSSORT = sort by the minimum element in array[]
        /// </summary>
        public enum SortType
        {
            SUM,
            MAX,
            MIN
        }

        public enum SortOrder
        {
            ACK,
            DESC
        }

        private static Dictionary<SortType, Func<double[], double[], SortOrder, bool>> sortNavigator =
            new Dictionary<SortType, Func<double[], double[], SortOrder, bool>>()
        {
            { SortType.SUM, (a,b,order) => ( order == SortOrder.DESC ? a.Sum() < b.Sum() : a.Sum() > b.Sum()) },
            { SortType.MAX, (a,b,order) => ( order == SortOrder.DESC ? a.Max() < b.Max() : a.Max() > b.Max()) },
            { SortType.MIN, (a,b,order) => ( order == SortOrder.DESC ? a.Min() < b.Min() : a.Min() > b.Min()) }
        };

        /// <summary>
        /// Sort arrays in array by the Comparator from enum
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="sortFun">Comparator from enum</param>
        /// <param name="order">DES - Descending, ACK - Ascending</param>
        public static void Sorter(double[][] array, SortType sortFun = SortType.SUM, SortOrder order = SortOrder.ACK)
        {
            if (array == null) throw new ArgumentNullException();
            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) throw new ArgumentNullException();
            }

            Sort(array, sortNavigator[sortFun], order);
        }

        /// <summary>
        /// Sort arrays in array by the Comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="sortFun">Comparator</param>
        /// <param name="order">DES - Descending, ACK - Ascending</param>
        public static void Sorter(double[][] array, Func<double[], double[], bool> sortFun)
        {
            if (array == null) throw new ArgumentNullException();
            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) throw new ArgumentNullException();
            }

            Sort(array, sortFun);
        }

        private static void Sort(double[][] array,Func<double[], double[], SortOrder, bool> compare, SortOrder order) => 
            Sort(array, (a, b) => compare(a, b, order));

        private static void Sort(double[][] array, Func<double[], double[], bool> compare)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j], array[j + 1]))
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
