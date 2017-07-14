namespace GFYCatSharp.Objects
{
    public class ErrorResponse
    {
       public ErrorMessage errorMessage { get; set; }
    }

    public class ErrorMessage
    {
        public string code { get; set; }
        public string description { get; set; }

        public string errorMessage { get; set; }
    }
}