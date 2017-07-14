using System;

namespace GFYCatSharp.Exceptions
{
    public class ClientExceptions : Exception
    {
        public ClientExceptions(string message, Exception ex) : base(message, ex)
        {
            
        }
    }
}