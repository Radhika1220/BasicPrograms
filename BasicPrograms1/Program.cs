using System;

namespace BasicPrograms1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option");
            Console.WriteLine("1.Flip Coin");
            Console.WriteLine("2.Leap Year Or Not");
            Console.WriteLine("3.Power Of 2");
            Console.WriteLine("4.Harmonic Number");
            Console.WriteLine("5.Prime Factors");
            Console.WriteLine("6.Finding Quotient And Remainder");
            Console.WriteLine("7.Swapping of two numbers");
            Console.WriteLine("8.Even Or Odd");
            Console.WriteLine("9.Vowel or Consonant");
            Console.WriteLine("10.Largest Among Three Numbers");
            Console.WriteLine("Select a option");

            switch(Console.ReadLine())
            {
                case "1":
                    FlipCoin.ReadInput();
                    break;
                case "2":
                    LeapYear.ReadInput();
                    break;
                case "3":
                    Power0f2.ReadInput();
                    break;
                case "4":
                    HarmonicNumber.ReadInput();
                    break;
                case "5":
                    Factors.ReadInput();
                    break;
                case "6":
                    QuotientAndRemainder.ReadInput();
                    break;
                case "7":
                    SwapTwoNum.ReadInput();
                    break;
                case "8":
                    NumIsEvenOrOdd.ReadInput();
                    break;
                case "9":
                    AlphabetIsVowelOrCons.ReadInput();
                    break;
                case "10":
                    LargestAmongThreeNum.ReadInput();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}
