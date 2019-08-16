using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;

namespace SCAM
{
    public partial class Account : System.Web.UI.Page
    {
        CreditCardAttribute cca = new CreditCardAttribute();
        Player player;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else {
                Session["lastPage"] = "Account.aspx";
                player = ((Player)Session["User"]);
                lbBlackjackWins.Text = player.blackjackWins.ToString();
                lbRouletteWins.Text = player.rouletteWins.ToString();
                lbSlotsWins.Text = player.slotWins.ToString();
                lbBlackjackLosses.Text = player.blackjacklosses.ToString();
                lbRouletteLosses.Text = player.roulettelosses.ToString();
                lbSlotsLosses.Text = player.slotlosses.ToString();
            }
        }

        protected void btnAddCard_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(tbDate);
            if (date < DateTime.Now && cca.IsValid(tbCredit.ToString())) {

            }
        }
    }
}