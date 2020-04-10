using System;

namespace FactorialLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int i; 
            
            string userInput = "yes";

            Console.WriteLine("Welcome to the Factorial Calculator!");


            while(userInput == "yes")
            {
              
                Console.WriteLine("\nEnter an integer that's greater than 0 but less than 10");
                number = int.Parse(Console.ReadLine());

                long factorial = 1;//had to initialize inside while loop or else program would not set factorial back to 1 when program runs again.

                if (number > 0 && number <= 10)
                {
                    for (i = 1; i <= number; i++)
                    {
                        factorial = (factorial * i);
                        
                    }
                    
                    Console.WriteLine("\nThe factorial of " + number + " is " + factorial);
                    
                    Console.WriteLine("\nDo you want to enter another number? Yes/No");
                    userInput = Console.ReadLine().ToLower();

                   if (userInput == "no")
                    {
                        Console.WriteLine("\nHave a great day!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("You entered an invalid number");
                }
            }
            Console.ReadKey();
        }
    }
}
