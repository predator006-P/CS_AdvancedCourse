using System;

namespace Generics
{
    public  class DiscountCalculator<TProduct> where TProduct: Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var book = new BookList();

            var books = new GenericList<BookList>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }
}
