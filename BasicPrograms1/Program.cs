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



            }
        }
    }
}
