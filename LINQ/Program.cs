using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods
            var book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

            var pagedBooks = books.Skip(2).Take(1);
            var count = books.Count();

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);

            Console.WriteLine(book.Title +" " +book.Price);
            Console.WriteLine(book == null);

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title + " " + pagedBook.Price);
            }
            Console.WriteLine(count);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(totalPrices);
        }
    }
}
