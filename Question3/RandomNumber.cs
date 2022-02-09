using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W3.Question3
{
    public class RandomNumber
    {
        public void randomNumber()
        {
            Console.WriteLine("Random Number Generator App");
            Random randomGenerator = new Random();
            int randomNum = randomGenerator.Next(1, 11);
            Console.WriteLine("Enter a number between 1 and 10");
            bool validNumber = int.TryParse(Console.ReadLine(), out int userGuess);
            if (!validNumber)
            {
                Console.WriteLine("Please, enter a valid number!");
                randomNumber();
            }
            else if (randomNum == userGuess)
            {
                Console.WriteLine($"You guessed it right! Your number: {userGuess}, system number: {randomNum}");
            }
            else if (userGuess < randomNum)
            {
                Console.WriteLine("Your number is too low.");
                //Console.WriteLine($"Random number was: {randomNumber}");
                randomNumber();
            }
            else if (userGuess > randomNum)
            {
                Console.WriteLine("Your number is too high.");
                //Console.WriteLine($"Random number was: {randomNumber}");
                randomNumber();
            }
        }
    }
}
