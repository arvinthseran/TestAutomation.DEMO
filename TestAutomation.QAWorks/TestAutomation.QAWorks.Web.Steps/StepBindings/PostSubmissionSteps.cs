using BoDi;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TestAutomation.QAWorks.Web.Pages.PageObjects;

namespace TestAutomation.QAWorks.Web.Steps.StepBindings
{
    [Binding]
    public class PostSubmissionSteps 
    {
        private readonly IObjectContainer _objectContainer;

        public PostSubmissionSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [Then(@"Information should be Submitted Successfully")]
        public void ThenInformationShouldBeSubmittedSuccessfully()
        {
            Assert.True(checkMessageinContactForm("Send us a message"), "Send Us A Message is not displayed after submission");
        }

        [Then(@"All fields should be cleared")]
        public void ThenAllFieldsShouldBeCleared()
        {
            var postSubmissionPage = _objectContainer.Resolve<PostSubmissionPage>();
            Assert.True(postSubmissionPage.AreFieldsCleared(), "Fields are not cleared after submission");
        }

        [Then(@"Thank you message should be displayed")]
        public void ThenThankYouMessageShouldBeDisplayed()
        {
            Assert.True(checkMessageinPostSubmissionPage("Thank You"), "Thank You is not displayed after submission");
        }

        [Then(@"I should see following error (.*)")]
        public void ThenIShouldSeeFollowingError(string errormessage)
        {
            Assert.True(checkMessageinPostSubmissionPage(errormessage), string.Format("{0} is not displayed after submission", errormessage));
        }

        private bool checkMessageinPostSubmissionPage(string message)
        {
            var postSubmissionPage = _objectContainer.Resolve<PostSubmissionPage>();
            var mainPageText = postSubmissionPage.ReadPage();
            return mainPageText.ToLower().Contains(message.ToLower());
        }

        private bool checkMessageinContactForm(string message)
        {
            var postSubmissionPage = _objectContainer.Resolve<PostSubmissionPage>();
            var contactFormText = postSubmissionPage.ReadContactForm();
            return contactFormText.ToLower().Contains(message.ToLower());
        }

    }
}
