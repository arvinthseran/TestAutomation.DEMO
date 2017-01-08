using OpenQA.Selenium;

namespace TestAutomation.QAWorks.Web.Driver.Extension
{
    public static class WebElementExtension
    {
        public static void Type(this IWebElement webelement, string text)
        {
            webelement.Clear();
            webelement.SendKeys(text);
        }
    }
}
