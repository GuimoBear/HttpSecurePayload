using System;

namespace HttpSecurePayload.Common.Exceptions
{
    public class InsufficientContentInStreamException : Exception
    {
        public InsufficientContentInStreamException(string packageName) 
            : base("The stream has not sufficient content to deserialize " + packageName) { }
    }
}
