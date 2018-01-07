using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.PageObjects
{
  /// <summary>
  /// The class describes the page where you can log in 
  /// </summary>
  public class LoginPage : BasePage
  {
    public const string NAME = "user_login";
    public const string PASSWORD = ".//label[@for = 'user_pass']/input[@id='user_pass']";
    public const string LOGINBUTTON = "//*[@id='wp-submit']";

    [FindsBy(How = How.Id, Using = NAME)]
    public IWebElement UserNameField { get; set; }

    [FindsBy(How = How.XPath, Using = PASSWORD)]
    public IWebElement PasswordField { get; set; }

    [FindsBy(How = How.XPath, Using = LOGINBUTTON)]
    public IWebElement LoginButton { get; set; }

    public LoginPage(IWebDriver driver) : base(driver)
    { }

    /// <summary>
    /// To enter a user name in textbox
    /// </summary>
    /// <param name="UserName">the word for input in a textbox for username</param>
    public LoginPage SetUserName(string UserName)
    {
      UserNameField.Clear();
      UserNameField.SendKeys(UserName);
      return this;
    }

    /// <summary>
    ///Set password in password textbox.
    /// </summary>
    /// <param name="Password">the word for input in a textbox for password</param>
    public LoginPage SetPassword(string Password)
    {
      PasswordField.Clear();
      PasswordField.SendKeys(Password);
      return this;
    }

    /// <summary>
    /// Fill all fields for log in.
    /// </summary>
    /// <param name="strUsername">the word for input in field for username</param>
    /// <param name="strPassword">the word for input in field for password</param>
    public DashboardPage LogIn(string strUsername, string strPassword)
    {
      SetUserName(strUsername);
      SetPassword(strPassword);
      LoginButton.Click();
      return new DashboardPage(Driver);
    }

    /// <summary>
    /// The opportunity to go to the page as Subscriber
    /// </summary>
    /// <param name="name">of subscriber</param>
    /// <param name="password">of subscriber</param>
    /// <returns></returns>
    public ProfilePage LogInAsSubscriber(string name, string password)
    {
      SetUserName(name);
      SetPassword(password);
      LoginButton.Click();
      return new ProfilePage(Driver);
    }
  }
}
