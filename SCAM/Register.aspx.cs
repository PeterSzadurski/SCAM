using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace SCAM
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = DAO.ConnectionString();
                System.Diagnostics.Debug.WriteLine(WebConfigurationManager.ConnectionStrings[0].ConnectionString);
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "CreateUser";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = tbUsername.Text;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = tbPassword.Text;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        cmd.CommandText = "SelectAccount";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = tbUsername.Text;
                        SqlDataReader reader = cmd.ExecuteReader();

                        Player player = Player.GetPlayer(reader);
                        Session["User"] = player;
                        Server.Transfer("Home.aspx");
                    }
                }
                catch (Exception ex) {
                    lbResult.Text = ex.ToString();
                }

            }
        }
    }
}