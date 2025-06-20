// Switch

using System;

namespace tutorial_exercises
{
    public class Switch
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Get_day(4));
            Console.ReadLine();
        }

            static string Get_day(int day_num)
            {
                string day_name;

                switch(day_num)
                {
                    case 0:
                        day_name = "Sunday";
                        break;

                    case 1:
                        day_name = "Monday";
                        break;

                    case 2:
                        day_name = "Wednesday";
                        break;

                    case 3:
                        day_name = "Thursday";
                        break;

                    case 4:
                        day_name = "Friday";
                        break;

                    case 5:
                        day_name = "Saturday";
                        break;
                    case 6:
                        day_name = "Sunday";
                        break;

                    default:
                        day_name = "Invalid day number";
                        break;
                }

                return day_name;
            }
        }

}
