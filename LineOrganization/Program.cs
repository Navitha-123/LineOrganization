﻿namespace LineOrganization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option\n 1.lengths \t 2. equals \t 3. compare");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Length.double length(double x1, double x2, double y1, double y2);
                    LengthTwoLines length1 = new LengthTwoLines();
                    Console.WriteLine(length1.length(45, 23, 40, 20));
                    break;
                     case 2:
                    EqualsLength.CheckLength(56, 78, 45, 34, 79, 67, 34, 25);
                     break;
                 /*case 3:
                     CompareLength.CompareTo(46, 89);
                     break;
                     default:
                     Console.WriteLine("wrong length");
                     break;
             }
                    */



            }
        }
    }
}