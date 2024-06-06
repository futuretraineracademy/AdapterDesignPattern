using AdapterDesignPatternSolution.Classes;
using ConsoleApp1.VimeoFramework;
using ConsoleApp1.YoutubeFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternSolution.VideoAdapters
{
    public class YoutubeVideoAdapter (YoutubeAPI youtubeAPI) : IVideoService
    {
        public void Upload(byte[] video)
        {
            youtubeAPI.UploadWithByte(video);
        }
    }

    public class VimeoVideoAdapter(VimeoAPI vimeoAPI) : IVideoService
    {
        public void Upload(byte[] video)
        {
            vimeoAPI.SendVimeo(video);
        }
    }
}
