using System;

namespace TestAutomation.QAWorks.Web.Driver.Exceptions
{
    public class DuplicateWebDriverInstanceTypeException : Exception
    {
        public DuplicateWebDriverInstanceTypeException(string message) : base(message)
        {
        }
        public DuplicateWebDriverInstanceTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
