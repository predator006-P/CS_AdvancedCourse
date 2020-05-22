using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(413));

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
