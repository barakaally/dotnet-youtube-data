using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeData.Util
{
    static class Dictionary
    {
        public static T ToObject<T>(IDictionary<string,dynamic> keyValuePairs)
        {
          return JObject.FromObject(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(keyValuePairs))).ToObject<T>();
        }
    }
}
