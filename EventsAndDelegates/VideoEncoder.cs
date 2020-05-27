using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Rise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        //public event EventHandler VideoEncoded;
        public event EventHandler VideoSent;

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        public void Send(Video video)
        {
            Console.WriteLine("Sending a video");
            Thread.Sleep(3000);
            OnVideoSending();

        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {Video = video });
        }

        protected virtual void OnVideoSending() 
        {
            if (VideoSent != null)
                VideoSent(this, EventArgs.Empty);
        }
    }
}
