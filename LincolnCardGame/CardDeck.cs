using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class CardDeck
    {
        //private variables 
        private List<Card> _deck = new List<Card>();
        //private variables 

        //getters and setters 
        public List<Card> deck
        {
            get { return _deck; }
            set { _deck = value; }
        }
        //getters and setters 

        // This method builds the deck and then calls the shuffle method
        protected void BuildDeck() // This has a protection level of protected so only inherited members can access it
        {

            for (int suitNumber = 0; suitNumber < 4; suitNumber++) // makes sure there is only one suit 
            {
                for (int valueNumber = 0; valueNumber < 13; valueNumber++) // gives each value 13 cards 
                {
                    Card card = new Card(suitNumber, valueNumber);
                    deck.Add(card);// adds cards to deck list 
                }
            }
            Shuffle(); // calls shuffle
        }
        // This method builds the deck and then calls the shuffle nmethod

        // methods thats shuffles the deck
        private void Shuffle()
        {
            Random rand = new Random();
            Card temp;

            for (int shuffleTime = 0; shuffleTime < 1000; shuffleTime++)
            {
                for (int i = 0; i < 52; i++)
                {
                    int CardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[CardIndex];
                    deck[CardIndex] = temp;

                }

            }
        }
        // methods thats shuffles the deck
    }
}
