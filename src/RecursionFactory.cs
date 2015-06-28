using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionSamples
{
    public enum Recursions
    {
        FACTORIAL = 0,
        NUMBERS_SUM = 1
    }

    public static class RecursionFactory
    {

        public static IRecursion Get(Recursions recursion)
        {
            switch (recursion)
            {
                case Recursions.FACTORIAL:
                    return new Factorial();
                case Recursions.NUMBERS_SUM:
                    return new NumbersSum();
                default:
                    return null;
            }
        }
    }
}
