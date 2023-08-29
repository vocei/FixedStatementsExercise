using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(1, 1001);
            int userInput;
            var counter = 0;

            do
            {

                Console.WriteLine("Guess my favorite number between 1 - 1000!");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");

                }

                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it, are you a wizard!?");
                }

                counter++;

                Console.WriteLine($"You have guessed {counter} times");

            } while (userInput != favNumber);

        }

    }
}





