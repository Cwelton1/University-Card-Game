using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class Tutorial : Run
    {
        //This page is here to make the game easier to understand for players
        private void Title()
        {
            Console.WriteLine("Lincoln Card Game \n");
        }
        private void Rules()
        {
            Console.WriteLine("\n The game starts with 2 players" +
                "\n One player and the other is an AI" +
                "\n A deck of cards is shuffled" +
                "\n Each player is given a hand of 10 cards" +
                "\n each player chooses two cards from their hand" +
                "\n your cards are added up and then whoever has the highest wins");
        }

        private void HowToPlay()
        {
            Console.WriteLine("When the game loads you will have to input a number" +
                "\n your starting numbers are 0,1,2,3,4,5,6,7,8,9" +
                "\n these numbers correlate to the cards in your hand" +
                "\n each subsequent turn you will have one less number you are able to enter" +
                "\n this is becasue your hand decreases in size as the game goes on");
        }

        private void finished()
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
            Title();
            Rules();
            HowToPlay();
            finished(); 
        }
    }
}
