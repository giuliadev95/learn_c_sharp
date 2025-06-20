using System;

namespace For_Loops {
    class Program
    {
        static void non_Main(string[] args)
        {
            int[] lucky_numbers = { 4, 45, 100, 400 };

            for (int i = 0; i <= lucky_numbers.Length; i ++)
            {
                if (i < 2)
               { Console.WriteLine(i); }
            }
        }

    }
}
