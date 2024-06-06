using AdapterDesignPatternSolution.Classes;
using AdapterDesignPatternSolution.VideoAdapters;
using ConsoleApp1.VimeoFramework;
using ConsoleApp1.YoutubeFramework;

VideoManager videoManager=new VideoManager();
videoManager.UploadVideo(new YoutubeVideoAdapter(new YoutubeAPI()),new byte[1]);

videoManager.UploadVideo(new VimeoVideoAdapter(new VimeoAPI()),new byte[1]);