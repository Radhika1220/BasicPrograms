using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    /// <summary>
    /// p7-Swapping of two numbers without using temp variable
    /// </summary>
    class SwapTwoNum
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the first num");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first num");
            int second = Convert.ToInt32(Console.ReadLine());
            swapping(first, second);
        }
        private static void swapping(int first,int second)
        {
            Console.WriteLine("Before Swapping {0} and {1}", first, second);
            first = first * second;
            second = first / second;
            first = first / second;
            Console.WriteLine("After Swapping {0} and {1}", first, second);
        }

    }
}
