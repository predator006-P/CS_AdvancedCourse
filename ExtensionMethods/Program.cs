using System;

namespace ExtensionMethods
{
    //Adding methods to an exsiting class without:
    // - Changing its source code
    // - Creating new class that inherits from it
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposd to be a very long post blah blah blah ";
            Console.WriteLine(post);
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost + "...");
        }
    }
}
