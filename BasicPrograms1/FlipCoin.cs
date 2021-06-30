using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            
            Console.WriteLine("Number of times to flip the coin");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());
            countOfHeadAndTail(noOfTimes);
            
        }

        private static void countOfHeadAndTail(int noOfTimes)
        {
            Random random = new Random();
            int tail = 0, head = 0;

            for (int i = 1; i <= noOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                {
                    if (randomValue < 0.5)
                    {
                        tail++;
                    }
                    else
                    {
                        head++;
                    }
                }
            }
            Console.WriteLine("Number of times tails occured " + tail + " out of " + noOfTimes);
            Console.WriteLine("Number of times tails occured " + head + " out of " + noOfTimes);
            double tailPercent = (double)tail / noOfTimes * 100;
            double headPercent = (double)head / noOfTimes * 100;
            Console.WriteLine("Tail Percentage is " + tailPercent);
            Console.WriteLine("Head Percentage is " + headPercent);

        }

    }
}

    

