
namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int healt)
        {
            this.Name = name;
            this.Element = element;
            this.Healt = healt;
        }
        public string Name { get; set; }
        public string Element { get; set; }
        public int Healt { get; set; }
    }
}
