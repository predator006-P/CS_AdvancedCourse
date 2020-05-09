using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            var photo = new Photo();

            Action<Photo> filterHandler = filters.ApplyBrightness;

            filterHandler += filters.ApplyContrast;
            filterHandler += Test;

            photoProcessor.Process("photo.jpg", filterHandler);
        }

        static void Test(Photo photo)
        {
            Console.WriteLine("\nTEST!!!\n");
        }
    }
}
