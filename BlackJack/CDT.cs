using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        private int cardValue;
        private string suit;
        private int card;
        private bool dealt;
        private int pointValue;
        private int zeroTo10Value;

        public Card()
        {
            
        }

        public Card(int cardValue, string suit, int card)
        {
            this.cardValue = cardValue;
            this.suit = suit;
            this.dealt = false;
            this.card = card;
            this.pointValue = (cardValue % 13) + 1;

        }

        public int CardValue
        {
            get { return cardValue; }
            private set { }
        }

        public string Suit
        {
            get { return suit; }
            private set { }
        }
        public int myCard
        {
            get { return card; }
            private set { }
        }

        public bool Dealt
        {
            get { return dealt; }
            set { dealt = value; }
        }

        public int PointValue
        {
            get { return pointValue; }
        }



    }

      public class Hand
    {
        private List<Card> Cards;

        public Hand()
        {

        }

        public Hand(Card card)
        {
            this.Cards.Add(card);
        }


        public void AddCard(List<Card> myHand, Card myCard)
        {
            myHand.Add(myCard);
        }







    }
}
