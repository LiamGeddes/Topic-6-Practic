using System.Reflection.PortableExecutable;

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

        }
        //Starting Random Numbers 


               








            

            

            

            
        }
    }
}
