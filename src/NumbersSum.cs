using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionSamples
{
    public class NumbersSum: IRecursion
    {
        public int ExecuteRecursion(int number)
        {
            if (number == 0)
                return 0;

            return number + ExecuteRecursion(number - 1);
        }
    }
}
