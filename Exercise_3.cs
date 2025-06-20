// Main method and Non-main called method
// is , is not check operators
// &&
// ||

using System;


    public class Program
    {
        static void non_Main(string[] args)
        {
            Say_hi("Paola", 23);
            Is_male("Martino");
            Math();
            Console.ReadLine();
        }

        static void Say_hi(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age}");

        }

        static int Math() // A non void method that returns an integer. It's "void" only if it doesn't return anything with the "return" keyword.
        {
            Console.WriteLine("Enter a number");
            string number_one = Console.ReadLine();

            while (!int.TryParse(number_one, out _))
            {
                Console.WriteLine("Please enter a valid number:");
                number_one = Console.ReadLine();
            }

            int number_one_int = Int32.Parse(number_one);
            Console.WriteLine($"Your number is: {number_one_int}");
            return number_one_int;
        }

        static void Is_male(string name)
        {
            bool is_male = true;
            string f_name = "Antonio";
            if (is_male || f_name is not string)
            {
                Console.WriteLine($"True: {name} is a male.");
            } else
            {
                Console.WriteLine($"False: {name} isn't a male.");
            }
        }
    }
