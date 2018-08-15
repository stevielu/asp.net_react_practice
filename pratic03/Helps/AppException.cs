using System;
using System.Globalization;
namespace pratic03.Helps
{
    public class AppException:Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args)
        : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
