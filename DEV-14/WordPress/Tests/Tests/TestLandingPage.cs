using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WordPress.PageObjects;

namespace Tests
{
  class TestLandingPage
  {
    public static readonly string NAME_OF_ADMIN = "admin";
    public static readonly string PASSWORD_OF_ADMIN = "1111";

    [TestFixture]
    class TestBasePage
    {
      LandingPage landingPage;
      IWebDriver driver;

      [SetUp]
      public void SetUp()
      {
        driver = new FirefoxDriver();
        landingPage = new LandingPage(driver);
        landingPage.GoToPage();
      }

      [Test]
      public void TestGoToLoginPage()
      {
        landingPage.GoToLoginPage();
        Assert.AreEqual("http://localhost:8080/wp-login.php", driver.Url);
      }

      [Test]
      public void TestGoToDashboard()
      {
        LoginPage loginPage = landingPage.GoToLoginPage();
        loginPage.LogIn(NAME_OF_ADMIN, PASSWORD_OF_ADMIN);
        landingPage.GoToDashboard();
        Assert.AreEqual("http://localhost:8080/", driver.Url);
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
}
