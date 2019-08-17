using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SCAM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                if (((string)Session["lastPage"]) != "Login.aspx")
                {
                    Response.Redirect(((string)Session["lastPage"]));
                }
                else {
                    Response.Redirect("Home.aspx");
                }
            }
            else {
                Session["lastPage"] = "Login.aspx";
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = DAO.ConnectionString();
                int foundUser = 0;
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand()) {
                        cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "SelectAccount";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = tbLogin.Text;
                            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = tbPass.Text;
                        SqlDataReader reader= cmd.ExecuteReader();
                        if (reader.Read()) {
                            
                            Player player = Player.GetPlayer(reader);
                            Session["User"] = player;
                        }

                            conn.Close();
                            Response.Redirect("Account.aspx");
                        }
                    }
                    catch (Exception ex) {
                        lbResult.Text = ex.ToString();
                    }
                }
            }
        }
    }
