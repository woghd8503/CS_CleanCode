using System;

namespace CodingStudy
{
    class CodingStudy
    {
        static void Main()
        {
            bool isLeapYear = false;
            int input = int.Parse(Console.ReadLine());

            if ((input % 4 == 0 && input % 100 != 0) || (input % 100 == 0 && input % 400 != 0) || input % 400 == 0)
                isLeapYear = true;

            if (isLeapYear)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }

}
