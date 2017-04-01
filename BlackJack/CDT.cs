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

        public Card()
        {
            
        }

        public Card(int cardValue, string suit, int card)
        {
            this.cardValue = cardValue;
            this.suit = suit;
            this.dealt = false;
            this.card = card;
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
