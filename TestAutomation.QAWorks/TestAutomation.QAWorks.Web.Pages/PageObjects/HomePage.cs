
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public class HomePage : Base
    {
        private readonly IQAWebDriver driver;

        public HomePage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
            driver = qaWebDriver;
        }
        
        [FindsBy(How = How.CssSelector, Using ="a.active")]
        private IWebElement lnkHome { get; set; }

        private List<IWebElement> lnkMenus
        {
            get { return driver.webDriver.FindElementsByCssSelector("li > a").ToList(); }
        }

        public ContactPage NavigatetoContactPage()
        {
            var contactLink = lnkMenus.FirstOrDefault(x => x.Text == "Contact");
            contactLink.Click();
            return new ContactPage(driver);
        }
    }
}
