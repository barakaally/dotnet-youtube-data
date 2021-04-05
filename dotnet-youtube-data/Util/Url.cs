using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeData.Util
{
    static class Url
    {
        static public string Decode(string url)
        {
            return Uri.UnescapeDataString(url);
        }
    }
}
