using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {

        public Player(string name, string @class)
        {
            this.Name = name;
            this.Class = @class;
            this.Rank = "Trail";
            this.Description = "n/a";
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder inforPlayer = new StringBuilder();

            inforPlayer.AppendLine($"Player {this.Name}: {this.Class}");
            inforPlayer.AppendLine($"Rank: {this.Rank}");
            inforPlayer.AppendLine($"Description: {this.Description}");

            return inforPlayer.ToString().TrimEnd();
        }
    }
}
