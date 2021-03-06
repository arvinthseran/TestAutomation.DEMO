﻿using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomation.QAWorks.Web.Driver.Interface;

namespace TestAutomation.QAWorks.Web.Pages.PageObjects
{
    public class HomePage : Base
    {
        public HomePage(IQAWebDriver qaWebDriver) : base(qaWebDriver)
        {
        }
        
        private List<IWebElement> lnkMenus
        {
            get { return Driver.WebDriver.FindElementsByCssSelector("li > a").ToList(); }
        }

        public ContactPage NavigatetoContactPage()
        {
            var contactLink = lnkMenus.FirstOrDefault(x => x.Text == "Contact");
            contactLink.Click();
            return new ContactPage(Driver);
        }
    }
}
