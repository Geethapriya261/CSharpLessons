using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day3
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }

        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        public override string ToString()
        {
            Console.WriteLine("Media ToString");
            return "OTT";
        }

    }
    //end of media class

    internal class AudioContent : MediaContent
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("Start from autdio content");
        }
    }
    //end of audio content

    internal class VideoContent : MediaContent
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("Start from video content");
        }
    }
    //end of videocontent class
    internal class MediaTester
    {
        public static void TestOne()
        {

        }

    }
}
