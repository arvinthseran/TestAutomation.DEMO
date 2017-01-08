using BoDi;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestAutomation.QAWorks.Web.Driver.Interface;
using TestAutomation.QAWorks.Web.Pages;
using TestAutomation.QAWorks.Web.Pages.PageObjects;

namespace TestAutomation.QAWorks.Web.Steps.StepBindings
{
    [Binding]
    public class ContactSteps
    {
        private IQAWebDriver driver;

        private readonly IObjectContainer _objectContainer;

        public ContactSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            driver = _objectContainer.Resolve<IQAWebDriver>();
        }

        [Given(@"I'm on the QAWorks website")]
        public void GivenIMOnTheQAWorksWebsite()
        {
            var qaWorksuri = _objectContainer.Resolve<QAWorksUri>();
            MainPage mainPage = new MainPage(driver);
            var homePage = mainPage.Navigate(qaWorksuri.mainUrl);
            _objectContainer.RegisterInstanceAs(homePage);
        }

        [When(@"I contact QAWorks with the following information")]
        public void WhenIContactQAWorksWithTheFollowingInformation(Table table)
        {
            var homePage = _objectContainer.Resolve<HomePage>();
            var contactPage = homePage.NavigatetoContactPage();
            dynamic contactDetails = table.CreateDynamicInstance();
            contactPage.SendAMessage(contactDetails.Name, contactDetails.Email, contactDetails.Messsage);
        }

        [Then(@"Information should be Submitted Successfully")]
        public void ThenInformationShouldBeSubmittedSuccessfully()
        {
            
        }
    }
}
