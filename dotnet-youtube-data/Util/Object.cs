using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using YoutubeData.Model;

namespace YoutubeData.Util
{
    static class Object
    {
        public static Dictionary<Key,Value> ToDictionary<Key,Value>(object value)
        {

 
            Dictionary<Key, Value> d = new Dictionary<Key,Value>();

            foreach (dynamic o in JObject.FromObject(value))
            {
                d.Add(o.Key, o.Value);
            }

            return d;
        }
    }
}
