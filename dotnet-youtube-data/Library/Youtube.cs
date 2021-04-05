using System;
using System.Threading.Tasks;
using YoutubeData.Model;

namespace YoutubeData
{
    public class Youtube
    {
        public delegate void InfoCallback(object errors, VideoInfo data);
        public Youtube() { }
        /**
          <summary>
          Use async/await operator and  VIDEOID e.g 50jyn6_rLFA,
          Retrieved Video can be of found inside formats(video+audio) or adapativeFormats(only video or audio)
          </summary>
          <param name="videoId"></param>
          <returns><c>Response</c> </returns>
         */
        public async Task<Response> GetVideoInfo(string videoId)
        {
            return await new YoutubeApi().FetchInfo(videoId);

        }
        /**
          <summary>
          Retrieve video info by using VIDEO ID e.g 50jyn6_rLFA,
          Access videoInfo from callback function
          Retrieved Video can be of found inside formats(video+audio) or adapativeFormats(only video or audio)
          </summary>
          <param name="callBack"></param>
          <param name="videoId"></param>
         */
        public void GetVideoInfo(string videoId, InfoCallback callBack)
        {
            Task<Response> res = new YoutubeApi().FetchInfo(videoId);
            callBack(res.Result.Errors, res.Result.Data);
        }

    }


}
