using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_JaggedArraySorter
{
    public class JaggedArraySorter
    {
        /// <summary>
        /// SUMSSORT = sort by the sum of the elements in array[]
        /// MAXELEMENTSSORT = sort by the maximum element in array[]
        /// MINELEMENTSSORT = sort by the minimum element in array[]
        /// </summary>
        public enum SortType
        {
            SUMSORT,
            MAXELEMENTSSORT,
            MINELEMENTSSORT
        }

        private static Dictionary<SortType, Func<double[], double[], bool, bool>> sortNavigator =
            new Dictionary<SortType, Func<double[], double[], bool, bool>>()
        {
                {
                    SortType.SUMSORT,
                    (a,b,inverse) => ( inverse ? a.Sum()<b.Sum() : a.Sum()>b.Sum())
                },
                 {
                    SortType.MAXELEMENTSSORT,
                    (a,b,inverse) => ( inverse ? a.Max()<b.Max() : a.Max()>b.Max())
                },
                 {
                    SortType.MINELEMENTSSORT,
                    (a,b,inverse) => ( inverse ? a.Min()<b.Min() : a.Min()>b.Min())
                }
        };

        /// <summary>
        /// Sort arrays in array by the Comparator from enum
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="sortFun">Comparator from enum</param>
        /// <param name="inverse">true - Descending, false - Ascending</param>
        public static void Sorter(double[][] array, SortType sortFun= SortType.SUMSORT, bool inverse = false)
        {
            if (array == null) throw new ArgumentNullException();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) throw new ArgumentNullException();
            }
            Sort(array, sortNavigator[sortFun], inverse);
        }

        /// <summary>
        /// Sort arrays in array by the Comparator
        /// </summary>
        /// <param name="array">Array[][] with values</param>
        /// <param name="sortFun">Comparator</param>
        /// <param name="inverse">true - Descending, false - Ascending</param>
        public static void Sorter(double[][] array, Func<double[], double[], bool> sortFun)
        {
            Sort(array, sortFun);
        }

        private static void Sort(double[][] array,Func<double[],double[],bool,bool> compare,bool inverse)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j],array[j+1],inverse))
                    {
                        double[] temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        private static void Sort(double[][] array, Func<double[], double[], bool> compare)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (compare(array[j], array[j + 1]))
                    {
                        double[] temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
