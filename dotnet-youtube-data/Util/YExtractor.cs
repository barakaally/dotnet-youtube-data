using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeData.Model;

namespace YoutubeData.Util
{
    class YExtractor
    {
        public static VideoInfo UrlEncodedToObject(string videoInfo)
        {
            string[] a = Url.Decode(videoInfo).Split('&');
            Dictionary<string, dynamic> b = new Dictionary<string, dynamic>();
            foreach (var y in a)
            {
                string[] z = y.Split('=');
                if (z.Length == 2)
                {
                    b.Add(z[0], z[1].Replace("+", "").Replace(",", ""));
                }
                else
                {
                    if (z.Contains("player_response"))
                    {
                        var h = string.Join("=", z.Where(x => x != "player_response"));
                        b.Add("player_response", JsonConvert.DeserializeObject(h));
                        b["player_response"]["streamingData"]["formats"] = ParseVideoFormats(b["player_response"]["streamingData"]["formats"]);
                        b["player_response"]["streamingData"]["adaptiveFormats"] = ParseVideoFormats(b["player_response"]["streamingData"]["adaptiveFormats"]);
                    }
                }
            }


            return Dictionary.ToObject<VideoInfo>(b);
        }

        static private JArray ParseVideoFormats(JArray formats)
        {
            JArray jArray = new JArray();
            foreach (var f in formats.ToObject<List<object>>())
            {
                Dictionary<string, dynamic> d = Object.ToDictionary<string, dynamic>(f);

                if (d.ContainsKey("signatureCipher"))
                {
                    d.Add("ciphered", true);
                    Dictionary<string, string> c = new Dictionary<string, string>();
                    foreach (string g in d["signatureCipher"].ToString().Split('&'))
                    {
                        var i = g.Split('=');

                        if (i.Length == 2)
                        {
                            c.Add(i[0], Url.Decode(i[1]));
                        }
                    }

                    d["signatureCipher"] = c;

                }
                else
                {
                    d.Add("ciphered", false);
                }

                jArray.Add(Dictionary.ToObject<dynamic>(d));
            }

            return jArray;
        }
    }
}
