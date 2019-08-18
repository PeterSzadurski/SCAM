using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCAM
{
    public partial class Slots : System.Web.UI.Page
    {
        

        //private static double money = 100;
        static int[,] Pos = new int[5, 3];
        Player player;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                player = (Player)Session["User"];
            }
            else {
                Response.Redirect("Home.aspx");
            }
           /* if (!IsPostBack)
            {
                Moneylbl.Text = money.ToString();
            }*/
        }

        protected void Spinbtn_Click(object sender, EventArgs e)
        {
            //   try {
            //decimal bet = 50;
            decimal bet;
              try {
                bet = Convert.ToDecimal(tbBet.Text);
            if (bet > 0 && player.money - bet > -1)
                {
                resultLbl.Text = "";
                    Session["bet"] = bet;
                    SpinandDisplay();


                    if (Pos[0, 0] == Pos[1, 0] && Pos[1, 0] == Pos[2, 0] && Pos[1, 0] == Pos[3, 0] && Pos[3, 0] == Pos[4, 0])
                    {
                        win(2);
                    }
                    else if (Pos[0, 1] == Pos[1, 1] && Pos[1, 1] == Pos[2, 1] && Pos[2, 1] == Pos[3, 1] && Pos[3, 1] == Pos[4, 1])
                    {
                        win(2);
                    }
                    else if (Pos[0, 2] == Pos[1, 2] && Pos[1, 2] == Pos[2, 2] && Pos[2, 2] == Pos[3, 2] && Pos[3, 2] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 0] == Pos[1, 1] && Pos[1, 1] == Pos[2, 0] && Pos[2, 0] == Pos[3, 1] && Pos[3, 1] == Pos[4, 0])
                    {
                        win(2);
                    }
                    else if (Pos[0, 2] == Pos[1, 1] && Pos[1, 1] == Pos[2, 0] && Pos[2, 0] == Pos[3, 1] && Pos[3, 1] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[2, 0] == Pos[1, 1] && Pos[1, 1] == Pos[2, 1] && Pos[2, 1] == Pos[3, 1] && Pos[3, 1] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 0] == Pos[1, 2] && Pos[1, 2] == Pos[2, 0] && Pos[2, 0] == Pos[3, 2] && Pos[3, 2] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 2] == Pos[1, 1] && Pos[1, 1] == Pos[2, 1] && Pos[2, 1] == Pos[3, 1] && Pos[3, 1] == Pos[4, 0])
                    {
                        win(2);
                    }
                    else if (Pos[0, 2] == Pos[1, 2] && Pos[1, 2] == Pos[2, 0] && Pos[2, 0] == Pos[3, 2] && Pos[3, 2] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 1] == Pos[1, 2] && Pos[1, 2] == Pos[2, 1] && Pos[2, 0] == Pos[3, 2] && Pos[3, 2] == Pos[4, 1])
                    {
                        win(2);
                    }
                    else if (Pos[0, 0] == Pos[1, 2] && Pos[1, 2] == Pos[2, 2] && Pos[2, 2] == Pos[3, 2] && Pos[3, 2] == Pos[4, 0])
                    {
                        win(2);
                    }
                    else if (Pos[0, 0] == Pos[1, 1] && Pos[1, 1] == Pos[2, 0] && Pos[2, 0] == Pos[3, 1] && Pos[3, 1] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 2] == Pos[1, 0] && Pos[1, 0] == Pos[2, 2] && Pos[2, 2] == Pos[3, 0] && Pos[3, 0] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 2] == Pos[1, 1] && Pos[1, 1] == Pos[2, 1] && Pos[2, 1] == Pos[3, 1] && Pos[3, 1] == Pos[4, 2])
                    {
                        win(2);
                    }
                    else if (Pos[0, 0] == Pos[1, 2] && Pos[1, 2] == Pos[2, 1] && Pos[2, 1] == Pos[3, 2] && Pos[3, 2] == Pos[4, 1])
                    {
                        win(2);
                    }
                    else
                    {
                        lose();
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
                }
            }catch{
                lbWarning.Text = "Please enter a valid number";
            }

            }

        void SpinandDisplay()
        {
            Random rnd = new Random();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Pos[row, col] = rnd.Next(5);
                    if (col == 0)
                    {
                        ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("row" + row + "x" + "col" + col + "lbl")).ImageUrl = "~/Assets/Images/Slots/" + Pos[row, col].ToString() + "Top.png";

                    }
                    else if (col == 2)
                    {
                        ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("row" + row + "x" + "col" + col + "lbl")).ImageUrl = "~/Assets/Images/Slots/" + Pos[row, col].ToString() + "Bot.png";

                    }
                    else
                    {
                        ((Image)this.Master.FindControl("ContentPlaceHolder").FindControl("row" + row + "x" + "col" + col + "lbl")).ImageUrl = "~/Assets/Images/Slots/" + Pos[row, col].ToString() + ".png";
                    }
                    }
            }
            

        }

        private void lose()
        {
            /*    if (ViewState["varible"] != null)
                {
                    money = (double)ViewState["varible"] - bet;
                }*/
            player.money -= (decimal)Session["bet"];
            player.slotlosses++;
            //Moneylbl.Text = player.money.ToString();
            ((Label)this.Master.FindControl("lbMoney")).Text = player.money.ToString();

            resultLbl.Text = "You Lose";
        }

        private void win(int multi)
        {
         /*   if (ViewState["varible"] != null)
            {
                money = (double)ViewState["varible"] + (bet * multi);
            }*/
            player.money += (decimal)Session["bet"] * multi;
            player.slotWins++;
            ((Label)this.Master.FindControl("lbMoney")).Text = player.money.ToString();
            //ViewState["varible"] = money;
            resultLbl.Text = "You win";
        }
    }
}