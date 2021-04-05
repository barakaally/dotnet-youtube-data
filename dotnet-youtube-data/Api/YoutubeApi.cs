using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using YoutubeData.Model;
using System.Threading.Tasks;
using YoutubeData.Util;

namespace YoutubeData
{
    internal class YoutubeApi
    {
         public  YoutubeApi() { }
         public async Task<Response> FetchInfo(string videoId)
         {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync($"https://www.youtube.com/get_video_info?video_id={videoId}&el=embedded&ps=default&eurl=&gl=US&hl=en");
                var content = await response.Content.ReadAsStringAsync();
                return new Response
                {
                    Data = YExtractor.UrlEncodedToObject(content)
                };


            }
            catch (Exception e)
            {
                return new Response
                {
                    Errors = e.Message,
                };
            }
        }
    }
}
