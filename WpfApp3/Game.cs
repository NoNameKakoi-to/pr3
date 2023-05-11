using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class Game
    {
        public List<Players> Players { get; set; }
        public static byte AmountOfPlayers { get; set; }
        public Game(byte amountofplayers, List<Players> players)
        {
            for (byte i = 1; i <= amountofplayers; i++)
            {
                players.Add(new Players("Players" + i));
            }
            Players = players;
        }
        public void Start()
        {
            Players[0].Status = true;
        }
    }
}
