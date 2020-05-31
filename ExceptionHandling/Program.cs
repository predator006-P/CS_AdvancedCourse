using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            
        }
    }
}
