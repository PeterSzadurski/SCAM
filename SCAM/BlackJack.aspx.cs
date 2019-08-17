using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCAM { 

    public enum Suit { h, s, c, d }



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
            if (this.worth <= 10)
            {
                return this.worth + this.suit.ToString();
            }
            else
            {
                char symbol = ' ';
                switch (this.worth)
                {
                    case 11:
                        symbol = 'J';
                        break;
                    case 12:
                        symbol = 'K';
                        break;
                    case 13:
                        symbol = 'Q';
                        break;
                }
                return symbol + this.suit.ToString();
            }
        }



        public string cardImage()
        {
            return "~/Assets/Images/Cards/" + this.ToString() + ".png";
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
                cards.Add(new Card(i, Suit.c));
                cards.Add(new Card(i, Suit.d));
                cards.Add(new Card(i, Suit.h));
                cards.Add(new Card(i, Suit.s));
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


    public partial class Blackjack : System.Web.UI.Page
    {
        Player player;
        
        public Random rnd = new Random();
        Deck deck = new Deck();

        /* <summary>
         * Allows player to split the deck if it contains pairs or if it is equal to 16
             </summary> */
        void Split()
        {
            List<Card> playerHand = ((List<Card>)Session["PlayerHand"]);
            /*<remarks>
             * The conditions stop the function from working unless it's a valid split.
             * </remarks>
             */
            if ((playerHand.Count == 2) && (playerHand[0].Worth == playerHand[1].Worth || HandWorth(playerHand) == 16))
            {

            }
        }

        void Hit()
        {
            ((List<Card>)Session["PlayerHand"]).Add(deck.RandomPick(rnd));

            playerTable.DataSource = ((List<Card>)Session["PlayerHand"]);

            playerTable.DataBind();
            if (HandWorth(((List<Card>)Session["PlayerHand"])) > 21)
            {
                lbWin.Text = "lose";

                DisplayDealerHand(true);
            }
            lbPlayerMoney.Text = HandWorth(((List<Card>)Session["PlayerHand"])).ToString();
            lbDealerMoney.Text = HandWorth(((List<Card>)Session["DealerHand"])).ToString();


        }
        void Stay(decimal multiplier)
        {
            // draw the dealer until at least 17
            while (HandWorth(((List<Card>)Session["DealerHand"])) < 17)
            {
                ((List<Card>)Session["DealerHand"]).Add(deck.RandomPick(rnd));
            }
            //((List<Card>)Session["DealerHand"]).Add(deck.RandomPick(rnd));

            int dealerHandWorth = HandWorth(((List<Card>)Session["DealerHand"]));
            int playerHandWorth = HandWorth(((List<Card>)Session["PlayerHand"]));
            if ((21 - HandWorth(((List<Card>)Session["DealerHand"])) == (21 - HandWorth(((List<Card>)Session["PlayerHand"])))))
            {
                lbWin.Text = "break even";
                DisplayDealerHand(true);

            }
            else if ((playerHandWorth >= 21) && (21 - playerHandWorth >= 0) && ((21 - playerHandWorth < 21 - dealerHandWorth) || (21 - dealerHandWorth < 0)))
            {
                lbWin.Text = "Player win";
                DisplayDealerHand(true);
                decimal money = Convert.ToDecimal(lbMoney.Text);
                money *= multiplier;
                lbMoney.Text = money.ToString();
            }
            else if ((dealerHandWorth >= 21) && (21 - dealerHandWorth >= 0) && ((21 - dealerHandWorth < 21 - playerHandWorth) || (21 - playerHandWorth < 0)))
            {
                lbWin.Text = "Dealer Win";
                DisplayDealerHand(true);
            }



            dealerTable.DataSource = ((List<Card>)Session["DealerHand"]);
            dealerTable.DataBind();
            lbPlayerMoney.Text = HandWorth(((List<Card>)Session["PlayerHand"])).ToString();
            lbDealerMoney.Text = HandWorth(((List<Card>)Session["DealerHand"])).ToString();
        }
        public int HandWorth(List<Card> hand)
        {
            int handWorth = 0;
            int acesCount = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].worth == 1)
                {
                    acesCount++;
                }
                else if (hand[i].worth > 10)
                {
                    handWorth += 10;
                }
                else
                {
                    handWorth += hand[i].worth;
                }

            }
            // consider the aces

            for (int i = 0; i < acesCount; i++)
            {
                if (handWorth + 11 > 21)
                {
                    handWorth++;
                }
                else
                {
                    handWorth += 11;
                }
            }
            return handWorth;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            player = (Player)Session["User"];
        }

        public void DisplayPlayerHand()
        {
            List<Card> playerHand = ((List<Card>)Session["PlayerHand"]);
            for (int i = 0; i < playerHand.Count; i++)
                ((Image)this.Page.FindControl("pCard" + i)).ImageUrl = playerHand[i].cardImage();
        }
        public void DisplayDealerHand(bool gameEnd)
        {
            List<Card> dealerHand = ((List<Card>)Session["DealerHand"]);
            if (gameEnd)
            {
                ((Image)this.Page.FindControl("dCard0")).ImageUrl = dealerHand[0].cardImage();
            }
            else
            {
                ((Image)this.Page.FindControl("dCard0")).ImageUrl = "~/Assets/Images/Cards/Down.png";
            }
            for (int i = 1; i < dealerHand.Count; i++)
                ((Image)this.Page.FindControl("dCard" + i)).ImageUrl = dealerHand[i].cardImage();
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            List<Card> dealerHand = new List<Card>();
            List<Card> playerHand = new List<Card>();


            playerHand.Add(deck.RandomPick(rnd));
            playerHand.Add(deck.RandomPick(rnd));
            dealerHand.Add(deck.RandomPick(rnd));
            dealerHand.Add(deck.RandomPick(rnd));
            Session["PlayerHand"] = playerHand;
            Session["dealerHand"] = dealerHand;
            playerTable.DataSource = Session["PlayerHand"];
            playerTable.DataBind();
            dealerTable.DataSource = Session["DealerHand"];
            dealerTable.DataBind();
            lbMoney.Text = tbMoney.Text;




            lbPlayerMoney.Text = HandWorth(((List<Card>)Session["PlayerHand"])).ToString();
            lbDealerMoney.Text = HandWorth(((List<Card>)Session["DealerHand"])).ToString();
            DisplayPlayerHand();
            DisplayDealerHand(false);
        }

        protected void btnHit_Click(object sender, EventArgs e)
        {

            Hit();
            DisplayPlayerHand();

        }

        protected void btnStay_Click(object sender, EventArgs e)
        {
            Stay(2);
            DisplayDealerHand(true);

        }

        protected void btnDoubleDown_Click(object sender, EventArgs e)
        {
            Hit();
            DisplayPlayerHand();
            DisplayDealerHand(true);
            Stay(3);
        }
    }
}
