using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            //for(int year = 100; year <= 4000; year += 100)
            //{
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    Console.WriteLine("{0}년은 윤년", year);
                else
                    Console.WriteLine("{0)년은 평년", year);
                if (DateTime.IsLeapYear(year))
                    Console.WriteLine("{0}년은 윤년",year);
                else
                    Console.WriteLine("{0}년은 평년", year);
            //}
        }
    }
}