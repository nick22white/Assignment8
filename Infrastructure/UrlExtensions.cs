using System;
using Microsoft.AspNetCore.Http;

namespace OnlineBookstore.Infrastructure
{
    public static class UrlExtensions
    {
        //Not really sure
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
