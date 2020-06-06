using System;
using System.Collections.Generic;
using System.Linq;

namespace Rabbits
{
    class Cage
    {
        List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;
        public void Add(Rabbit rabbit)
        {
            if (this.data.Count - 1 < this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }
        public bool RemoveRabbit(string name)
        {
            Rabbit rabbitToRemove = data.Where(x => x.Name == name).FirstOrDefault();

            if (data.Contains(rabbitToRemove))
            {
                data.Remove(rabbitToRemove);
                return true;
            }

            return false;
        }
        public void RemoveSpecies(string specie)
        {
            data.RemoveAll(x => x.Species == specie);
        }
        public Rabbit SellRabbit(string name)
        {
            var rabbitToSell = data.Where(x => x.Name == name).FirstOrDefault();
            rabbitToSell.Available = false;

            return rabbitToSell;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbitsToSell = data.Where(x => x.Species == species).ToArray();

            return rabbitsToSell;
        }
        public string Report()
        {
            string report = $"Rabbits available at {this.Name}:"
                + Environment.NewLine +
                $"{string.Join(Environment.NewLine, data.Where(x => x.Available == true))}";

            return report;
        }
    }
}
