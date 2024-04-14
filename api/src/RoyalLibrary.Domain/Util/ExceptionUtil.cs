using System;

namespace RoyalLibrary.Domain.Util
{
    public static class ExceptionUtil
    {
        public static string GetAllMessages(this Exception ex)
        {
            string msg = ex.Message;

            Exception inner = ex.InnerException;
            int indexInner = 1;

            while (inner != null)
            {
                msg += $" | Inner{indexInner}: {inner.Message}";

                inner = inner.InnerException;
            }

            return msg;
        }
    }
}
