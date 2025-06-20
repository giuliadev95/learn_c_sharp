using System;

namespace Exponent_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Get_pow(3, 2));
            Console.ReadLine();
        }

        static int Get_pow(int base_num, int pow_num)
        {
            int result = 1;

            for (int i = 0; i < pow_num; i++)
            {
                result = result * base_num;
            }
            return result;
        }
    }
}