// A program that tells you in how any days your application is going to be view by the HRs

using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace Candidature
{
    class Program
    {
        static int Main ()
        {
            Console.Write("Your application number: ");
            string application_number = Console.ReadLine();
            while (!int.TryParse(application_number, out _))
            {
               Console.WriteLine("Please enter a valid application number: ");
               application_number = Console.ReadLine();
            }

            int application_number_int = Int32.Parse(application_number);
            Console.WriteLine($"Your number is: {application_number_int}");

            // ---------------------------------------- 
            if( application_number_int < 50 )
            {
                Console.WriteLine("Thank you for submitting your application, we'll get in touch with you within a week.") ;
            } else if (application_number_int >= 50 && application_number_int < 100)
            {
                Console.WriteLine("Thank you for submitting your application, we'll get in touch with you next week");
            }
            else if (application_number_int >= 100 && application_number_int < 200)
            {
                Console.WriteLine("Thank you for submitting your application, we'll get in touch with you in 2 weeks");
            }
            else if(application_number_int >= 200)
            {
                Console.WriteLine("Thank you for submitting your application, we will contact you as soon as we review your application.");
            }
            Console.Read();
            return application_number_int;
        }      
    }
}


