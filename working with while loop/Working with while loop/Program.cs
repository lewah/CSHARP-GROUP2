// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            // while to check condition and to return back to the main menu after clicking enter key
            // while (displayMenu == true)
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            // Console.Clear(); clears window 
            Console.Clear();

            Console.WriteLine("Choose an option");
            Console.WriteLine("1.Option 1");
            Console.WriteLine("2.Option 2");
            Console.WriteLine("3.Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumber();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                //here we completely exit 
                return false;
            }
            else
            {
                // here we go back to the menu if the dont pick the options documented 
                return true;
            }
        }
        private static void PrintNumber()
        {
            // Console.Clear(); clears window 
            Console.Clear();

            Console.WriteLine("Print Number:");
            Console.WriteLine("Type Number : ");
            //Parse - convert to 32 bit
            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            //while loop
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();

        }
        private static void GuessingGame()
        {
            // Console.Clear(); clears window 
            Console.Clear();

            Console.WriteLine("Guess Number:");

            Random myRandom = new Random();
            //int random = myRandom.Next(min, max);
            int random = myRandom.Next(1, 10);

            int guesses = 0;
            bool incorrect = true;

            // Do while loop - repeat the loop as long as the condition is true
            do
            {
                Console.WriteLine("Guess a Number between 1 and 10: ");
                string resultRandom = Console.ReadLine();
                guesses ++;

                if (resultRandom == random.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("wrong");
                }

            }
            //while incorrect = TRUE exit
            while (incorrect);
            {
                Console.WriteLine("correct! it took you {0} guesses", guesses);
            }
            

            Console.ReadLine();
        }
    }
}