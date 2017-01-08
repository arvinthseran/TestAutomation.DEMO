using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public sealed class PostSubmissionPage : ContactPage
    {
        public PostSubmissionPage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "#main")]
        private IWebElement mainPage { get; set; }

        [FindsBy(How = How.Id, Using = "ContactMessageUs")]
        private IWebElement contactForm { get; set; }

        public string ReadPage()
        {
            return mainPage.Text;
        }

        public string ReadContactForm()
        {
            return contactForm.Text;
        }

        public bool AreFieldsCleared()
        {
            return (txtNameBox.Text == string.Empty && txtEmailBox.Text == string.Empty && txtMessageBox.Text == string.Empty);
        }
    }
}
