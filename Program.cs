// Console.WriteLine(), 
// Console.ReadLine(),
// while loop

using System;
namespace Mad_Libs
{
    class Mad_Libs
    {
        static void General(string[] args)
        {
            Console.WriteLine("Welcome to Mad Libs!");
            Console.WriteLine("Please enter a noun:");
            string noun = Console.ReadLine();
            Console.WriteLine("This is a story about: " + noun);

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            Console.WriteLine(luckyNumbers[1]);
            luckyNumbers[1] = 9;
            Console.WriteLine(luckyNumbers[1]);

            Console.Write("This will be your [1] number from now on: ");
            string number_one = Console.ReadLine();

            while (!int.TryParse(number_one, out _)) {
                Console.WriteLine("Please enter a valid number:");
                number_one = Console.ReadLine();
            }

            int number_one_int = Int32.Parse(number_one);
            luckyNumbers[1] = number_one_int;

            Console.WriteLine("The new [1] number is: " + luckyNumbers[1]);
            Console.Read();
        }
        

    }
}
