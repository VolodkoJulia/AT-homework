using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using WordPress.PageObjects;

namespace Tests
{
  [TestFixture]
  public class TestLoginPage
  {
    const string VALID_NAME_OF_ADMIN = "admin";
    const string VALID_PASSWORD_OF_ADMIN = "1111";
    const string NOTVALID_NAME_OF_USER = "123";
    const string NOTVALID_PASS__OF_USER = "1123";
    const string VALID_NAME_OF_SUBSCRIBER = "Afon";
    const string VALID_PASS__OF_SUBSCRIBER = "ZI)Ii)G9d96rMfkT46E@4pHS";

    [FindsBy(How = How.XPath, Using = ".//span[@class='display-name']")]
    public IWebElement ProfileCell { get; set; }

    LandingPage landingPage;
    LoginPage loginPage;
    IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
      driver = new FirefoxDriver();
      PageFactory.InitElements(driver, this);
      landingPage = new LandingPage(driver);
      landingPage.GoToPage();
      loginPage = landingPage.GoToLoginPage();
    }

    [Test]
    public void TestLogIn()
    {
      loginPage.LogIn(VALID_NAME_OF_ADMIN, VALID_PASSWORD_OF_ADMIN);
      Actions actions = new Actions(driver);
      actions.MoveToElement(ProfileCell).Perform();
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(".//span[@class='username']")));
      Assert.AreEqual("admin", driver.FindElement(By.XPath(".//span[@class='username']")).Text);
    }

    [Test]
    public void TestLogInAsSubscriber()
    {
      loginPage.LogInAsSubscriber(VALID_NAME_OF_SUBSCRIBER, VALID_PASS__OF_SUBSCRIBER);
      Actions actions = new Actions(driver);
      actions.MoveToElement(ProfileCell).Perform();
      new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(".//span[@class='username']")));
      Assert.AreEqual("Afon", driver.FindElement(By.XPath(".//span[@class='username']")).Text);
    }

    [Test]
    public void TestLogInWithWrongData()
    {
      loginPage.LogIn(NOTVALID_NAME_OF_USER, NOTVALID_PASS__OF_USER);
      Assert.AreEqual("http://localhost:8080/wp-login.php", driver.Url);
      Assert.AreEqual("ERROR", driver.FindElement(By.XPath(".//strong")).Text);
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