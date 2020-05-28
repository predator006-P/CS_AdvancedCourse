using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool b = true;

            DateTime? date1 = null;
            Nullable<DateTime> date2 = null;

            Console.WriteLine(date1.GetValueOrDefault());
            Console.WriteLine(date1.HasValue);
            Console.WriteLine(date1.Value);//it will throw an InvalidOperationException
        }
    }
}
