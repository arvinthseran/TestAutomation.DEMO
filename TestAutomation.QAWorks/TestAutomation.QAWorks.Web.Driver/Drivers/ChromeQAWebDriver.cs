using OpenQA.Selenium.Chrome;
using System;

namespace TestAutomation.QAWorks.Web.Driver.Drivers
{
    public sealed class ChromeQAWebDriver : QAWebDriver
    {
        private static int _defaultTimeOutinSec = 10;

        public ChromeQAWebDriver()
            : this(AppDomain.CurrentDomain.BaseDirectory, _defaultTimeOutinSec)
        {

        }
        public ChromeQAWebDriver(int pageNavigationTimeout)
            : this(AppDomain.CurrentDomain.BaseDirectory, pageNavigationTimeout)
        {
        }

        public ChromeQAWebDriver(string filepath)
            : this(filepath, _defaultTimeOutinSec)
        {
        }

        public ChromeQAWebDriver(string filepath, int pageNavigationTimeout)
            : base(new ChromeDriver(filepath, Options()), pageNavigationTimeout)
        {
            _defaultTimeOutinSec = pageNavigationTimeout;
        }

        private static ChromeOptions Options()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.prompt_for_download", true);
            options.AddArguments("no-sandbox");
            return options;
        }

    }
}
