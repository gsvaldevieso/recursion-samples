using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IRecursion factorial = RecursionFactory.Get(Recursions.FACTORIAL);
            IRecursion numbersSum = RecursionFactory.Get(Recursions.NUMBERS_SUM);
            Console.WriteLine(factorial.ExecuteRecursion(10));
            Console.WriteLine(numbersSum.ExecuteRecursion(10));
            Console.ReadKey();
        }
    }
}
