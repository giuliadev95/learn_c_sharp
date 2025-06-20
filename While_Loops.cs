// While Loop

using System;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while ( index <= 5 )
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();
        }
    }
}
