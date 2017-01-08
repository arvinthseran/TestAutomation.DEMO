using System;
using System.Configuration;
using System.Linq;
using TestAutomation.QAWorks.Web.Driver.Enum;
using TestAutomation.QAWorks.Web.Driver.Exceptions;

namespace TestAutomation.QAWorks.Web.Steps.Configuration
{
    /// <summary>
    /// Resolves application setting configuration items
    /// </summary>
    public static class ResolveAppConfig
    {
        /// <summary>
        /// Gets the Application Under Test URL from App.config.
        /// </summary>
        /// <returns></returns>
        public static string GetSiteUrl()
        {
            return ConfigurationManager.AppSettings["AUT.URL"];
        }

        /// <summary>
        /// Gets the browser type to be used from App.config.
        /// </summary>
        /// <returns></returns>
        public static string GetDriverType()
        {
            return ConfigurationManager.AppSettings["AUT.Driver"];
        }
    }
}
