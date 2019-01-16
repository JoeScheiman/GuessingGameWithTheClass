using System;

namespace GuessingGameWithClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Welcome to Joe's Guessing Game!  \n\nGuess a number between 1 and 10 (or enter '0' for HELP): ");
            

            String userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess + "\n\n");

            if (userGuess.Equals("0"))
            {
                Console.WriteLine("===== INSTRUCTIONS =====");
                Console.WriteLine("Guess a number between 1 and 10.");
                Console.WriteLine("Hit enter to submit your guess.");

                userGuess = Console.ReadLine();
            }


            //int k = Convert.ToInt32(userGuess);
            
            
        }
        /*static void test()
        {
            int k = 20;
            Console.WriteLine(k.ToString());
            int b = 5;
            for (int i = 0; i < 20; i++)
            {
                int a = i + 15;
                b = k+i;
                Console.WriteLine(k.ToString());
            }
            Console.WriteLine(a)
            Console.WriteLine(k.ToString());
        }*/
    }
}
