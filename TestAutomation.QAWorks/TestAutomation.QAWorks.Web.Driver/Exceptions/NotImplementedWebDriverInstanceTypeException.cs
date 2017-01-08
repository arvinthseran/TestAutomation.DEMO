using System;

namespace TestAutomation.QAWorks.Web.Driver.Exceptions
{
    public class NotImplementedWebDriverInstanceTypeException : Exception
    {
        public NotImplementedWebDriverInstanceTypeException(string message) :base(message)
        {
        }
        public NotImplementedWebDriverInstanceTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
