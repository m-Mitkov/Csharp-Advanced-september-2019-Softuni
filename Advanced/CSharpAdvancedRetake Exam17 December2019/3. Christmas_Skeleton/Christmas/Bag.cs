using System.Linq;
using System.Text;

namespace Christmas
{
    class Bag
    {
        private Present[] data;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new Present[capacity];
        }
        public string Color { get; set; }
        public int Capacity { get; set; }

        public int Count { get; private set; }

        public void Add(Present present)
        {
            if (this.Count < this.Capacity)
            {
                data[Count] = present;
                this.Count++;
            }
        }

        public bool Remove(string name)
        {
            bool successfullyRemoved = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (data[i].Name == name)
                {
                    data[i] = null;
                    this.Count--;
                    successfullyRemoved = true;
                    break;
                }
            }

            return successfullyRemoved;
        }

        public Present GetHeaviestPresent()
        {
             Present heaviesPresent = data
                .Where(x => x != null)
                .OrderByDescending(x => x.Weight)
                .First();

            return heaviesPresent;
        }

        public Present GetPresent(string name)
        {
            Present presentToReturn = default;

            for (int i = 0; i < this.Count; i++)
            {
                if (data[i].Name == name)
                {
                    presentToReturn = data[i];
                }
            }

            return presentToReturn;
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.AppendLine($"{this.Color} bag contains:");

            foreach (var present in data)
            {
                if (present != null)
                {
                    report.AppendLine($"{present}");
                }
            }

            return report.ToString().TrimEnd();
        }
    }
}
