using System.Configuration;

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
        public static string GetSiteUrl()
        {
            return ConfigurationManager.AppSettings["AUT.URL"];
        }

        /// <summary>
        /// Gets the browser type to be used from App.config.
        /// </summary>
        public static string GetDriverType()
        {
            return ConfigurationManager.AppSettings["AUT.Driver"];
        }
    }
}
