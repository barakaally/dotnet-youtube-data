# dotnet-youtube-data
Package help to retrieve Youtube video and audio Info in various format and their  uls
## Import YoutubeData namespace
```using YoutubeData;```
## Create instance of Youtube class
```Youtube youtube=new Youtube();```;
## Now use GetVideoInfo method to retrive video info,
### There are two ways of using it :-
1. async /await 
2. callback function

## How to use GetVideoInfo with async/await
### method must be wrapped inside async Task 
``` 
Response response=await youtube.GetVideoInfo('videoId') 
       if(response){
         Console.Writeline(response.Data);
       }
```
## How to use GetVideoInfo with callback function

``` 
youtube.GetVideoInfo('videoId',(errors,data)=>{
   Console.Writeline(data);
}) 
```
Data object contain youtube videoInfo ,but the interesting part is video urls which can be found inside formarts(video+audio) and adaptiveFormats(video only or audio only) under streamingData of player_response
### For uncipherd video

```string videoUrl=response.data.player_response.streamingData.formats[0].url ```

### For ciphered video 
```string videoUrl=response.data.player_response.streamingData.formats[0].signatureCipher.url&signature={deciphered signature} ```

