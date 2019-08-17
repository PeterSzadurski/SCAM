using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SCAM
{
    public partial class Account : System.Web.UI.Page
    {
        List<Creditcard> creditcards = new List<Creditcard>();
        Player player;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Session["lastPage"] = "Account.aspx";
                player = ((Player)Session["User"]);
                lbBlackjackWins.Text = player.blackjackWins.ToString();
                lbRouletteWins.Text = player.rouletteWins.ToString();
                lbSlotsWins.Text = player.slotWins.ToString();
                lbBlackjackLosses.Text = player.blackjacklosses.ToString();
                lbRouletteLosses.Text = player.roulettelosses.ToString();
                lbSlotsLosses.Text = player.slotlosses.ToString();

                // load credit cards
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = DAO.ConnectionString();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "SelectCreditCardFromUser";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = player.username;
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                creditcards.Add(new Creditcard(
                                    Convert.ToInt32(reader["CreditCardID"]),
                                    reader["Name"].ToString(),
                                    Convert.ToInt64(reader["Number"]),
                                    Convert.ToDateTime(reader["Expiration"].ToString()),
                                    reader["ccv"].ToString(),
                                    reader["Username"].ToString()));
                                // reader.NextResult();
                            }

                            gridCredit.DataSource = creditcards;
                            // this is needed
                            if (!IsPostBack) { gridCredit.DataBind(); }

                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        lbResult.Text = ex.ToString();
                    }
                }

            }


        }

        protected void btnAddCard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Date " + tbDate.Text);
            DateTime date = Convert.ToDateTime(tbDate.Text);
            System.Diagnostics.Debug.WriteLine("Date2 " + date.ToString());

            if (date > DateTime.Now)
            {
                System.Diagnostics.Debug.WriteLine("Valid date");
            }
            if (Creditcard.ValidCard(Convert.ToInt64(tbCredit.Text)))
            {
                System.Diagnostics.Debug.WriteLine("Valid credit");

            }
            if (date > DateTime.Now && Creditcard.ValidCard(Convert.ToInt64(tbCredit.Text)))
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = DAO.ConnectionString();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "CreateCard";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tbName.Text;
                            cmd.Parameters.Add("@Number", SqlDbType.BigInt).Value = Convert.ToInt64(tbCredit.Text);
                            cmd.Parameters.Add("@Expiration", SqlDbType.Date).Value = tbDate.Text;
                            cmd.Parameters.Add("@ccv", SqlDbType.VarChar).Value = tbCCV.Text;
                            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = player.username;
                            cmd.ExecuteScalar();
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        lbResult.Text = ex.ToString();
                    }
                    finally
                    {
                        Server.Transfer("Account.aspx");
                    }
                }
            }
        }

        public int selectedRadio()
        {
            int selected = 0;
            for (int i = 0; i < gridCredit.Rows.Count; i++)
            {
                if (((RadioButton)gridCredit.Rows[i].FindControl("rowSelector")).Checked)
                {
                    selected = i;
                    break;
                }
            }
            return selected;
        }

        protected void btnDeleteCard_Click(object sender, EventArgs e)
        {
            int selected = selectedRadio();
            // get the table card id
            int selectedCardId;
            selectedCardId = creditcards[selected].creditCardId;

            // delete the card
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = DAO.ConnectionString();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteCardById";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = selectedCardId;
                        cmd.ExecuteScalar();
                        conn.Close();
                        creditcards.RemoveAt(selected);
                    }
                }
            }

            catch (Exception ex)
            {
                lbResult.Text = ex.ToString();
            }
            finally
            {
                Server.Transfer("Account.aspx");
            }
        }

        protected void btnPayWithCard_Click(object sender, EventArgs e)
        {
            int selected = selectedRadio();
            try
            {
                decimal pay = Convert.ToDecimal(tbPay.Text);
                if (pay > 0) {
                    player.money += pay;
                    using (SqlConnection conn = new SqlConnection()) {
                        conn.ConnectionString = DAO.ConnectionString();
                        try
                        {
                            using (SqlCommand cmd = DAO.updatePlayer((Player)Session["User"]))
                            {
                                conn.Open();
                                cmd.Connection = conn;
                                cmd.ExecuteScalar();
                                Server.Transfer("Account.aspx");

                            }
                        }
                        catch (Exception ex) {
                            lbResult.Text = ex.ToString();
                        }
                    }
                }
            }
            catch { }
        }
    }
}
    
    
    
    