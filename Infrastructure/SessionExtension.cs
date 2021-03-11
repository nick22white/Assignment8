using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace OnlineBookstore.Infrastructure
{
    //This is a tool to convert our cart object to a json (string) file, and then back (we can't store carts in a session)
    public static class SessionExtension
    {
        //Setter
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        //getter
        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
