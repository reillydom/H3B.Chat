using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace H3B.Chat.Exceptions
{
    public class RequestProviderHttpRequestException : HttpRequestException
    {
        public System.Net.HttpStatusCode HttpCode { get; }
        public RequestProviderHttpRequestException(System.Net.HttpStatusCode code) : this(code, null, null)
        {
        }

        public RequestProviderHttpRequestException(System.Net.HttpStatusCode code, string message) : this(code, message, null)
        {
        }

        public RequestProviderHttpRequestException(System.Net.HttpStatusCode code, string message, Exception inner) : base(message,
            inner)
        {
            HttpCode = code;
        }

    }
}
