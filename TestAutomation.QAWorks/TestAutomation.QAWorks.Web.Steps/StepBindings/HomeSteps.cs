using BoDi;
using TechTalk.SpecFlow;
using TestAutomation.QAWorks.Web.Driver.Interface;
using TestAutomation.QAWorks.Web.Pages;
using TestAutomation.QAWorks.Web.Pages.PageObjects;

namespace TestAutomation.QAWorks.Web.Steps.StepBindings
{
    [Binding]
    public class HomeSteps
    {
        private readonly IObjectContainer _objectContainer;

        public HomeSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [Given(@"I'm on the QAWorks website")]
        public void GivenIMOnTheQAWorksWebsite()
        {
            var driver = _objectContainer.Resolve<IQAWebDriver>();
            var qaWorksUri = _objectContainer.Resolve<QAWorksUri>();
            MainPage mainPage = new MainPage(driver);
            var homePage = mainPage.Navigate(qaWorksUri.MainUrl);
            _objectContainer.RegisterInstanceAs(homePage);
        }
    }
}
