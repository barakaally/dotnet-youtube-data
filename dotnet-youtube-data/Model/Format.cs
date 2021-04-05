using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeData.Model
{
    public class Format
    {
        public string itag;
        public bool ciphered;
        public dynamic signatureCipher;
        public string? url;
        public string mimeType;
        public int bitrate;
        public int width;
        public int height;
        public string lastModified;
        public string contentLength;
        public string quality;
        public int fps;
        public string qualityLabel;
        public string projectionType;
        public int averageBitrate;
        public string audioQuality;
        public string approxDurationMs;
        public string audioSampleRate;
        public int audioChannels;
   
    }


   
    public class SignatureCipher
    {
        public string url;
        public string s;
        public string sp;
    }
}
