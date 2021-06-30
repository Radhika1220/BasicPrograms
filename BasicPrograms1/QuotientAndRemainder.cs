using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    /// <summary>
    /// P6-Finding the quotient and remainder
    /// </summary>
    class QuotientAndRemainder
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter a dividend :");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor :");
            int divisor = Convert.ToInt32(Console.ReadLine());
            FindQuoAndRem(dividend, divisor);
                
        }
        private static void FindQuoAndRem(int dividend,int divisor)
        {
            int quo = dividend / divisor;
            int rem = dividend % divisor;
            Console.WriteLine("Quotient of {0} and {1} is {2}", dividend, divisor, quo);
            Console.WriteLine("Remainder of {0} and {1} is {2}", dividend, divisor, rem);
        }
    }
}
