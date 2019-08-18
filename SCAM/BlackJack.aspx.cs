using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCAM
{

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


            if (HandWorth(((List<Card>)Session["PlayerHand"])) > 21)
            {
                lbWin.Text = "lose";
                btnStay.Visible = false;
                btnDoubleDown.Visible = false;
                btnHit.Visible = false;
                DisplayDealerHand(true);
            }



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
            if ((HandWorth(((List<Card>)Session["DealerHand"])) == HandWorth(((List<Card>)Session["PlayerHand"]))))
            {
                lbWin.Text = "break even";
                DisplayDealerHand(true);
                player.money += ((decimal)Session["bet"]);


            }
            else if ((playerHandWorth <= 21) && ((playerHandWorth > dealerHandWorth) || dealerHandWorth > 21))
            {
                lbWin.Text = "Player win";
                DisplayDealerHand(true);
                System.Diagnostics.Debug.WriteLine("Bet before " + ((decimal)Session["bet"]));
                decimal newBet = ((decimal)Session["bet"]);
                newBet *= multiplier;
                System.Diagnostics.Debug.WriteLine("Bet wit multi: "+ ((decimal)Session["bet"]));
                System.Diagnostics.Debug.WriteLine("Money before: " + player.money);
                player.money += newBet;
                System.Diagnostics.Debug.WriteLine("Money after: " + player.money);
                player.blackjackWins++;

            }
            else
            {
                lbWin.Text = "Dealer Win";
                player.blackjacklosses++;
                DisplayDealerHand(true);
            }


            Session["User"] = player;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = DAO.ConnectionString();

                using (SqlCommand cmd = DAO.updatePlayer((Player)Session["User"]))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteScalar();

                }

            }
            btnHit.Visible = false;
            btnStay.Visible = false;
            btnDoubleDown.Visible = false;
            Session["OngoingBlackjack"] = null;



            ((Label)this.Master.FindControl("lbMoney")).Text = player.money.ToString();
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
            if (Session["User"] != null)
            {
                player = (Player)Session["User"];
                if (Session["OngoingBlackjack"] != null) {
                    btnDoubleDown.Visible = true;
                    btnHit.Visible = true;
                    btnStay.Visible = true;
                }
            }
            else {
                Response.Redirect("Home.aspx");
            }
        }

        public void DisplayPlayerHand()
        {
            List<Card> playerHand = ((List<Card>)Session["PlayerHand"]);
            System.Diagnostics.Debug.WriteLine("player hand " + playerHand.Count);

            for (int i = 0; i < playerHand.Count; i++)
                ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("pCard" + i)).ImageUrl = playerHand[i].cardImage();

        }
        public void ClearPlayerHand()
        {

            for (int i = 0; i < 7; i++)
                ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("pCard" + i)).ImageUrl = "";
        }

        public void ClearDealerHand()
        {

            for (int i = 0; i < 7; i++)
                ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("dCard" + i)).ImageUrl = "";
        }
        public void DisplayDealerHand(bool gameEnd)
        {
            List<Card> dealerHand = ((List<Card>)Session["DealerHand"]);
            if (gameEnd)
            {
                ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("dCard0")).ImageUrl = dealerHand[0].cardImage();
            }
            else
            {
                ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("dCard0")).ImageUrl = "~/Assets/Images/Cards/Down.png";
            }
            for (int i = 1; i < dealerHand.Count; i++)
                ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("dCard" + i)).ImageUrl = dealerHand[i].cardImage();
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {

            lbWin.Text = "";
            try
            {
                decimal bet = Convert.ToDecimal(tbBet.Text);
                Session["bet"] = bet;
                System.Diagnostics.Debug.WriteLine("Bet:" + bet + " Money:" + player.money);
                if (bet <= player.money && bet > 0 && player.money - bet >= 0)
                {
                    lbBet.Text = "";
                    btnHit.Visible = true;
                    btnStay.Visible = true;
                    btnDoubleDown.Visible = true;

                    List<Card> dealerHand = new List<Card>();
                    List<Card> playerHand = new List<Card>();
                    Session["OngoingBlackjack"] = true;
                    Session["PlayerHand"] = null;
                    Session["dealerHand"] = null;

                    playerHand.Add(deck.RandomPick(rnd));
                    playerHand.Add(deck.RandomPick(rnd));
                    dealerHand.Add(deck.RandomPick(rnd));
                    dealerHand.Add(deck.RandomPick(rnd));
                    Session["PlayerHand"] = playerHand;
                    Session["dealerHand"] = dealerHand;




                    ClearDealerHand();
                    ClearPlayerHand();
                    DisplayPlayerHand();
                    DisplayDealerHand(false);
                    player.money -= bet;
                    Session["User"] = player;
                    ((Label)this.Master.FindControl("lbMoney")).Text = player.money.ToString();

                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = DAO.ConnectionString();

                        using (SqlCommand cmd = DAO.updatePlayer((Player)Session["User"]))
                        {
                            conn.Open();
                            cmd.Connection = conn;
                            cmd.ExecuteScalar();

                        }

                    }
                }
                else{
                    lbBet.Text = "Your bet exceeds your money";
                }

            }
            catch {
                lbBet.Text = "Please enter a valid bet";
            }
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
