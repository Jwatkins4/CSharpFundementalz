using System;

namespace _04_SwitchCases.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated.");
                    break;
                    
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still Working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("ITS THE WEEKEND!!!");
                    break;

            }
            
            Console.WriteLine("1-5 How are you feeling?");
            string feeling = Console.ReadLine();

            switch (feeling)
            {
                case "1":
                case "0":
                    Console.WriteLine("Thats not good");
                    break;
                case "2":
                case "2.5":
                    Console.WriteLine("This is ok");
                    break;
                case "3":
                case "3.5":
                    Console.WriteLine("Not Bad");
                    break;
                case "4":
                    Console.WriteLine("Oh thats Great");
                    break;
                case "5":
                    Console.WriteLine("Oh this is even better");
                    break;
                default:
                    Console.WriteLine("It looks like you entered an invalid response");
                    break;

            }

            // Challenge
            // Ask the user how theyre feeling on a scale of 1-5. Capture their input and run it through a switch statement and output diffferent reponse for each value adn if they respond out of range let them know. 
            Console.ReadKey();

        }

         
    }
}
