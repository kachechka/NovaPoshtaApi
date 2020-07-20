using System;
using System.Runtime.Serialization;
using System.Text.Json;

namespace NovaPoshtaApi.Exceptions
{
    [Serializable]
    internal class ApiResponseFormatException : JsonException
    {
        public ApiResponseFormatException()
        { }

        public ApiResponseFormatException(Exception inner)
            : base("", inner)
        { }

        public ApiResponseFormatException(string? message)
            : base(message)
        { }

        public ApiResponseFormatException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        protected ApiResponseFormatException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
