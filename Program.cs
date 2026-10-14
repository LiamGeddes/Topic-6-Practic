using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Topic_6_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator;
            generator = new Random();

            int choice;

            Console.WriteLine("Choose a program:");
            Console.WriteLine("1. Random Numbers");
            Console.WriteLine("2. Guessing Game");
            Console.WriteLine("3. Roll The Dice");
            Console.WriteLine("4. Magic 8 Ball");
            Console.Write("Enter Your Choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                RandomNumbers();
            }
            else if (choice == 2)
            {
                GuessingGame();
            }
            else if (choice == 3)
            {
                RollDice();
            }
            else if (choice == 4)
            {
                Magic8Ball();
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }

            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }

        static void RandomNumbers()
        {
            Random generator = new Random();
            Console.Write("Enter the minimum number: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum number: ");
            int max = int.Parse(Console.ReadLine());

            if (min<= max)
            {
                int number = generator.Next(min, max + 1);
                Console.WriteLine("Random number: " + number);
            }
            else
            {
                Console.WriteLine("The minimum must be smaller than the maximum");
            }   
        }
        static void RollDice()
        {
            Random generator = new Random();

            int dice1 = generator.Next(1, 7);
            int dice2 = generator.Next(1, 7);

            Console.WriteLine("First dice: " + dice1);
            Console.WriteLine("Second dice: " + dice2);
            Console.WriteLine("Total: " + (dice1 + dice2));
        }
        static void GuessingGame()
        {
            Random generator = new Random();

            int number = generator.Next(1, 11);
            int guess = 0;

            Console.WriteLine("Guess a number from 1 to 10!");
            while (guess != number)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Correct!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }

        }
        static void Magic8Ball()
        {
            Random generator = new Random();
            int number;
            string question;

            

            Console.Write("Ask a yes or no question:  ");
            question = Console.ReadLine();

            Console.WriteLine("The Magic 8 Ball is thinking...");
            Thread.Sleep(1000);

            number = generator.Next(6);
            if (number == 0)
                Console.WriteLine("Yes, definitely!");
            else if (number == 1)
                Console.WriteLine("Ask again later.");
            else if (number == 2)
                Console.WriteLine("No way!");
            else if (number == 3)
                Console.WriteLine("It is possible.");
            else if (number == 4)
                Console.WriteLine("I Think so!");
            else
                Console.WriteLine("I cannot predict that.");


            
        }

    }
}
