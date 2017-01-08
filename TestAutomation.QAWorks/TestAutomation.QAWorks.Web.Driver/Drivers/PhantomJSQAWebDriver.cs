using System;
using OpenQA.Selenium.PhantomJS;

namespace TestAutomation.QAWorks.Web.Driver.Drivers
{
    public sealed class PhantomJSQAWebDriver : QAWebDriver
    {
        private static int _defaultTimeOutinSec = 10;

        public PhantomJSQAWebDriver()
            : this(AppDomain.CurrentDomain.BaseDirectory, _defaultTimeOutinSec)
        {

        }
        public PhantomJSQAWebDriver(int pageNavigationTimeout)
            : this(AppDomain.CurrentDomain.BaseDirectory, pageNavigationTimeout)
        {
        }

        public PhantomJSQAWebDriver(string filepath)
            : this(filepath, _defaultTimeOutinSec)
        {
        }

        public PhantomJSQAWebDriver(string filepath, int pageNavigationTimeout)
            : base(new PhantomJSDriver(filepath, Options()), pageNavigationTimeout)
        {
            _defaultTimeOutinSec = pageNavigationTimeout;
        }
        private static PhantomJSOptions Options()
        {
            var options = new PhantomJSOptions();
            return options;
        }
    }
}
