using System;
using NUnit.Framework;
using Task1_JaggedArraySorter;
using System.Collections.Generic;
using System.Linq;

namespace Task1_JaggedArraySorterNTests
{
    [TestFixture]
    public class JaggedARraySorterInterNTest
    {
        public class SumAsc : IComparer<double[]>
        {
            public int Compare(double[] x, double[] y)
            {
                if (x.Sum() > y.Sum()) return 1;
                if (x.Sum() == y.Sum()) return 0;
                else return -1;
            }
        }
        public class SumDesc : IComparer<double[]>
        {
            public int Compare(double[] x, double[] y)
            {
                if (x.Sum() < y.Sum()) return 1;
                if (x.Sum() == y.Sum()) return 0;
                else return -1;
            }
        }
        public class MaxAsc : IComparer<double[]>
        {
            public int Compare(double[] x, double[] y)
            {
                if (x.Max() > y.Max()) return 1;
                if (x.Max() == y.Max()) return 0;
                else return -1;
            }
        }
        public class MaxDesc : IComparer<double[]>
        {
            public int Compare(double[] x, double[] y)
            {
                if (x.Max() < y.Max()) return 1;
                if (x.Max() == y.Max()) return 0;
                else return -1;
            }
        }
        public class MinAsc : IComparer<double[]>
        {
            public int Compare(double[] x, double[] y)
            {
                if (x.Min() > y.Min()) return 1;
                if (x.Min() == y.Min()) return 0;
                else return -1;
            }
        }
        public class MinDesc : IComparer<double[]>
        {
            public int Compare(double[] x, double[] y)
            {
                if (x.Min() < y.Min()) return 1;
                if (x.Min() == y.Min()) return 0;
                else return -1;
            }
        }
        [Test]
        public void JaggedArraySorter_ArrayD3_SortSum_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };
            JaggedArraySorterInterfaces.Sorter(arr,new SumAsc());
            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }
        [Test]
        public void JaggedArraySorter_ArrayD3_SortSum_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };
            JaggedArraySorterInterfaces.Sorter(arr, new SumDesc());
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMax_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };
            JaggedArraySorterInterfaces.Sorter(arr, new MaxDesc());
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMax_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorterInterfaces.Sorter(arr, new MaxAsc());
            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMin_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorterInterfaces.Sorter(arr, new MinDesc());
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMin_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorterInterfaces.Sorter(arr, new MinAsc());
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
            JaggedArraySorterInterfaces.Sorter(arr, new MinDesc());

        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArraySorter_ArrayD3Null_ArgumentNullExep()
        {
            double[][] arr = null;
            JaggedArraySorterInterfaces.Sorter(arr, new MinAsc());

        }
    }
}
