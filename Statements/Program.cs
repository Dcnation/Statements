using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            //var favNumber = r.Next(1, 10);
            var favNumber = 7;

            Console.WriteLine("Pick a number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is to low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is to high");
            }
            else
            {
                Console.WriteLine("You Guessed it");

            }

            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine(); //evualate a string

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is awesome");
                    break;
                default:
                    Console.WriteLine("I havvent taken that subject yet");
                    break;

            }

        }
    }

}
  

