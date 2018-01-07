using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using WordPress.PageObjects;

namespace Tests
{
  [TestFixture]
  class TestDashboard
  {
    public static readonly string NAME_OF_ADMIN = "admin";
    public static readonly string PASSWORD_OF_ADMIN = "1111";
    public static readonly string TITLE_OF_DRAFT = "BSU";
    public static readonly string POST = "2017";
    public static readonly string XPATH_OF_ADDED_ITEM = ".//p[text()= '2017']";

    IWebDriver driver;
    DashboardPage board;
    LandingPage landingPage;
    LoginPage loginPage;

    [SetUp]
    public void SetUp()
    {
      driver = new FirefoxDriver();
      PageFactory.InitElements(driver, this);
      landingPage = new LandingPage(driver);
      landingPage.GoToPage();
      loginPage = landingPage.GoToLoginPage();
      loginPage.LogIn(NAME_OF_ADMIN, PASSWORD_OF_ADMIN);
      board = new DashboardPage(driver);
    }

    [Test]
    public void TestQuickDraft()
    {
      board.WriteQuickDraft(TITLE_OF_DRAFT, POST);
      Assert.AreEqual("2017", driver.FindElement(By.XPath(XPATH_OF_ADDED_ITEM)).Text);
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
