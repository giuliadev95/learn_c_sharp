// While Loop

using System;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void NonMain(string[] args)
        {
            // While Loop
            int index = 5;
            while ( index <= 5 )
            {
                Console.WriteLine(index);
                index++;
            }

            // Do While Loop
            int six_index = 6;
            do
            {
                Console.WriteLine(six_index);
                six_index++;
            }
            while (six_index <= 5);

            Console.ReadLine();
        }
    }
}
