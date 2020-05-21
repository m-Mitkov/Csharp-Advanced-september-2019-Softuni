using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.roster.Count();
        
        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player temp = roster.Where(x => x.Name == name).FirstOrDefault();
                roster.Remove(temp);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player temp = roster.Where(x => x.Name == name).FirstOrDefault();

                temp.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player temp = roster.Where(x => x.Name == name).FirstOrDefault();

                temp.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> tempList = new List<Player>();

            foreach (var player in this.roster)
            {
                if (player.Class == @class)
                {
                    tempList.Add(player);
                }
            }

            Player[] arrayToReturn = tempList.ToArray();

            this.roster = this.roster.Where(x => x.Class != @class).ToList();

            return arrayToReturn;
        }

        public override string ToString()
        {
            StringBuilder returnInfo = new StringBuilder();

            returnInfo.AppendLine($"Players in the guild: {this.Name}");

            foreach (var player in this.roster)
            {
                returnInfo.AppendLine($"Player {player.Name}: {player.Class}");
                returnInfo.AppendLine($"Rank: {player.Rank}");
                returnInfo.AppendLine($"Description: {player.Description}");
            }

            return returnInfo.ToString().TrimEnd();
        }
    }
}
