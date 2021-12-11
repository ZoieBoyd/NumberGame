/*
An interactive number guessing game which takes in the user's input and compares it to a randomised value between 1 and 100. 
The game will continue until the correct number is guessed.
*/
using System;

namespace NumberGame
{
    class Program 
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;

            Random rnd = new Random();
            int number = rnd.Next(min, max + 1);

            int guess = 0;

            Console.WriteLine("Welcome to Number Guesser!\nEnter a value from " + min + " to " + max + " and hit the 'Enter' key to begin guessing.");

            while (guess != number)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have entered in non-numeric characters.");
                    continue;
                }

                // Checks guess against the generated number and displays the appropriate message
                if (guess < min || guess > max)
                {
                    Console.WriteLine("Please Enter a value that is between " + min + " and " + max + " only.");
                }
                else if (guess == number)
                {
                    Console.WriteLine("Congrats! " + number + " was the correct value. You win.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Number is HIGHER than " + guess);
                }
                else if (guess > number)
                {
                    Console.WriteLine("Number is LOWER than " + guess);
                }
            }
        }
    }
}
