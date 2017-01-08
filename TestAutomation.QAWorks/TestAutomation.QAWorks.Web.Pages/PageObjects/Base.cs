
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public abstract class Base
    {
        public Base(IQAWebDriver qaWebDriver)
        {
            qaWebDriver.WaitUntilDocIsReady();
            PageFactory.InitElements(qaWebDriver.webDriver, this);
        }
    }
}
