using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool b = true;

            DateTime? date1 = new DateTime(2020, 5, 30);
            DateTime date2 = date1.GetValueOrDefault();
            DateTime? date3 = date2;
            DateTime? date4 = null;
            DateTime date5 = date4 ?? DateTime.Now; // == (date4 != null) ? date4.GetValueOrDefault() : DateTime.Today


            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date5);
        }
    }
}
