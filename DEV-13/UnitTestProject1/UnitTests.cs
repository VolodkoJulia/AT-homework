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
  }
}          //  To be continued ... //
