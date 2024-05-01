using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class Hand : CardDeck
    {
        //private varibles 
        private int _deckPointer = 0;

            // temporary Varuables
        public string playerNewValue = "";
        public string playerNewSuit = "";
        public string aiNewSuit = "";
        public string aiNewValue = "";
        public string NewDrawGame = "";
            //temporary variables

            // list variables used to store card values and suits 
        private List<string> _playerHand = new List<string>();
        private List<string> _aiHand = new List<string>();
        private List<string> _playerHandSuit = new List<string>();
        private List<string> _aiHandSuit = new List<string>();
        private List<string> _DrawGame = new List<string>();
            // list variables used to store card values and suits 
        //private varibles 

        //getters and setters 
        public List<string> PlayerHand
        {
            get { return _playerHand; }
            set { _playerHand = value; }
        }

        public List<string> AIHand
        {
            get { return _aiHand; }
            set { _aiHand = value; }
        }
        public List<string> PlayerHandSuit
        {
            get { return _playerHandSuit; }
            set { _playerHandSuit = value; }
        }
        public List<string> AiHandSuit
        {
            get { return _aiHandSuit; }
            set { _aiHandSuit = value; }
        }
        public List<string> DrawGame
        {
            get { return _DrawGame; }
            set { _DrawGame = value; }
        }
        //getters and setters 



        // mehtod used to make the computers hand, humand hand and then the rest for higher or lower.
        public void GetHand(List<string> PlayerHand, List<string> AIHand, List<string> PlayerHandSuit, List<string> AiHandSuit, List<string> DrawGame)
        {
            BuildDeck(); //this calls the BuildDeck method from the card Deck class 

            // Start of the code for the players hand
            for (int i = 0; i < 10; i++) // This sets the players max hand size to 10
            {
                string suit = deck[_deckPointer].suit;
                string value = deck[_deckPointer].value;

                playerNewValue = value;
                playerNewSuit = suit;
                PlayerHand.Add(playerNewValue);
                PlayerHandSuit.Add(playerNewSuit);

                Console.WriteLine($"{i + 1}) It's the {value} of {suit}\n"); // outputs 
                _deckPointer++;

            }
            // end of the code for the players hand

            // Start of the AI Code
            for (int i = 10; i < 20; i++)// makes the hand size of 10 
            {

                string suit = deck[_deckPointer].suit;
                string value = deck[_deckPointer].value;

                aiNewValue = value;
                aiNewSuit = suit;
                AIHand.Add(aiNewValue);
                AiHandSuit.Add(aiNewSuit);
                _deckPointer++;

            }
            // end of the computer hand

            // rest of hand 
            for (int i = 20; i < 51; i++)// the rest of the had
            {

                string suit = deck[_deckPointer].suit;
                string value = deck[_deckPointer].value;

                NewDrawGame = value;
                DrawGame.Add(NewDrawGame);
                _deckPointer++;

            }
            // rest of hand 


        }
        // mehtod used to make the computers hand, humand hand and then the rest for higher or lower.

    }
}

