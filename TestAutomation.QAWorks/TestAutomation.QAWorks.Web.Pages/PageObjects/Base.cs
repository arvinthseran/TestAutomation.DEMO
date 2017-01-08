using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public abstract class Base
    {
        public IQAWebDriver Driver;
        public Base(IQAWebDriver qaWebDriver)
        {
            Driver = qaWebDriver;
            Driver.WaitUntilDocIsReady();
            PageFactory.InitElements(Driver.WebDriver, this);
        }
    }
}
