using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class Credits : Run
    {
        //This page is here just to make the code more professional and adds nothing to the final game
        private void Names()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("A game By Chris Welton \n");
            Console.WriteLine("Based on rules by The University of Lincoln");
        }

        private void Thanks()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Thanks for Playing");
        }

        private void Smile()
        {
            Console.WriteLine("\n");
            Console.WriteLine(":)");
        }

        private void exit()
        {
            int userInput = 0;
            Console.WriteLine("Would you like to clear the console and return to main menu?\n 1. for Yes \n you can return to this page from the main menu ");
            Console.Write("User Input : ");
            string A = Console.ReadLine();
            try
            {
                if (Int32.TryParse(A, out userInput))
                {
                    if (userInput == 1)
                    {
                        Console.Clear();
                        MainMenu menuBot = new MainMenu();
                        menuBot.run();
                    }

                    else
                    {

                        throw new InputException();
                    }
                }
            }
            catch (Exception)
            {
                userInput = 0;
                Console.WriteLine("Please enter Either 1 or 2 ");
            }
        }
        public void run()
        {
            Names();
            Thanks();
            Smile();
        }
    }
}
