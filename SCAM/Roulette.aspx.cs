using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCAM
{
    public partial class Roulette : System.Web.UI.Page
    {
        Player player;
       // private static double money = 100;
       // private static decimal bet = 0;
        private static string[] colorOfSpace = new string[0];
        private static string[] evenOrOdd = new string[0];
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["User"] != null) {
                player = ((Player)Session["User"]);
                if (!IsPostBack)
                {
                    Moneylbl.Text = player.money.ToString();
                }
            }
            else {
                Response.Redirect("Home.aspx");
            }
        }
        protected void SpinButton_Click(object sender, EventArgs e)
        {
            Session["alreadyWon"] = null;
            int wheelLandingPoint = RandomNumber();
            wheelLandingPoint = 5;

            RouletteNumberlbl.Text = wheelLandingPoint.ToString();
            List<int> numBets = NumberBets();
            int NumberOfBetsPlaced = numBets.Count + SpecialBets().Count;
            try
            {
                decimal bet;
                bet = Convert.ToDecimal(tbBet.Text);
                Session["bet"] = bet;
                if (NumberOfBetsPlaced == 0)

                {
                    resultLbl.Text = "You Must Place A Bet";
                }
                else if (player.money - bet * NumberOfBetsPlaced < 0)
                {
                    resultLbl.Text = "Your bets exceed your money.";
                }
                else
                {
                    player.money -= bet * NumberOfBetsPlaced;
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
                    // the number bets
                    for (int i = 0; i < numBets.Count; i++)
                    {
                        NumberMatch(wheelLandingPoint, numBets[i]);
                    }
                }
                // the special bets

                // top 2 to 1
                if (cbs0.Checked)
                {
                    int[] bets = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
                    WinOrLose(wheelLandingPoint, bets, 3);
                }
                //mid 2 to 1
                if (cbs1.Checked)
                {
                    int[] bets = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
                    WinOrLose(wheelLandingPoint, bets, 3);
                }
                //bottom 2 to 1 
                if (cbs2.Checked)
                {
                    int[] bets = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
                    WinOrLose(wheelLandingPoint, bets, 3);
                }

                //first 12
                if (cbs3.Checked)
                {
                    int[] bets = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    WinOrLose(wheelLandingPoint, bets, 3);
                }
                //second 12
                if (cbs4.Checked)
                {
                    int[] bets = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
                    WinOrLose(wheelLandingPoint, bets, 3);
                }
                //third 12
                if (cbs5.Checked)
                {
                    int[] bets = { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                    WinOrLose(wheelLandingPoint, bets, 3);
                }
                // 1-18
                if (cbs6.Checked)
                {
                    int[] bets = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                13, 14, 15, 16, 17, 18};
                    WinOrLose(wheelLandingPoint, bets, 2);
                }
                // even
                if (cbs7.Checked)
                {
                    List<int> bets = new List<int>();
                    for (int i = 1; i < 37; i++)
                    {
                        if (i % 2 == 0)
                        {
                            bets.Add(i);
                        }
                    }
                    WinOrLose(wheelLandingPoint, bets, 2);
                }
                // black
                if (cbs8.Checked)
                {
                    int[] bets = { 2,4,6,8,10,11,13,15,17
                        ,20,22,24,26,28,29,31,33,35};
                    WinOrLose(wheelLandingPoint, bets, 2);
                }
                // red
                if (cbs9.Checked)
                {
                    int[] bets = { 1,3,5,7,9,12,14,16,18,19,
                            21,23,25,27,30,32,34,36};
                    WinOrLose(wheelLandingPoint, bets, 2);
                }
                // odd 
                if (cbs10.Checked)
                {
                    List<int> bets = new List<int>();
                    for (int i = 1; i < 37; i++)
                    {
                        if (i % 2 == 1)
                        {
                            SelectDeSelect(i);
                        }
                    }
                    WinOrLose(wheelLandingPoint, bets, 2);
                }
                //19-36
                if (cbs11.Checked)
                {
                    int[] bets = { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
                    WinOrLose(wheelLandingPoint, bets, 2);
                }
            }
            catch { }


        }

        private static int RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(36);
        }

        private List<int> NumberBets()
        {
            List<int> bets = new List<int>();
            for (int i = 0; i < 37; i++)
            {
                if (((CheckBox)this.Master.FindControl("ContentPlaceHolder").FindControl("cb" + i)).Checked)
                {
                    bets.Add(i);
                }
            }
            return (bets);
        }

        private List<int> SpecialBets()
        {
            List<int> bets = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                if (((CheckBox)this.Master.FindControl("ContentPlaceHolder").FindControl("cb" + i)).Checked)
                {
                    bets.Add(i);
                }
            }
            return (bets);
        }

        private void lose()
        {
            if (Session["alreadyWon"] == null)
            {
                resultLbl.Text = "You Lose";
            }
            
            
        }

        private void win(int multi)
        {
            if (ViewState["varible"] != null)
            {
                
                
                //money = (double)ViewState["varible"] + (bet * multi);
            }
            Session["User"] = player;
            player.money += (decimal)Session["bet"] * multi;
            System.Diagnostics.Debug.WriteLine("Profit: " + player.money);
            Moneylbl.Text = player.money.ToString();
            //ViewState["varible"] = money;
            resultLbl.Text = "You win";
            Session["alreadyWon"] = true;
        }

        private void WinOrLose(int landingPoint,int[] bet, int muti)
        {
            bool won = false;
            for (int i = 0; i < bet.Length; i++)
            {
                if (bet[i] == landingPoint)
                {
                    won = true;
                }
            }
            if (won)
            {
                win(muti);
                player.rouletteWins++;
            }
            else
            {
                lose();
                player.roulettelosses++;
            }
            Session["User"] = player;

        }

        private void WinOrLose(int landingPoint, List<int> bet, int muti)
        {
            bool won = false;
            for (int i = 0; i < bet.Count; i++)
            {
                if (bet[i] == landingPoint)
                {
                    won = true;
                }
            }
            if (won)
            {
                win(muti);
                player.rouletteWins++;

            }
            else
            {
                lose();
                player.roulettelosses++;

            }
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

        private void NumberMatch(int LandingPoint, int bet)
        {
            if (LandingPoint == bet)
            {
                win(35);
                player.rouletteWins++;

            }
            else
            {
                lose();
                player.roulettelosses++;

            }
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


        private void SelectDeSelect(int i)
        {
            if (((CheckBox)this.Page.FindControl("cb" + i)).Checked == false)
            {
                ((CheckBox)this.Page.FindControl("cb" + i)).Checked = true;
            }
            else
            {
                ((CheckBox)this.Page.FindControl("cb" + i)).Checked = false;
            }
        }

        protected void top2to1_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < 37; i += 3)
            {
                SelectDeSelect(i);
            }
        }

        protected void mid2to1_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < 37; i += 3)
            {
                SelectDeSelect(i);
            }
        }

        protected void bottom2to1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i += 3)
            {
                SelectDeSelect(i);
            }
        }

        protected void btn1st12_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                SelectDeSelect(i);
            }
        }

        protected void btn2nd12_Click(object sender, EventArgs e)
        {
            for (int i = 13; i < 25; i++)
            {
                SelectDeSelect(i);
            }
        }

        protected void btn3rd12_Click(object sender, EventArgs e)
        {
            for (int i = 25; i < 37; i++)
            {
                SelectDeSelect(i);
            }
        }

        protected void btn118_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 19; i++)
            {
                SelectDeSelect(i);
            }
        }

        protected void btnEven_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i++)
            {
                if (i % 2 == 0)
                {
                    SelectDeSelect(i);
                }
            }
        }

        protected void btnOdd_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i++)
            {
                if (i % 2 == 1)
                {
                    SelectDeSelect(i);
                }
            }
        }

        protected void btn1936_Click(object sender, EventArgs e)
        {
            for (int i = 19; i < 37; i++)
            {
                SelectDeSelect(i);
            }
        }

        protected void btnBlack_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 36; i++)
            {
                if (i < 11)
                {
                    if (i % 2 == 0)
                    {
                        SelectDeSelect(i);
                    }
                }
                else if (i < 17)
                {
                    if (i % 2 == 1)
                    {
                        SelectDeSelect(i);
                    }
                }
                else if (i < 29)
                {
                    if (i % 2 == 0)
                    {
                        SelectDeSelect(i);
                    }
                }
                else if (i < 36)
                {
                    if (i % 2 == 1)
                    {
                        SelectDeSelect(i);
                    }
                }
            }
        }

        protected void btnRed_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i++)
            {
                if (i < 11)
                {
                    if (i % 2 == 1)
                    {
                        SelectDeSelect(i);
                    }
                }
                else if (i < 19)
                {
                    if (i % 2 == 0)
                    {
                        SelectDeSelect(i);
                    }
                }
                else if (i < 29)
                {
                    if (i % 2 == 1)
                    {
                        SelectDeSelect(i);
                    }
                }
                else if (i < 37)
                {
                    if (i % 2 == 0)
                    {
                        SelectDeSelect(i);
                    }
                }

            }
        }
    }

}
