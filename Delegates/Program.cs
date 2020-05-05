using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();

            photoProcessor.Process("C:\\");
        }
    }
}
