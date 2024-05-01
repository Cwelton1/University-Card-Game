using System;
using System.Collections.Generic;
using System.Text;

namespace LincolnCardGame
{
    class Card
    {
        //global Variables
        private string _suit;
        private string _value;
        private string[] _suitList = { "Hearts", "Clubs", "Spades", "Diamonds" };
        private string[] _valueList = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        //global variables

        //generates lists
        public string suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public string value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string[] suitlist
        {
            get { return _suitList; }
        }

        public String[] valueList
        {
            get { return _valueList;  }
        }

        public Card(int suitNumber, int valueNumber)
        {
            suit = suitlist[suitNumber];
            value = valueList[valueNumber];
        }
        //generates list
    }
}
