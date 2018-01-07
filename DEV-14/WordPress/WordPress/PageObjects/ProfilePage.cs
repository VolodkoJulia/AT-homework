using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.PageObjects
{
  /// <summary>
  /// The page on which you come when you Log in as Subsctiber
  /// </summary>
  public class ProfilePage : BasePage
  {
    public const string PAGESWITCH = "//a[@class='ab-item'][text() = 'RAF']";

    [FindsBy(How = How.XPath, Using = PAGESWITCH)]
    public IWebElement PageSwitchButton { get; set; }

    public ProfilePage(IWebDriver browser) : base(browser)
    { }

    /// <summary>
    /// Return to start page
    /// </summary>
    /// <returns>A start page</returns>
    public LandingPage GoToLandingPage()
    {
      PageSwitchButton.Click();
      return new LandingPage(Driver);
    }
  }
}
