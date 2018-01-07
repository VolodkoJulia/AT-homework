using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WordPress.PageObjects;

namespace WordPress
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver driver = new FirefoxDriver();
      driver.Navigate().GoToUrl(@"http://localhost:8080/");
      LandingPage landPage = new LandingPage(driver);
      LoginPage loginPage = landPage.GoToLoginPage();
    }
  }
}
