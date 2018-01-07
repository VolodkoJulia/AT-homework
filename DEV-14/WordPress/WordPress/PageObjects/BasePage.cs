using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.PageObjects
{
  /// <summary>
  /// The class for inheritance.
  /// </summary>
  public class BasePage
  {
    public static readonly string URL = @"http://localhost:8080/";
    public IWebDriver Driver { get; private set; }

    [FindsBy(How = How.XPath, Using = ".//fieldset/input[@placeholder='Search this site...']")]
    public IWebElement SearchBox { get; set; }

    [FindsBy(How = How.XPath, Using = ".//fieldset/input[@value='Search']")]
    public IWebElement GoButton { get; set; }

    /// <summary>
    /// Trivial constructor with field's initialization.
    /// </summary>
    /// <param name="browser"> with wich you work</param>
    public BasePage(IWebDriver browser)
    {
      Driver = browser;
      PageFactory.InitElements(Driver, this);
    }

    /// <summary>
    /// The oppotunity to go on the page with URL.
    /// </summary>
    public void GoToPage()
    {
      Driver.Navigate().GoToUrl(URL);
    }

    /// <summary>
    /// The method to search the information by word 
    /// </summary>
    /// <param name="word">which is writed in searchbox</param>
    public void Search(string word)
    {
      SearchBox.Clear();
      SearchBox.SendKeys(word);
      GoButton.Click();
    }
  }
}