using BoDi;
using TechTalk.SpecFlow;
using TestAutomation.QAWorks.Web.Driver.Interface;
using TestAutomation.QAWorks.Web.Pages;
using TestAutomation.QAWorks.Web.Steps.Configuration;

namespace TestAutomation.QAWorks.Web.Steps.StepBindings
{
    [Binding]
    public class Hooks : TechTalk.SpecFlow.Steps
    {
        private readonly IObjectContainer _objectContainer;

        private static string _url;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //We can resolve webdriver instance type using App.Config
            //and pass it as a param from NUNIT console 
            //webDriverInstanceType = ResolveAppConfig.GetDriverType();
            _url = ResolveAppConfig.GetSiteUrl();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _objectContainer.RegisterInstanceAs(new QAWorksUri { MainUrl = _url });
        }

        [BeforeScenario Scope(Tag = "Chrome")]
        public void RegisterChromeDriver()
        {
            Given(@"I'm using Chrome");
        }

        [BeforeScenario, Scope(Tag = "FireFox")]
        public void RegisterFireFoxDriver()
        {
            Given(@"I'm using FireFox");
        }

        [BeforeScenario, Scope(Tag = "InternetExplorer")]
        public void RegisterIEDriver()
        {
            Given(@"I'm using InternetExplorer");
        }

        [BeforeScenario, Scope(Tag = "PhantomJS")]
        public void RegisterPhantomJSDriver()
        {
            Given(@"I'm using PhantomJS");
        }

        [AfterScenario(Order = 0)]
        public void AfterScenario()
        {
            Given(@"I take a screenshot");
        }

        [AfterScenario(Order = 1)]
        public void DisposeWebDriver()
        {
            var webDriver = _objectContainer.Resolve<IQAWebDriver>();

            webDriver?.Dispose();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
        }
    }
}
