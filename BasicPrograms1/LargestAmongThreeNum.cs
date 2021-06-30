using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1

{
    /// <summary>
    /// P10-Finding out the largest number among three numbers
    /// </summary>
    class LargestAmongThreeNum
    {
        public static void ReadInput() 
        {
            Console.WriteLine("Enter three numbers");
            int[] numArray = new int[4];
            for (int i = 1; i <= 3; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numArray[i] = num;
            }
                if (numArray[1] > numArray[2] && numArray[1] > numArray[3])
                {
                    Console.WriteLine("{0} is largest", numArray[1]);
                }
               else if(numArray[2]>numArray[1] && numArray[2]>numArray[3])
                {
                    Console.WriteLine("{0} is largest", numArray[2]);
                }
                else
                {
                    Console.WriteLine("{0} is largest", numArray[3]);
                }

            }
    }
    }

