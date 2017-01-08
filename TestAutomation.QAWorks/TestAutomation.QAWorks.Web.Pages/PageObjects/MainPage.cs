using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public sealed class MainPage : Base
    {
        private readonly IQAWebDriver driver;
        public MainPage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
            driver = qaWebDriver;
        }

        public HomePage Navigate(string url)
        {
            driver.GoToURL(url);
            return new HomePage(driver);
        }
    }
}
