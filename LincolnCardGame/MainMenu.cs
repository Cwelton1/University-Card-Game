using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class MainMenu : Run
    {
        int menuChoice = 0;
        private void UserInput()
        {
            string A;
            Console.WriteLine("===============================================" +
                "\n|     Would you like to play Lincoln?         |\n|              1. for Play                    |\n|              2. for tutorial                |\n|              3. for Credits                 |\n|              3. for quit                    |" +
                "\n===============================================");

            while (menuChoice < 1 || menuChoice > 4)
            {
                Console.Write("User Input : ");
                A = Console.ReadLine();
                Console.Write("\n");
                try // throws an exception if it fails to tryparse
                {
                    if (Int32.TryParse(A, out menuChoice))
                    {
                        Menu();
                    }
                    else
                    {
                        throw new InputException();    
                    }
                }
                catch (Exception) //catches the exception and outputs an error messege
                {
                    menuChoice = 0;
                    Console.WriteLine("Please enter Either 1, 2, 3 or 4");
                }

            }
        }

        private void Menu()
        {
            switch (menuChoice)
            {
                case 1:
                    AI gameRunner = new AI();

                    gameRunner.run();

                    break;
                case 2:
                    Tutorial tutorialRunner = new Tutorial();

                    tutorialRunner.run();
                    break;
                case 3:
                    Credits creditsRunner = new Credits();

                    creditsRunner.run();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        public void run()
        {
            UserInput();
        }
    }
}
