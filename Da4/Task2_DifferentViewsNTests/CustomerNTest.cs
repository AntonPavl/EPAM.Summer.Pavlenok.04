using System;
using NUnit.Framework;
using Task2_DifferentViews;
using System.Diagnostics;

namespace Task2_DifferentViewsNTests
{


    [TestFixture]
    public class CustomerNTest
    {
        [Test]
        public void Temp()
        {
            Customer data = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            Debug.WriteLine(data.ToString("{1},{2},{0}"));
            Debug.WriteLine(data.ToString("{1},{0},{1}"));
            Debug.WriteLine(data.ToString("{1}"));
            Debug.WriteLine(data.ToString("{2}"));
            Debug.WriteLine(data.ToString("{0},{1}",data.Name,data.Revenue));
            Assert.AreEqual(data, null);
        }
    }
}