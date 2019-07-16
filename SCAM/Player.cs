using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCAM
{
    public class Player
    {
        decimal money;
        string username;
        int blackjackGamesPlayed;
        int rouletteGamesPlayed;
        int slotsGamesPlayed;
        float blackjackWR;
        float rouletteWR;
        float slotsWR;

        public Player(string Username, decimal Money)
        {
            username = Username;
            money = Money;
        }
    }
}