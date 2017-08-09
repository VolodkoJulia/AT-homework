using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numsequence_new;
namespace SequenceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsNondecreasing()
        {
            int[] array = { 3, 5, 7 };
            bool res = new SequenceAnalysis().CheckSequence(array);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void IsNotNonDecreasing()
        {
            int[] array = { 3, 2, 7 };
            bool res = new SequenceAnalysis().CheckSequence(array);
            Assert.AreEqual(false, res);
        }
    }
}
