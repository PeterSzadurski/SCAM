using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCAM
{

    public enum Suit { hearts, spades, clubs, diamonds }
    public enum CardType { Normal, Ace, Jack, King, Queen }


    public class Card
    {

        private Suit suit;
        public int worth;
        public Card(int Worth, Suit Suit)
        {
            if (Worth > 13)
            {

            }

            worth = Worth;
            suit = Suit;
        }
        public Suit Suit { get { return this.suit; } }
        public int Worth
        {
            get
            {
                if (this.worth <= 10)
                {
                    return this.worth;
                }
                else
                {
                    return 10;
                }
            }
        }

        public string ToString()
        {
            if (this.Worth <= 10)
            {
                return this.Worth + " of " + this.suit;
            }
            else
            {
                string specialWorth;
                switch (this.Worth)
                {
                    case 11:
                        specialWorth = "Jack";
                        break;
                    case 12:
                        specialWorth = "King";
                        break;
                    case 13:
                        specialWorth = "Queen";
                        break;
                    default:
                        specialWorth = "Jack";
                        break;
                }
                return specialWorth + " of " + this.suit;
            }
        }

    }
    class Deck
    {



        ArrayList cards = new ArrayList();
        public Deck()
        {
            cards = new ArrayList();
            for (int i = 1; i < 14; i++)
            { // 11 is jack, 12 is king, 13 is queen
                cards.Add(new Card(i, Suit.clubs));
                cards.Add(new Card(i, Suit.diamonds));
                cards.Add(new Card(i, Suit.hearts));
                cards.Add(new Card(i, Suit.spades));
            }

        }
        public Card RandomPick(Random rnd)
        {
            int index = rnd.Next(0, cards.Count - 1);
            Card card = (Card)cards[index];
            //Console.WriteLine("The card was {0}", index);
            //Console.WriteLine("Test Card: " + ((Card)cards[1]).worth + " of "+ ((Card)cards[0]).suit);
            cards.RemoveAt(index);
            //  Console.WriteLine("The given card is: " + card.worth + " of " + card.suit);
            return card;
        }




    }


    public partial class BlackJack : System.Web.UI.Page
    {
       public int HandWorth(List<Card> hand) {
            int handWorth = 0;
            int acesCount = 0;
            for (int i = 0; i < hand.Count; i++) {
                if (hand[i].worth == 1)
                {
                    acesCount++;
                }
                else {
                    handWorth += hand[i].worth;
                }
    
            }
            // consider the aces

            for (int i = 0; i < acesCount; i++) {
                if (handWorth + 11 > 21)
                {
                    handWorth++;
                }
                else {
                    handWorth += 11;
                }
            }
            return handWorth;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}