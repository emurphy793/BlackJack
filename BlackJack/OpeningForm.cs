using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class PlayBlackjack : Form
    {
        private List<Card> deck = new List<Card>();
        private List<Card> myHand = new List<Card>();

        public PlayBlackjack()
        {
            InitializeComponent();
            rtbHand1.Text = string.Empty;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string myDeck = string.Empty;

            foreach (Card item in deck)
            {
                myDeck += string.Format("{0} of {1} \n", item.myCard.ToString(), item.Suit);
            }
            rtbOutput.Text = myDeck;
        }

        private void ConstructDeckOfCards(List<Card> deck)
        {
            for (int i = 0; i < 52; i++)
            {
                deck.Add(null);
            }
            for (int i = 0; i <= 12; i++)
            {
                deck[i] = new Card(i, "hearts", i + 1);
                deck[i + 13] = new Card(i + 13, "clubs", i + 1);
                deck[i + 26] = new Card(i + 26, "diamonds", i + 1);
                deck[i + 39] = new Card(i + 39, "spades", i + 1);
            }
        }


        private string GetCardDescription(Card myCard)
        {
            string CardNumber = myCard.CardValue.ToString();

            return string.Format("My Card Is {0} of {1})", CardNumber, myCard.Suit);

        }

        private void DealCard(object sender, EventArgs e)
        {
            Random number = new Random();
            int nextCardIndex = number.Next(0, 52);

            while (deck[nextCardIndex].Dealt)
            {
                nextCardIndex = number.Next(0, 52);
            }

                    myHand.Add(deck[nextCardIndex]);
                    deck[nextCardIndex].Dealt = true;
                    rtbHand1.Text += string.Format("{0} of {1} \n", deck[nextCardIndex].myCard.ToString(), deck[nextCardIndex].Suit);

            
        }

        private void PlayBlackjack_Load(object sender, EventArgs e)
        {
            ConstructDeckOfCards(deck);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
