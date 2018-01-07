using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WordPress.PageObjects;

namespace Tests
{
  [TestFixture]
  class TestBasePage
  {
    public static readonly string RESULT = ".//h1[contains(text(),'Search Results For: Day')]";
    BasePage basePage;
    IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
      driver = new FirefoxDriver();
      basePage = new BasePage(driver);
      basePage.GoToPage();
    }

    [Test]
    public void TestSearchExistingPost()
    {
      basePage.Search("Day");
      Assert.AreEqual(driver.FindElements(By.XPath(RESULT)).Count, 1);
    }

    [TearDown]
    public void Quit()
    {
      if (driver != null)
      {
        driver.Quit();
      }
    }
  }
}
