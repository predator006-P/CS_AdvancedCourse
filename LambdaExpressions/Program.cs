using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> square = number => number * number;
            Func<int, int> square = number => number * number;
            square += Multiply;
            square += MultiplyByThree;
            square += Multiply;

            Action writeSomething = WriteSomething;


            Console.WriteLine(square(413));
            Console.WriteLine(writeSomething);


            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(book => book.Price < 10);

            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}
            
        }

        private static void WriteSomething()
        {
            Console.WriteLine("Something");
        }

        private static int Multiply(int numeber)
        {
            Console.WriteLine("Return 5 times\t"+ 5*numeber);
            return 5 * numeber;
        }
        private static int MultiplyByThree(int numeber)
        {
            Console.WriteLine("Return 3 times\t"+3*numeber);
            return 3 * numeber;
        }
    }
}
