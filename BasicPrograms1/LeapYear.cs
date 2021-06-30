using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    class LeapYear
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number to find leap year");
            int leapYear=Convert.ToInt32(Console.ReadLine());
            if(leapYear<=999)
            {
                Console.WriteLine("Not a valid number to find leap year");
                return;
            }
            FindLeapYearOrNot(leapYear);

        }
        private static  void FindLeapYearOrNot(int leapYear)
        {
            if(((leapYear%4==0) &&(leapYear%100!=0)) || (leapYear%400==0))
            {
                Console.WriteLine("{0} is a leap year", leapYear);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", leapYear);
            }
        }
    }
}
