using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class AI : Player,Run
    {
        //variables
        private int aiCard1 = 0;
        private int aiCard2 = 0;
        private int AIAnswer = 0;
        private int playerscore = 0;
        private int AIscore = 0;
        private int numofrounds = 0;
        private int scorePoints = 1;
        Random rnd = new Random();
        //variables

        protected override void cardSelect()
            {
                //method specific variables

                // variables

                int aiChoice = rnd.Next(0, 9); // generates a random number that the AI uses as its card
                upperbound = upperbound - 1; //upperbound stops the user or AI entering a value that can no longer be accessed

                AIHandSelection(aiChoice);
            }

            private void AIHandSelection(int aiChoice)
            {
                //method specific variables
                int A = 0;
                //variables 

                //this switch case statement takes the AI Number and assigns i, i is then used to find a position in the list
                switch (aiChoice)
                {
                    case 1:
                        A = 0;
                        AIConversion(A);
                        break;
                    case 2:
                        A = 1;
                        AIConversion(A);
                        break;
                    case 3:
                        A = 2;
                        AIConversion(A);
                        break;
                    case 4:
                        A = 3;
                        AIConversion(A);
                        break;
                    case 5:
                        A = 4;
                        AIConversion(A);
                        break;
                    case 6:
                        A = 5;
                        AIConversion(A);
                        break;
                    case 7:
                        A = 6;
                        AIConversion(A);
                        break;
                    case 8:
                        A = 7;
                        AIConversion(A);
                        break;
                    case 9:
                        A = 8;
                        AIConversion(A);
                        break;
                    case 10:
                        A = 9;
                        AIConversion(A);
                        break;
                    default:
                        break;
                }
                //this switch case statement takes the AI number and assigns i, i is then used to find a position in the list
            }

            private void AIConversion(int i)
            {
                int temp = 0;

                //converts the string from the list to a temporary variable
                if (AIHand[i] == "Ace")
                {
                    temp = 14;
                }
                else if (AIHand[i] == "Two")
                {
                    temp = 2;
                }
                else if (AIHand[i] == "Three")
                {
                    temp = 3;
                }
                else if (AIHand[i] == "Four")
                {
                    temp = 4;
                }
                else if (AIHand[i] == "Five")
                {
                    temp = 5;
                }
                else if (AIHand[i] == "Six")
                {
                    temp = 6;
                }
                else if (AIHand[i] == "Seven")
                {
                    temp = 7;
                }
                else if (AIHand[i] == "Eight")
                {
                    temp = 8;
                }
                else if (AIHand[i] == "Nine")
                {
                    temp = 9;
                }
                else if (AIHand[i] == "Ten")
                {
                    temp = 10;
                }
                else if (AIHand[i] == "Jack")
                {
                    temp = 11;
                }
                else if (AIHand[i] == "Queen")
                {
                    temp = 12;
                }
                else if (AIHand[i] == "King")
                {
                    temp = 13;
                }
                //converts the string from the list to a temporary variable

                // assigns card one or card two with a value stored in temp
                if (aiCard1 == 0)
                {
                    aiCard1 = temp;
                    i = 0;
                cardSelect();
                }
                else if (aiCard2 == 0)
                {
                    aiCard2 = temp;

                calculation(aiCard1, aiCard2);
                }
                // assigns card one or card two with a value stored in temp
            }

            public void calculation(int aiCard1, int AICard2) //static polymorphism
            {
                //works the same as calculation method
                AIAnswer = aiCard1 + aiCard2;

                Console.WriteLine("The AI's score was " + AIAnswer);
                WinnerSelect();
            }

        public void WinnerSelect()
        {
            //compares the answers 
            if (playerAnswer > AIAnswer)
            {
                Console.WriteLine("Player wins this round \n");
                playerscore = playerscore + scorePoints; //adds 1 to the score variable used to count the game 
                scorePoints = 1;
            }
            else if (playerAnswer < AIAnswer)
            {
                Console.WriteLine("AI wins this round \n");
                AIscore = AIscore + scorePoints;
                scorePoints = 1;
            }
            else
            {
                Console.WriteLine(" this round ends in a Tie \n");
                scorePoints = scorePoints + 1;
            }
            //compares the answer

            numofrounds = playerscore + AIscore;


            Console.WriteLine($"you just finished round {numofrounds} \n you have won {playerscore} round/s \n your oponent has won {AIscore} round/s");
            //checks how many rounds are left and loops the game accordingly.
            if (numofrounds < 5)
            {
                card1 = 0;
                card2 = 0;
                UserChoice();
                cardSelect();
                calculation(card1, card2);
                calculation(aiCard1, aiCard2);
            }
            else if (numofrounds == 5)
            {
                if (playerscore > AIscore)
                {
                    Console.WriteLine("Player wins \n");
                }
                else if (AIscore > playerscore)
                {
                    Console.WriteLine("AI wins \n");
                }
                else
                {
                    Console.WriteLine("somethings gone seriously wrong you tied \n");
                }
            }
            //checks how many rounds are left and loops the game accordingly.

           
        }
        public void run()
        {
            generateHand();
            UserChoice();
            cardSelect();
            calculation(card1,card2);
            calculation(aiCard1, aiCard2);
            PlayAgain();
        }
    }
}
