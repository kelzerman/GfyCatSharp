using System;

namespace GFYCatSharp.Exceptions
{
    public class ImageException : Exception
    {
        public ImageException(string message) : base(message)
        {

        }

        public ImageException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}