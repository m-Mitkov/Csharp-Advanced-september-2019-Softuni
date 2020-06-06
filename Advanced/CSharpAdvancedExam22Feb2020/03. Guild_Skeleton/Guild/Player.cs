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
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; } = "Trail";
        public string Description { get; set; } = "n/a";

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
