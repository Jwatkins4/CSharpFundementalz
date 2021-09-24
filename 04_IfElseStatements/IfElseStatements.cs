using System;

namespace _04_IfElseStatements
{
    class IfElseStatements
    {
        static void Main(string[] args)
        {
            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16)
            {
                Console.WriteLine("Student spent less than 16 hours studying.");
                Console.WriteLine("Another time.");
            }

            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Woo Hoo! You are productive");
            }
            else
            {
                Console.WriteLine("Got to work now!");
            }

            Console.WriteLine("How old are you");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if(age > 17)
            {
                Console.WriteLine("Congrats on being an adult!");
             }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("You are a kiddo!");
                }
                else if( age < 0)
                {
                    Console.WriteLine("You are a baby");
                }
                else
                {
                    Console.WriteLine("You are not even born");
                }
            }

            Console.ReadKey();
        }
    }
}
