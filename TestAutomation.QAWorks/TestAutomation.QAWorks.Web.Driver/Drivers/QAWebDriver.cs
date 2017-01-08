using System;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Driver.Drivers
{
    public abstract class QAWebDriver : IQAWebDriver
    {
        private readonly int _defaultTimeOutinSec;

        public RemoteWebDriver webDriver { get; set; }

        public QAWebDriver(RemoteWebDriver remoteWebDriver, int timeout)
        {
            _defaultTimeOutinSec = timeout;
            remoteWebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(_defaultTimeOutinSec));
            remoteWebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(_defaultTimeOutinSec));
            webDriver = remoteWebDriver;
        }

        public string browserName
        {
          get { return webDriver.Capabilities.BrowserName; }   
        }

        public void GoToURL(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void Click(IWebElement webelement)
        {
            WaitforElementTobeDisplayedAndEnabled(webelement);
            webelement.Click();
        }

        public void WaitUntilDocIsReady()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(_defaultTimeOutinSec));
            wait.Until((webdriver) =>
               (webdriver as IJavaScriptExecutor).ExecuteScript("return document.readyState").Equals("complete")
            );
            return;
        }

        public void TakeScreenshot(string filename)
        {
            try
            {
                var shot = webDriver.TakeScreenshot();
                shot.SaveAsFile(filename, ImageFormat.Jpeg);
            }
            catch (Exception screenshotException)
            {
                throw new Exception(string.Format("{0} occured in TakeScreenshot", screenshotException.Message));
            }
        }

        private void WaitforElementTobeDisplayedAndEnabled(IWebElement webelement)
        {
            var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(_defaultTimeOutinSec));

            webDriverWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            webDriverWait.Until((webDriver) => ((webelement.Displayed && webelement.Enabled) == true));
        }        

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    webDriver.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~QAWebDriver() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
