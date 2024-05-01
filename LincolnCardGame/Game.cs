using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class Game : Hand
    {
        //Global variables used throughout the class
        protected int upperbound = 10;
        //Global variables used throughout the class

        protected void generateHand()
        {
            Hand hand = new Hand(); //instantiates the hand class
            hand.GetHand(PlayerHand, AIHand, PlayerHandSuit, AiHandSuit, DrawGame);
        }

        protected virtual void cardSelect() //dynamic polymorphism
        {
            Console.WriteLine("you should not see this text"); // this method will never run therefore you should never see this output
        }

        protected void PlayAgain()
        {
            int userInput = 0;
            Console.WriteLine("Would you like to play again?\n 1. for Yes \n 2. for no  ");
            Console.Write("User Input : ");
            string A = Console.ReadLine();

            if (Int32.TryParse(A, out userInput))
            {
                if (userInput == 1)
                {
                    Console.Clear();
                    MainMenu menuBot = new MainMenu();
                    menuBot.run();
                }
                else if (userInput == 2)
                {
                    userInput = 0;
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Please enter Either 1 or 2 ");
            }

        }
    }
}
