using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms1
{
    class AlphabetIsVowelOrCons
    {
        /// <summary>
        /// P9-Whether the Alphabet is voewl or consonant
        /// </summary>
        public static void ReadInput()
        {
            Console.WriteLine("Enter a alphabet");
            char alphabet = Convert.ToChar(Console.ReadLine());
            VowelOrConsonants(alphabet);
        }
        private static void VowelOrConsonants(char alphabet)
        {
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet =='u' )
            {
                Console.WriteLine("{0} is a vowel", alphabet);
            }
            else
            {
                Console.WriteLine("{0} is a Consonant", alphabet);
            }
        }

        }
    }

