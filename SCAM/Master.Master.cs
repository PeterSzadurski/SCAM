using System;
using System.Collections.Generic;
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
                lbLoginOrLogout.Text = "Log Out";
                lbRegisterOrAccount.Text = "Account";
                lbUserMessage.Text = "You are logged in as: " + ((Player)Session["User"]).username;
                lbMoney.Text = "$" + ((Player)Session["User"]).money.ToString();
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
                Response.Redirect("Account.aspx");
            }
        }
    }
}