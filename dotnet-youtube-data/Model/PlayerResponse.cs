using System.Collections.Generic;

namespace YoutubeData.Model
{
    public class PlayerResponse
    {
        public ResponseContext responseContext;
        public PlayabilityStatus playabilityStatus;
        public StreamingData streamingData;
        public PlaybackTracking playbackTracking;
        public Caption captions;
        public videoDetail videoDetails;
        public List<object> annotations;
        public PlayerConfig playerConfig;
        public Storyboard storyboards;
        public Microformat microformat;
        public string trackingParams;
        public Attestation attestation;
    }

    public class ResponseContext
    {

        public List<object> serviceTrackingParams;
        public object mainAppWebResponseContext;
        public object webResponseContextExtensionData;
      
    }

    public class PlayabilityStatus
    {

        public string status;
        public bool playableInEmbed;
        public object miniplayer;
    }

    public class PlaybackTracking
    {

        public object videostatsPlaybackUrl;
        public object videostatsDelayplayUrl;
        public object videostatsWatchtimeUrl;
        public object ptrackingUrl;
        public object qoeUrl;
        public object atrUrl;
        public object youtubeRemarketingUrl;

    }

    public class StreamingData
    {
        public string expiresInSeconds;
        public List<Format> formats;
        public List<Format> adaptiveFormats;

    }

    public class Caption
    {

        public object playerCaptionsRenderer;
        public object playerCaptionsTracklistRenderer;

    }

    public class videoDetail
    {

        public string videoId;
        public string title;
        public string lengthSeconds;
        public List<string> keywords;
        public string channelId;
        public bool isOwnerViewing;
        public string shortDescription;
        public bool isCrawlable;
        public object thumbnail;
        public int averageRating;
        public bool allowRatings;
        public string viewCount;
        public string author;
        public bool isPrivate;
        public bool isUnpluggedCorpus;
        public bool isLiveContent;

    }

    public class PlayerConfig
    {

        public object audioConfig;
        public object streamSelectionConfig;
        public object daiConfig;
        public object mediaCommonConfig;
        public object webPlayerConfig;
    }

    public class Storyboard
    {

        public object playerStoryboardSpecRenderer;

    }

    public class Microformat
    {

        public object playerMicroformatRenderer;

    }

    public class Attestation
    {

        public object playerAttestationRenderer;

    }
}