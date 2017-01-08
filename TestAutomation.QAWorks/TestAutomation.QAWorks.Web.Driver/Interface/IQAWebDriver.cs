using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace TestAutomation.QAWorks.Web.Driver.Interface
{
    public interface IQAWebDriver : IDisposable
    {
        RemoteWebDriver webDriver { get; set; }
        string browserName { get; }
        void GoToURL(string url);
        void WaitUntilDocIsReady();
        void TakeScreenshot(string fileName);
    }
}
