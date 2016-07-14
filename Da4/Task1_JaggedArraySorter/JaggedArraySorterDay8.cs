using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_JaggedArraySorter
{
    public static class JaggedArraySorterDay8
    {
        /// <summary>
        /// Sort arrays in array by the DelegateInInterfae comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="delegate">delegate in interface</param>
        /// <param name="comparator">Comparator</param>
        public static void Sorter(double[][] array, Func<double[],double[],int> @delegate, IDelegateComparer comparator)
        {
            if (ReferenceEquals(array, null) ||
                ReferenceEquals(@delegate, null) ||
                ReferenceEquals(comparator, null))
                throw new ArgumentNullException();

            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (ReferenceEquals(array[i], null)) throw new ArgumentNullException();
            }
            Sort(array, @delegate,comparator);
        }

        private static void Sort(double[][] array, Func<double[], double[], int> @delegate, IDelegateComparer comparator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparator.Compare(array[j], array[j + 1],@delegate) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sort arrays in array by the InterfaceInDelegate comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="delegate">delegate in interface</param>
        /// <param name="comparator">Comparator</param>
        public static void Sorter(double[][] array, Func<double[], double[], IDelegateComparer, int> @delegate, IDelegateComparer comparator)
        {
            if (ReferenceEquals(array, null)     ||
                ReferenceEquals(@delegate, null) || 
                ReferenceEquals(comparator, null)) throw new ArgumentNullException();

            if (array.Length == 0) return;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) throw new ArgumentNullException();
            }
            Sort(array, @delegate, comparator);
        }

        private static void Sort(double[][] array, Func<double[],double[],IDelegateComparer, int> @delegate, IDelegateComparer comparator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (@delegate(array[j], array[j + 1], comparator) > 0)
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
