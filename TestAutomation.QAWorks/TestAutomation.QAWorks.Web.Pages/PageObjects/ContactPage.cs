
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;
using TestAutomation.QAWorks.Web.Driver.Extension;
using System;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public sealed class ContactPage : Base
    {
        public ContactPage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
        }

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_NameBox")]
        private IWebElement txtNameBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#ctl00_MainContent_EmailBox")]
        private IWebElement txtEmailBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "textarea#ctl00_MainContent_MessageBox")]
        private IWebElement txtMessageBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#ctl00_MainContent_SendButton")]
        private IWebElement btnSend { get; set; }

        public void SendAMessage(string name, string email, string message)
        {
            txtNameBox.Type(name);
            txtEmailBox.Type(email);
            txtMessageBox.Type(message);
            Console.WriteLine("Entered contact details");
        }
    }
}
