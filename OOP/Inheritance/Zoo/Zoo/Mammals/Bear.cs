using Zoo.Mammals;


namespace Zoo
{
    public class Bear : Mammal
    {
        public Bear(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return $"I am a bear {this.Name}";
        }
    }
}
