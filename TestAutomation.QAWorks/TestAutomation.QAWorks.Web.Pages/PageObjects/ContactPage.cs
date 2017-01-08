using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;
using TestAutomation.QAWorks.Web.Driver.Extension;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public class ContactPage : Base
    {
        public ContactPage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
        }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_NameBox")]
        internal IWebElement txtNameBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#ctl00_MainContent_EmailBox")]
        internal IWebElement txtEmailBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "textarea#ctl00_MainContent_MessageBox")]
        internal IWebElement txtMessageBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".SendButton")]
        private IWebElement _btnSend { get; set; }

        public PostSubmissionPage SendAMessage(string name, string email, string message)
        {
            FillContactForm(name, email, message);
            driver.Click(_btnSend);
            return new PostSubmissionPage(driver);
        }

        public void FillContactForm(string name, string email, string message)
        {
            txtNameBox.Type(name);
            txtEmailBox.Type(email);
            txtMessageBox.Type(message);
            Console.WriteLine("Entered contact details");
        }
    }
}
