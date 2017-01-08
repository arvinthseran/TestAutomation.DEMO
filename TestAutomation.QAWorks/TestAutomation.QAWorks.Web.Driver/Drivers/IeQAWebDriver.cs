using OpenQA.Selenium.IE;
using System;

namespace TestAutomation.QAWorks.Web.Driver.Drivers
{
    public sealed class IeQAWebDriver : QAWebDriver
    {
        private static int _iePageNavigationTimeout = 10;

        public IeQAWebDriver() 
            : this(AppDomain.CurrentDomain.BaseDirectory, _iePageNavigationTimeout)
        {
        }

        public IeQAWebDriver(int iePageNavigationTimeout)
            : this(AppDomain.CurrentDomain.BaseDirectory, iePageNavigationTimeout)
        {
        }

        public IeQAWebDriver(string filepath) 
            : this(filepath, _iePageNavigationTimeout)
        {
        }

        public IeQAWebDriver(string filepath, int iePageNavigationTimeout)
            : base(new InternetExplorerDriver(filepath, Options()), iePageNavigationTimeout)
        {
            _iePageNavigationTimeout = iePageNavigationTimeout;
        }

        private static InternetExplorerOptions Options()
        {
            var options = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = true,
                EnableFullPageScreenshot = true
            };
            return options;
        }
    }
}
