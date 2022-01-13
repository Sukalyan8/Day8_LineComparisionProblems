using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_LineComparisionProblems
{
    class UC1
    {
        public void LengthOfLine(int X1, int X2, int Y1, int Y2)
        {
            var distance = Math.Sqrt((Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)));
            Console.WriteLine("Length of a line is " + distance);
        }
    }
}