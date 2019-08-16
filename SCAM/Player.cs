using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SCAM
{
    public class Player
    {
       public decimal money { get; }
       public string username { get; }
       public int slotWins { get; }
       public int blackjackWins { get; }
       public int rouletteWins { get; }
       public int slotlosses { get; }
       public int blackjacklosses { get; }
       public int roulettelosses { get; }
       public string role { get; }
       public DateTime date { get; }


        public Player(string Username, int BlackjackWins,
            int RouletteWins, int SlotWins, int BlackjackLosses, int RouletteLosses, int SlotLosses, decimal
            Money, DateTime Date, string Role)
        {
            username = Username;
            money = Money;
            slotWins = SlotWins;
            blackjackWins = BlackjackWins;
            rouletteWins = RouletteWins;
            roulettelosses = RouletteLosses;
            slotlosses = SlotLosses;
            blackjacklosses = BlackjackLosses;
            role = Role;
            date = Date;
        }
        public static Player GetPlayer(SqlDataReader reader) {
            Player player = new Player(
                reader["Username"].ToString(),
            Convert.ToInt32(reader["BlackjackWins"]),
            Convert.ToInt32(reader["RouletteWins"]),
            Convert.ToInt32(reader["SlotWins"]),
            Convert.ToInt32(reader["BlackJackLosses"]),
            Convert.ToInt32(reader["RouletteLosses"]),
            Convert.ToInt32(reader["SlotLosses"]),
            Convert.ToDecimal(reader["Money"]),
            Convert.ToDateTime(reader["RegistrationDate"]),
            reader["Role"].ToString());
            return player;
        }
    
     }   
    }
