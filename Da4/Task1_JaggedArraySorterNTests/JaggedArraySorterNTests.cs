using System;
using NUnit.Framework;
using Task1_JaggedArraySorter;
namespace Task1_JaggedArraySorterNTests
{
    [TestFixture]
    public class JaggedArraySorterNTests
    {
        [Test]
        public void JaggedArraySorter_ArrayD3_SortSum_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100,200,300};
            arr[1] = new double[] { 10,20};
            arr[2] = new double[] { 1};

            JaggedArraySorter.Sorter(arr,JaggedArraySorter.SortType.SUMSORT);

            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }
        [Test]
        public void JaggedArraySorter_ArrayD3_SortSum_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr,JaggedArraySorter.SortType.SUMSORT,inverse:true);
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMax_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr,JaggedArraySorter.SortType.MAXELEMENTSSORT, inverse: true);
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMax_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, JaggedArraySorter.SortType.MAXELEMENTSSORT);
            Assert.IsTrue(arr[0][0] == 1 && arr[1][0] == 10 && arr[2][0] == 100);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMin_ToDown()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, JaggedArraySorter.SortType.MINELEMENTSSORT, inverse: true);
            Assert.IsTrue(arr[0][0] == 100 && arr[1][0] == 10 && arr[2][0] == 1);
        }

        [Test]
        public void JaggedArraySorter_ArrayD3_SortMin_ToUp()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[] { 100, 200, 300 };
            arr[1] = new double[] { 10, 20 };
            arr[2] = new double[] { 1 };

            JaggedArraySorter.Sorter(arr, JaggedArraySorter.SortType.MINELEMENTSSORT);
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
            JaggedArraySorter.Sorter(arr, JaggedArraySorter.SortType.MINELEMENTSSORT);

        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArraySorter_ArrayD3Null_ArgumentNullExep()
        {
            double[][] arr = null;
            JaggedArraySorter.Sorter(arr, JaggedArraySorter.SortType.MINELEMENTSSORT);

        }
    }
}