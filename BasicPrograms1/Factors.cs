using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    /// <summary>
    /// P5-Prime factors of a number
    /// </summary>
    class Factors
    {
        public static void ReadInput() 
        {
            Console.WriteLine("Enter a number to find factors");
            int num = Convert.ToInt32(Console.ReadLine());
            FindPrimeFactors(num);
         }
        private static void FindPrimeFactors(int num)
        {
            while(num%2==0)
            {
                Console.Write(2 + " ");
                num = num / 2;
            }
            for(int i=3;i*i<=num;i+=2)
            {
                while(num%i==0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if(num>2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
