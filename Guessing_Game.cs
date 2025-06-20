using System;

namespace Guessing_game
{
class Program
    {
        static void NotMain(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guess_time = 1;
            while(guess != secretWord && guess_time <3)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guess_time++;
            }
            if (guess == secretWord)
            {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("You loose!");
            }
            Console.ReadLine();
        }

    }
}

