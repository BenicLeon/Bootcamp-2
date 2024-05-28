using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class FootballClub
    {

        private List<Player> players = new List<Player>();
        public bool Terminated {  get; set; }



        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void TerminateContract(int id)
        {
            Terminated = false;
            Player playerToRemove = players.Find(p => p.Id == id);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Terminated = true;
                Console.WriteLine($"Contract terminated for player: {playerToRemove.Name}");
            }
            else
            {
                Console.WriteLine($"Player with ID {id} not found!");
            }
        }
        public bool HasPlayers()
        {
            return players.Count > 0;
        }
        public void DisplayPlayers()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players currently signed.");
            }
            else
            {
                Console.WriteLine("List of Players:");
                foreach (var player in players)
                {
                    player.DisplayInfo();
                    
                }
            }
        }
    }
}
