using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        private List<Player> players;

        public Guild(string name, int capacity)
        {
            this.players = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get { return this.players.Count; }
        }

        public void AddPlayer(Player player)
        {
            if (players.Count < this.Capacity && !players.Any(x => x.Name == player.Name))
            {
                this.players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (players.Any(x => x.Name == name))
            {
                Player temp = players.Where(x => x.Name == name).FirstOrDefault();
                players.Remove(temp);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            if (players.Any(x => x.Name == name))
            {
                Player temp = players.Where(x => x.Name == name).FirstOrDefault();

                temp.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (players.Any(x => x.Name == name))
            {
                Player temp = players.Where(x => x.Name == name).FirstOrDefault();

                temp.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> tempList = new List<Player>();

            foreach (var player in this.players)
            {
                if (player.Class == @class)
                {
                    tempList.Add(player);
                }
            }

            Player[] arrayToReturn = tempList.ToArray();

            this.players = this.players.Where(x => x.Class != @class).ToList();

            return arrayToReturn;
        }

        public override string ToString()
        {
            StringBuilder returnInfo = new StringBuilder();

            returnInfo.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in this.players)
            {
                returnInfo.AppendLine($"Player {player.Name}: {player.Class}");
                returnInfo.AppendLine($"Rank: {player.Rank}");
                returnInfo.AppendLine($"Description: {player.Description}");
            }

            return returnInfo.ToString().TrimEnd();
        }
    }
}
