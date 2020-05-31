using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip")) 
                {
                    var content = streamReader.ReadToEnd();

                }
                throw new Exception("Oopsz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
