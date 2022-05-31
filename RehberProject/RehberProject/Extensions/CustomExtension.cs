using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.UI.Extensions
{
    public static class CustomExtension
    {
        public static void SetObject<T>(this ISession session, string key, T value) 
        {
           var data=  JsonConvert.SerializeObject(value);
            session.SetString(key,data);

        }
        public static T GetObject<T>(this ISession session,string key) where T :class , new()
        {

            var dat = session.GetString(key);
            if(!string.IsNullOrWhiteSpace(dat))
            {
                return JsonConvert.DeserializeObject<T>(dat);

            }
            return null;
        }
    }
}
