using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public sealed class MainPage : Base
    {
        public MainPage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
        }

        public HomePage Navigate(string url)
        {
            driver.GoToURL(url);
            return new HomePage(driver);
        }
    }
}
