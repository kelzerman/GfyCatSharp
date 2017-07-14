using System;

namespace GFYCatSharp.Exceptions
{
    public class OathException: Exception
    {
        public OathException(string message) : base(message)
        {

        }

        public OathException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}