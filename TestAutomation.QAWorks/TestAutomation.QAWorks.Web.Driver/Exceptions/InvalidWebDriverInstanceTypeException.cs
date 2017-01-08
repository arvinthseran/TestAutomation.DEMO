using System;

namespace TestAutomation.QAWorks.Web.Driver.Exceptions
{
    public class InvalidWebDriverInstanceTypeException : Exception
    {
        public InvalidWebDriverInstanceTypeException(string message) :base(message)
        {
        }
        public InvalidWebDriverInstanceTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
