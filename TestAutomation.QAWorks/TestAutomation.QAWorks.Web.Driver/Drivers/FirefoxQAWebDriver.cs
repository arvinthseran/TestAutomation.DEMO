using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.QAWorks.Web.Driver.Drivers
{
    public sealed class FirefoxQAWebDriver : QAWebDriver
    {
        private static int _defaultTimeOutinSec = 10;

        public FirefoxQAWebDriver()
            : base(new FirefoxDriver(Options()), _defaultTimeOutinSec)
        {
        }

        public FirefoxQAWebDriver(int defaultTimeOutinSec) 
            : base(new FirefoxDriver(Options()), defaultTimeOutinSec)
        {
            _defaultTimeOutinSec = defaultTimeOutinSec;
        }

        private static FirefoxProfile Options()
        {
            var firefoxoptions = new FirefoxProfile
            {
                EnableNativeEvents = true
            };
            firefoxoptions.SetPreference("accessibility.force_disabled", 1);
            return firefoxoptions;
        }
    }
}
