using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.PageObjects
{
  /// <summary>
  /// The page on which you come when you Log in not as Subsctiber
  /// </summary>
  public class DashboardPage : BasePage
  {
    public const string TITLE_FIELD = "//*[@id='title']";
    public const string POST_FIELD = "//textarea[@id='content']";
    public const string SAVE_DRAFT_BUTTON = "#save-post";

    [FindsBy(How = How.CssSelector, Using = SAVE_DRAFT_BUTTON)]
    public IWebElement SaveDraftButton { get; set; }

    [FindsBy(How = How.XPath, Using = TITLE_FIELD)]
    public IWebElement TitleField { get; set; }

    [FindsBy(How = How.XPath, Using = POST_FIELD)]
    public IWebElement PostField { get; set; }

    public DashboardPage(IWebDriver driver) : base(driver)
    { }

    /// <summary>
    /// To write title for post
    /// </summary>
    /// <param name="title">of post which you wanted to add</param>
    /// <returns>the current page</returns>
    public DashboardPage SetTitle(string title)
    {
      TitleField.Clear();
      TitleField.SendKeys(title);
      return this;
    }

    /// <summary>
    /// To write the body of post
    /// </summary>
    /// <param name="post">ehich you want to add</param>
    /// <returns>the current page</returns>
    public DashboardPage WritePost(string post)
    {
      PostField.Clear();
      PostField.SendKeys(post);
      return this;
    }

    /// <summary>
    ///  The method to add a post 
    /// </summary>
    /// <param name="title">of a post</param>
    /// <param name="body">of a post</param>
    /// <returns>the current page</returns>
    public DashboardPage WriteQuickDraft(string title, string body)
    {
      SetTitle(title);
      WritePost(body);
      SaveDraftButton.Click();
      return this;
    }
  }
}
