using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    /// <summary>
    /// P4-Calculate the harmonic number using the formula
    /// </summary>
    class HarmonicNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter a number");
            int harmonicNumber = Convert.ToInt32(Console.ReadLine());
            FindingNthHarmonicNum(harmonicNumber);
        }
        private static void FindingNthHarmonicNum(int harmonicNumber)
        {
            double sum = 0.0;
            for(int i=1;i<=harmonicNumber;i++)
            {
                sum += 1 / (float)i;
            }
            
            Console.WriteLine("Nth value of Harmonic number is {0}", Math.Round(sum,2));
        }
    }
}
