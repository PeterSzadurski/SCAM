using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;


namespace SCAM
{
    public static class DAO
    {
        public static string ConnectionString()
        {
            return "server=DESKTOP-20E1M0S\\SQLEXPRESS; database=ScamProject;Integrated Security = SSPI";
        }
        static public SqlCommand updatePlayer(Player player) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "updatePlayer";
            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = player.username;
            cmd.Parameters.Add("@BlackjackWins", SqlDbType.Int).Value = player.blackjackWins;
            cmd.Parameters.Add("@RouletteWins ", SqlDbType.Int).Value = player.rouletteWins;
            cmd.Parameters.Add("@SlotWins", SqlDbType.Int).Value = player.slotWins;
            cmd.Parameters.Add("@BlackjackLosses", SqlDbType.Int).Value = player.blackjacklosses;
            cmd.Parameters.Add("@RouletteLosses", SqlDbType.Int).Value = player.roulettelosses;
            cmd.Parameters.Add("@SlotLosses", SqlDbType.Int).Value = player.roulettelosses;
            cmd.Parameters.Add("@Money", SqlDbType.Money).Value = player.money;
            return cmd;
        }
    }
}