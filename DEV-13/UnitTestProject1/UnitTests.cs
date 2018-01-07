using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamSelectionByCriterion;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTests
  {
    [TestMethod, Description("The exception is also checked.")]
    public void CheckValidProductivity()
    {
      ActionForCase action = new ActionForCase();
      Assert.AreEqual(true, action.CheckInputProductivity(2500));
      Assert.AreEqual(false, action.CheckInputProductivity(25));
    }

    [TestMethod, Description("The exception is also checked.")]
    public void CheckValidPrice()
    {
      ActionForCase action = new ActionForCase();
      Assert.AreEqual(true, action.CheckInputPrice(2500));
      Assert.AreEqual(false, action.CheckInputPrice(25));
    }

    [TestMethod]
    public void CheckStrategy1MaxProductivity()
    {
      Strategy1MaxProductivity checkStrategy1 = new Strategy1MaxProductivity();
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 1 }, checkStrategy1.Algorithm(250));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 1, 0 }, checkStrategy1.Algorithm(500));
      CollectionAssert.AreEqual(new int[4] { 0, 1, 0, 0 }, checkStrategy1.Algorithm(1000));
      CollectionAssert.AreEqual(new int[4] { 1, 0, 0, 0 }, checkStrategy1.Algorithm(2000));
      CollectionAssert.AreEqual(new int[4] { 1, 1, 0, 0 }, checkStrategy1.Algorithm(3000));
      CollectionAssert.AreEqual(new int[4] { 1, 1, 1, 0 }, checkStrategy1.Algorithm(3500));
      CollectionAssert.AreEqual(new int[4] { 1, 0, 1, 0 }, checkStrategy1.Algorithm(2500));
      CollectionAssert.AreEqual(new int[4] { 1, 0, 0, 1 }, checkStrategy1.Algorithm(2250));
      CollectionAssert.AreEqual(new int[4] { 0, 1, 1, 0 }, checkStrategy1.Algorithm(1500));
      CollectionAssert.AreEqual(new int[4] { 0, 1, 0, 1 }, checkStrategy1.Algorithm(1250));
      CollectionAssert.AreEqual(new int[4] { 2, 1, 0, 0 }, checkStrategy1.Algorithm(5000));
      CollectionAssert.AreEqual(new int[4] { 2, 1, 0, 0 }, checkStrategy1.Algorithm(5120));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 1 }, checkStrategy1.Algorithm(270));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 1 }, checkStrategy1.Algorithm(350));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 1, 0 }, checkStrategy1.Algorithm(520));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 1, 0 }, checkStrategy1.Algorithm(630));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 1, 0 }, checkStrategy1.Algorithm(630));
    }

    [TestMethod]
    public void CheckStrategy2MinCost()
    {
      Strategy2MinCost checkStrategy2 = new Strategy2MinCost();
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 1 }, checkStrategy2.Algorithm(500));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 2 }, checkStrategy2.Algorithm(1000));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 3 }, checkStrategy2.Algorithm(1500));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 4 }, checkStrategy2.Algorithm(2000));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 5 }, checkStrategy2.Algorithm(2500));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 6 }, checkStrategy2.Algorithm(3000));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 50 }, checkStrategy2.Algorithm(25000));
    }

    [TestMethod]
    public void Strategy3MinEmployees()
    {
      Strategy3MinEmployees checkMethod3 = new Strategy3MinEmployees();
      CollectionAssert.AreEqual(new int[4] { 0, 0, 0, 1 }, checkMethod3.Algorithm(500));
      CollectionAssert.AreEqual(new int[4] { 0, 0, 1, 0 }, checkMethod3.Algorithm(1100));
      CollectionAssert.AreEqual(new int[4] { 0, 1, 0, 0 }, checkMethod3.Algorithm(2600));
      CollectionAssert.AreEqual(new int[4] { 1, 0, 0, 0 }, checkMethod3.Algorithm(6200));
      CollectionAssert.AreEqual(new int[4] { 1, 0, 0, 1 }, checkMethod3.Algorithm(6750));
      CollectionAssert.AreEqual(new int[4] { 2, 0, 0, 0 }, checkMethod3.Algorithm(12400));
      CollectionAssert.AreEqual(new int[4] { 0, 2, 0, 1 }, checkMethod3.Algorithm(6100));
    }
  }
}      
