using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternSolution.Classes
{
    public class VideoManager
    {
        public void UploadVideo(IVideoService videoService, byte[] video)
        {
            videoService.Upload(video);
        }
    }
}
