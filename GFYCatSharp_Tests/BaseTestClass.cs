using System;
using GFYCatSharp.Exceptions;

namespace GFYCat_Tests
{
    public class BaseTestClass
    {
        public string ClientId => "2_htNlJc";
        public string ClientSecret => "dLXfkZ77sL1yfF4znk8eMuw1oXWMXCDxkG8XWm8paYouD23W00ZVlQWEelbCjN3m";

        private GFYCatSharp.Agent _agent;

        public GFYCatSharp.Agent Agent => _agent ?? (_agent = new GFYCatSharp.Agent(ClientId, ClientSecret));

        public bool ArgumentNullException(Action func, string parameterName)
        {
            try
            {
                func();
            }
            catch (ArgumentNullException aex)
            {
                return aex.Message.Equals("Value cannot be null.\r\nParameter name: " + parameterName);
            }

            return false;
        }

        public bool ImageException_DoesNotExists(Action func, string imageId)
        {
            try
            {
                func();
            }
            catch (ImageException aex)
            {
                return aex.Message.Equals($"{imageId} does not exist.");
            }

            return false;
        }

        public bool OathException(Action func, string code)
        {
            try
            {
                func();
            }
            catch (OathException ex)
            {
                return ex.Message.Equals(code);
            }

            return false;
        }
    }
}