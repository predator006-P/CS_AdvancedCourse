using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending a message..." + e.Video.Title);
        }
        public void OnVideoSent(object source, EventArgs e)
        {
            Console.WriteLine("MessageService: video has been sent");
        }
    }
}
