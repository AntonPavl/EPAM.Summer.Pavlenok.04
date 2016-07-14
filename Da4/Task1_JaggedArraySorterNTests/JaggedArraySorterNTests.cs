using System;
using NUnit.Framework;
using Task1_JaggedArraySorter;
using System.Collections.Generic;
using System.Linq;

namespace Task1_JaggedArraySorterNTests
{
    [TestFixture]
    public class JaggedArraySorterNTests
    {
        public enum SortType
        {
            SUM,
            MAX,
            MIN,
            SUMD,
            MAXD,
            MIND
        }

        private static Dictionary<SortType, Func<double[], double[], int>> sortNavigator =
            new Dictionary<SortType, Func<double[], double[], int>>()
        {
                    { SortType.SUM, (a,b) => a.Sum().CompareTo(b.Sum())  },
                    { SortType.MAX, (a,b) => a.Max().CompareTo(b.Max()) },
                    { SortType.MIN, (a,b) => a.Min().CompareTo(b.Min()) },
                    { SortType.SUMD, (a,b) => b.Sum().CompareTo(a.Sum())  },
                    { SortType.MAXD, (a,b) => b.Max().CompareTo(a.Max()) },
                    { SortType.MIND, (a,b) => b.Min().CompareTo(a.Min()) }
        };

        [Test]
        public void JaggedArraySorter_ArrayD3_SortSum_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100,200,300};
            arr[1] = new double[] { 10,20};
            arr[2] = new double[] { 1};

            JaggedArraySorter.Sorter(arr,sortNavigator[SortType.SUM]);

            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }
        [Test]
        public void JaggedArraySorter_ArrayD3_SortSum_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.SUMD]);
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMax_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.MAXD]);
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMax_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.MAX]);
            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMin_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.MIND]);
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMin_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.MIN]);
            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArraySorter_ArrayD3_ArrayNull_ArgumentNullExep()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = null;
            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.SUM]);

        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArraySorter_ArrayD3Null_ArgumentNullExep()
        {
            double[][] arr = null;
            JaggedArraySorter.Sorter(arr, sortNavigator[SortType.SUM]);

        }
    }
}