using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kernel;

namespace Tests
{
    [TestClass]
    public class AlgorithmsTest
    {
        /// <summary>
        /// Testing the Bisection method. Function f(x) = x - 1 is using as an input function for a Bisection.
        /// We know in advance, that if the method is written correctly - in the output we will get 1
        /// So, we have a right to round the result of Bisection() to get a comparison.
        /// 31.10.2018 - passed.
        /// </summary>
        [TestMethod]
        public void BisectionTest()
        {
            double Function(double x)
            {
                return x - 1;
            }

            Assert.AreEqual(Math.Floor(Algorithms.Bisection(Function, 0, 5, 0.001)), 1);
        }
    }
}
