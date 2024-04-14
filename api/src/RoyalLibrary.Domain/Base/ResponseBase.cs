using System.Collections.Generic;

namespace RoyalLibrary.Domain.Base
{
    public class ResponseBase
    {
        public List<string> Messages { get; set; }
        public int StatusCode { get; set; }

        public ResponseBase()
        {
            Messages = new();
        }
    }
}
