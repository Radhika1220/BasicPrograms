using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    /// <summary>
    /// P8-Number is even or odd
    /// </summary>
    class NumIsEvenOrOdd
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number to find even or odd");
            int evenOrOdd = Convert.ToInt32(Console.ReadLine());
            FindEvenOrNot(evenOrOdd);
        }
        private static void FindEvenOrNot(int evenOrOdd)
        {
            if(evenOrOdd%2==0)
            {
                Console.WriteLine("{0} is a Even Number", evenOrOdd);
            }
            else
            {
                Console.WriteLine("{0} is a Odd Number", evenOrOdd);
            }
        }
    }
}
