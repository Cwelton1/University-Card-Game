using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class Player : Game
    {
        protected int playerAnswer = 0;
        protected int card1 = 0;
        protected int card2 = 0;
        private int maxnum = 9;
        private int previousInput = 10;
        private   string a;

        protected void UserChoice()
        {

            //method specific variables
            int i = 0;
            int c = 0;
            //variables

            Console.WriteLine($"What card would you like to use, press the number corresponding to the card");
            Console.WriteLine("your current hand is \n");
            foreach (object o in PlayerHand) //this method loops outputting the first part of each card. this is all thats needed for the game but you will be able to see your exact hand when the game launches
            {
                Console.WriteLine($"{c}. {o}");
                c++;
            }

            do
            {
                try
                {
                    if (Int32.TryParse(Console.ReadLine(), out i)) //this stops the user from entering letters and special characters
                    {
                        
                    }
                    else if (previousInput == i)
                    {
                        Console.WriteLine("you already used this card");
                    }
                    else if (i < 0 || i > 9)
                    {
                        Console.WriteLine("Please enter a number between 0 and 9"); // this is a helpful line of dialog that helps the user when they go wrong
                    }
                    else
                    {
                        throw new InputException();
                    }
                }
                catch (Exception)
                {
                    i = 0;
                    Console.WriteLine("Please enter a number between 0 and 9");
                }
            } while (previousInput == i);

            conversion(i);
        }

        private void conversion(int i)
        {
            //method specific variables
            int temp = 0;
            int removeVariable = 0;
            //variables

            //converts the string from the list to a temporary variable
            if (PlayerHand[i] == "Ace")
            {
                temp = 14;
            }
            else if (PlayerHand[i] == "Two")
            {
                temp = 2;
            }
            else if (PlayerHand[i] == "Three")
            {
                temp = 3;
            }
            else if (PlayerHand[i] == "Four")
            {
                temp = 4;
            }
            else if (PlayerHand[i] == "Five")
            {
                temp = 5;
            }
            else if (PlayerHand[i] == "Six")
            {
                temp = 6;
            }
            else if (PlayerHand[i] == "Seven")
            {
                temp = 7;
            }
            else if (PlayerHand[i] == "Eight")
            {
                temp = 8;
            }
            else if (PlayerHand[i] == "Nine")
            {
                temp = 9;
            }
            else if (PlayerHand[i] == "Ten")
            {
                temp = 10;
            }
            else if (PlayerHand[i] == "Jack")
            {
                temp = 11;
            }
            else if (PlayerHand[i] == "Queen")
            {
                temp = 12;
            }
            else if (PlayerHand[i] == "King")
            {
                temp = 13;
            }
            //converts the string from the list to a temporary variable

            // assigns card one or card two with a value stored in temp
            if (card1 == 0)
            {
                previousInput = i;
                card1 = temp;
                i = 0;
                removeVariable = i;
                Console.WriteLine(card1);

                UserChoice();
            }
            else if (card2 == 0)
            {
                card2 = temp;
                Console.WriteLine(card2);

                PlayerHand.RemoveAt(removeVariable); // removes the players previous choice
                PlayerHand.RemoveAt(i);
                
                calculation(card1, card2);
            }
            // assigns card one or card two with a value stored in temp
        }

        public void calculation(int card1, int card2)
        {
            //caclulates an answer.
            playerAnswer = card1 + card2;

            //resets the variables to prevent the code ignoring a user input

            //resets the variables to prevent the code ignoring a user input

            Console.WriteLine("The Player's score was " + playerAnswer); //outputs your score
        }

    }
}
