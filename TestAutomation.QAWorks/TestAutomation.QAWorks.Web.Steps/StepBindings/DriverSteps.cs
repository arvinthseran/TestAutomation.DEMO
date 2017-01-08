using BoDi;
using TechTalk.SpecFlow;
using TestAutomation.QAWorks.Web.Driver.Enum;
using TestAutomation.QAWorks.Web.Driver.Interface;
using TestAutomation.QAWorks.Web.Driver.Drivers;
using TestAutomation.QAWorks.Web.Driver.Exceptions;
using System;
using System.Linq;

namespace TestAutomation.QAWorks.Web.Steps.StepBindings
{
    [Binding]
    public class DriverSteps
    {
        private readonly IObjectContainer _objectContainer;

        public DriverSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [Given(@"I'm using (.*)")]
        public void GivenImUsing(WebDriverInstanceType browser)
        {
            if (_objectContainer.ResolveAll<IQAWebDriver>().Any())
                throw new DuplicateWebDriverInstanceTypeException("Web Driver Instance Type is already defined");
            
            //Can use Enum.Parse instead of Step Argument Transformation.
            switch (browser)
            {
                case WebDriverInstanceType.Chrome:
                    _objectContainer.RegisterInstanceAs<IQAWebDriver>(new ChromeQAWebDriver());
                    break;

                case WebDriverInstanceType.FireFox:
                    _objectContainer.RegisterInstanceAs<IQAWebDriver>(new FirefoxQAWebDriver());
                    break;

                case WebDriverInstanceType.InternetExplorer:
                    _objectContainer.RegisterInstanceAs<IQAWebDriver>(new IeQAWebDriver());
                    break;

                case WebDriverInstanceType.PhantomJS:
                    _objectContainer.RegisterInstanceAs<IQAWebDriver>(new PhantomJSQAWebDriver());
                    break;

                default:
                    throw new NotImplementedWebDriverInstanceTypeException(string.Format("{0} Web Driver Type is Not Implemented", browser));
            }
        }

        [Given(@"I take a screenshot")]
        public void GivenITakeAScreenshot()
        {
           var webDriver= _objectContainer.Resolve<IQAWebDriver>();

            webDriver?.TakeScreenshot(string.Format("{0}{3}-{1}-{2}.jpeg", "C:\\",
                   ScenarioContext.Current.ScenarioInfo.Title.Replace(" ", ""),
                   DateTime.Now.ToString("ddMMyyyyHHmm"),
                   webDriver.browserName));
        }

        [StepArgumentTransformation(@"using (Chrome|FireFox|InternetExplorer|PhantomJS)")]
        public WebDriverInstanceType WebDriverInstanceTypeTransform(WebDriverInstanceType browser)
        {
            return browser;
        }
    }
}
