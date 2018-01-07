using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.PageObjects
{
  /// <summary>
  /// The class which is describes the home page.
  /// </summary>
  public class LandingPage : BasePage
  {
    public const string LOGIN_BUTTON = "//*[text()='Log in']";
    public const string RETURN_TO_DASHBOARD_BUTTON = "//li[@id='wp-admin-bar-site-name']/a[@aria-haspopup='true']";
    public const string LANDINGPAGE_ELEMENT = "//div[@class='home blog hfeed']";

    [FindsBy(How = How.XPath, Using = LOGIN_BUTTON)]
    public IWebElement LoginButton { get; set; }

    [FindsBy(How = How.XPath, Using = RETURN_TO_DASHBOARD_BUTTON)]
    public IWebElement ReturnToDashBoard { get; set; }


    public LandingPage(IWebDriver driver) : base(driver)
    { }

    /// <summary>
    /// Check:if it's a home page by the existence of an element.
    /// </summary>
    /// <returns>true, if element exists</returns>
    public bool CheckIfItLandingPage()
    {
      try
      {
        Driver.FindElement(By.XPath(LANDINGPAGE_ELEMENT));
        return true;
      }
      catch (NoSuchElementException)
      {
        return false;
      }
    }

    /// <summary>
    /// Move to  page for log in or sign up
    /// </summary>
    /// <returns>the page where you can log in or sign up</returns>
    public LoginPage GoToLoginPage()
    {
      LoginButton.Click();
      return new LoginPage(Driver);
    }

    /// <summary>
    /// The opportunity to return on dashboard after authorization
    /// </summary>
    /// <returns>To the page with panel</returns>
    public DashboardPage GoToDashboard()
    {
      ReturnToDashBoard.Click();
      return new DashboardPage(Driver);
    }
  }
}
