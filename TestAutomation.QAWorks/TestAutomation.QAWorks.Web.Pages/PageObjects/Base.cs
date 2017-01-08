using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public abstract class Base
    {
        public IQAWebDriver driver;
        public Base(IQAWebDriver qaWebDriver)
        {
            driver = qaWebDriver;
            driver.WaitUntilDocIsReady();
            PageFactory.InitElements(driver.webDriver, this);
        }
    }
}
