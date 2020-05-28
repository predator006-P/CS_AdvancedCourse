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

            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)  //filter
                                .OrderBy(b => b.Title)     //sort
                                .Select(b => b.Title);     //select

            foreach (var book in cheaperBooks)
            {
               // Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }
        }
    }
}
