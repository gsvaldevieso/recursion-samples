using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionSamples
{
    public class Factorial: IRecursion
    {
        public int ExecuteRecursion(int number)
        {
            if (number == 1)
                return 1;

            return number * ExecuteRecursion(number - 1);
        }
    }
}
