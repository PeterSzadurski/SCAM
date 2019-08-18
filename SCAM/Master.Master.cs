using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCAM
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] != null)
            {

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = DAO.ConnectionString();


                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "SelectAccountNoPass";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = ((Player)Session["User"]).username;

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {

                            Player player = Player.GetPlayer(reader);
                            Session["User"] = player;
                        }

                        conn.Close();
                    }
                
                    


                    lbLoginOrLogout.Text = "Log Out";
                    lbRegisterOrAccount.Text = "Account";
                    lbUserMessage.Text = "You are logged in as: " + ((Player)Session["User"]).username;
                    lbMoney.Text = "    |    $" + ((Player)Session["User"]).money.ToString();
                    if (((Player)Session["User"]).role == "Owner")
                    {
                        lbRegisterOrAccount.Text = "Control Panel";
                    }
                }
            }
            else
            {
                lbMoney.Text = "";
                lbUserMessage.Text = "";
            }

        }

        protected void lbLoginOrLogout_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["User"] = null;
                Session["PlayerHand"] = null;
                Session["DealerHand"] = null;
                Response.Redirect("Home.aspx");
            }
        }
        protected void lbRegisterOrAccount_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Register.aspx");
            }
            else
            {
                if (((Player)Session["User"]).role == "Owner")
                    Response.Redirect("Owner.aspx");
                else
                {
                    Response.Redirect("Account.aspx");
                }
            }
        }

        protected void lbscoreBoard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Scoreboard.aspx");
        }



        protected void logoBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}