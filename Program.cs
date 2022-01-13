using System;

namespace Day8_LineComparisionProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n Welcome to Line Comparison Computation Program on Main Branch");

            Console.WriteLine("Enter X1 value :-");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y1 value :-");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 value :-");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y2 value :-");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ---------------------------------------------------------------\n ");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                         Day8_LineComparisionProblems.UC1 uc1 = new Day8_LineComparisionProblems.UC1();
                        uc1.LengthOfLine(X1, X2, Y1, Y2);
                        break;
                    case 2:
                        UC2 uc2 = new UC2();
                        uc2.Equals(X2, X1, Y1, Y2);
                        break;
                    case 3:
                        UC3 uc3 = new UC3();
                        uc3.Comparision(X1, X2, Y1, Y2);
                        break;
                    case 4:
                        UC4 uc4 = new UC4();
                        uc4.Comparision1(X1, X2, Y1, Y2);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
