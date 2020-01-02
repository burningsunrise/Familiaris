using System;

namespace Familiaris
{
    internal class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public string Content { get; set; }
    }
}