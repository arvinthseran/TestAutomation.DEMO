﻿using OpenQA.Selenium.Firefox;

namespace TestAutomation.QAWorks.Web.Driver.Drivers
{
    public sealed class FirefoxQAWebDriver : QAWebDriver
    {
        private static int _defaultTimeOutinSec = 15;

        public FirefoxQAWebDriver() 
            : this(_defaultTimeOutinSec)
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
            firefoxoptions.SetPreference("layout.css.devPixelsPerPx", "1.0");
            return firefoxoptions;
        }
    }
}
