using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandling
{
    public class Video
    {
        public string Title { get; set; }
    }
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read data
                // Create a list of Video objects

                throw new Exception("Opps, some YouTube error happened....");
            }
            catch (Exception ex)
            {
                // Log 
                throw new YouTubeException("Could not fetch the videos from YouTube", ex);
            }
            return new List<Video>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is a test branch version.");
                var youTubeApi = new YouTubeApi();
                youTubeApi.GetVideos("Peti");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
