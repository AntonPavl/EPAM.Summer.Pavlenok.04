using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_JaggedArraySorter
{
    public static class JaggedArraySorterDay8
    {
        private class Adapter : IComparer<double[]>
        {
            public Func<double[],double[],int> Comparer { get; }
            public Adapter(Func<double[],double[],int> comparer)
            {
                Comparer = comparer;
            }
            public int Compare(double[] a, double[] b)
            {
                return Comparer(a, b);
            }
        }

        /// <summary>
        /// Sort arrays in array by the delegate comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="delegate">comparator </param>
        public static void SorterDelegate(double[][] array, Func<double[], double[], int> @delegate)
        {
            if (ReferenceEquals(array, null) || ReferenceEquals(@delegate, null))
                throw new ArgumentNullException();

            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (ReferenceEquals(array[i], null)) throw new ArgumentNullException();
            }
            Sort(array, @delegate);
        }


        /// <summary>
        /// Sort arrays in array by the Interface to delegate comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="comparator">Comparator</param>
        public static void SorterDelegate(double[][] array, IComparer<double[]> comparator) =>
            SorterDelegate(array, comparator.Compare);


        /// <summary>
        /// Sort arrays in array by the delegate to interface comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="delegate">comparator</param>
        public static void SorterInterf(double[][] array, Func<double[], double[], int> @delegate) =>
            SorterInterf(array, new Adapter(@delegate));


        /// <summary>
        /// Sort arrays in array by the interface comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="comparator">Comparator</param>
        public static void SorterInterf(double[][] array, IComparer<double[]> comparator)
        {
            if (ReferenceEquals(array, null) ||
                  ReferenceEquals(comparator, null))
                throw new ArgumentNullException();

            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (ReferenceEquals(array[i], null)) throw new ArgumentNullException();
            }
            Sort(array,comparator);
        }

        private static void Sort(double[][] array, Func<double[],double[],int> @delegate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (@delegate(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
        private static void Sort(double[][] array, IComparer<double[]> comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
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
