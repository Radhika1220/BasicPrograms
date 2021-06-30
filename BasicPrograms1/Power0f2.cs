using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    /// <summary>
    /// P3-Finding the power of a number
    /// </summary>
    class Power0f2
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number to find power");
            int num = Convert.ToInt32(Console.ReadLine());
            FindPower(num);
        }
        private static void FindPower(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                double power = Math.Pow(2, i);
                Console.WriteLine("2^{0} is {1}",i,power);
            }

        }
    }
}
